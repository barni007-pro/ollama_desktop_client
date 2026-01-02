import os
import sys
import json
import requests
import warnings
import urllib3
import xml.etree.ElementTree as ET

# === Proxy & SSL-Warnungen deaktivieren ===
for var in ["HTTP_PROXY", "HTTPS_PROXY", "http_proxy", "https_proxy"]:
    os.environ.pop(var, None)
warnings.simplefilter("ignore", urllib3.exceptions.InsecureRequestWarning)

# === Konfiguration ===
OAUTH_URL = "https://muvie.ad.ndr-net.de/auth/realms/vidispine/connect/token"
API_BASE_URL = "https://muvie.ad.ndr-net.de/API"

CLIENT_ID = "externalClient"
CLIENT_SECRET = "90731259-08A6-4b0d-8F5F-7FC848C77602"


# === Hilfsfunktionen ===
def _xml_element_to_dict(elem):
    """
    Konvertiert ein xml.etree.ElementTree.Element rekursiv in ein Python-Dict.
    Attribute werden mit '@attrname' gespeichert, Text mit '#text'.
    Gleichnamige Kinder werden als Liste gruppiert.
    """
    node = {}
    # Attribute
    for k, v in elem.attrib.items():
        node[f"@{k}"] = v

    # Kinder
    children = list(elem)
    if children:
        child_map = {}
        for child in children:
            child_name = child.tag
            child_dict = _xml_element_to_dict(child)
            if child_name in child_map:
                # bereits vorhanden -> Liste
                if not isinstance(child_map[child_name], list):
                    child_map[child_name] = [child_map[child_name]]
                child_map[child_name].append(child_dict)
            else:
                child_map[child_name] = child_dict
        node.update(child_map)
    # Text (falls vorhanden und nicht nur whitespace)
    text = (elem.text or "").strip()
    if text:
        node["#text"] = text

    return node


def parse_response_content(response):
    """
    Versucht, die Antwort in der Reihenfolge zu parsen:
      1. JSON (Content-Type oder heuristisch)
      2. XML (Content-Type oder heuristisch)
      3. Sonst: roher Text (string)
    Gibt Python-Objekt (dict/list/str) zurück.
    """
    text = response.text or ""
    ct = (response.headers.get("Content-Type") or "").lower()

    # 1) JSON, wenn Content-Type JSON oder Text beginnt mit { oder [
    json_like = "application/json" in ct or text.lstrip().startswith(("{", "["))
    if json_like:
        try:
            return response.json()
        except Exception:
            # Falls fehlerhaftes JSON, weiter versuchen
            pass

    # 2) XML, wenn Content-Type xml oder Text beginnt mit <?xml or <
    xml_like = ("xml" in ct) or text.lstrip().startswith("<?xml") or text.lstrip().startswith("<")
    if xml_like:
        try:
            root = ET.fromstring(text)
            return {root.tag: _xml_element_to_dict(root)}
        except Exception:
            # Wenn XML-Parsing fehlschlägt, weiter unten Rohtext zurückgeben
            pass

    # 3) Fallback: wenn leerer Body
    if not text.strip():
        return None

    # 4) Letzter Versuch: JSON parse ohne rely auf header
    try:
        return json.loads(text)
    except Exception:
        pass

    # 5) Sonst roher Text
    return text


# === OAuth & API Funktionen ===
def get_access_token():
    """Holt ein OAuth2-Access-Token mit Client-Credentials-Flow."""
    data = {
        "grant_type": "client_credentials",
        "client_id": CLIENT_ID,
        "client_secret": CLIENT_SECRET
    }

    response = requests.post(OAUTH_URL, data=data, verify=False)
    if response.status_code != 200:
        raise Exception(f"Fehler beim Abrufen des Tokens: {response.status_code} - {response.text}")

    # Erwartet normalerweise JSON; falls nicht, parse robust
    parsed = parse_response_content(response)
    if isinstance(parsed, dict):
        return parsed.get("access_token")
    else:
        raise Exception(f"Token-Response nicht im erwarteten JSON-Format: {type(parsed).__name__} | Inhalt: {response.text}")


def get_metadata(item_vx, token):
    """Ruft die Metadaten für ein bestimmtes Item ab und parst JSON/XML/Text."""
    url = f"{API_BASE_URL}/item/{item_vx}/metadata"
    headers = {"Authorization": f"Bearer {token}"}

    response = requests.get(url, headers=headers, verify=False)
    if response.status_code != 200:
        # Falls Server HTML/XML-Fehlerseite liefert, gib das zurück für bessere Diagnose
        raise Exception(f"Fehler beim Abrufen der Metadaten: {response.status_code} - {response.text}")

    parsed = parse_response_content(response)
    return parsed


# === Hauptprogramm ===
if len(sys.argv) != 2:
    print("Bitte ein JSON-Argument übergeben.")
    sys.exit(1)

try:
    json_input = json.loads(sys.argv[1])
    name = json_input.get("name")
    item_vx = json_input.get("arguments", {}).get("item-vx")

    if name != "get_metadata":
        print("Ungültiger Funktionsname. Verwende 'get_metadata'.")
        sys.exit(1)

    if not item_vx:
        print("Fehler: 'item-vx' fehlt im Argument.")
        sys.exit(1)

    token = get_access_token()
    result = get_metadata(item_vx, token)

    # Wenn None (leerer Body), gebe klaren Hinweis
    if result is None:
        print(json.dumps({"message": "Leere Antwort vom Server (kein Inhalt)."}, indent=2, ensure_ascii=False))
    else:
        # Falls Ergebnis einfacher String (Text), gib es als Objekt zurück
        if isinstance(result, (str,)):
            print(json.dumps({"text": result}, indent=2, ensure_ascii=False))
        else:
            print(json.dumps(result, indent=2, ensure_ascii=False))

except Exception as e:
    print(f"Fehler: {e}")
    sys.exit(1)

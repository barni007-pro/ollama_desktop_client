# Ollama Desktop

---

> **Languages:** [English](README.md) | [Deutsch](README.de.md)

---

**Ollama Desktop** ist eine grafische Benutzeroberfläche (GUI) für **Ollama**. Sie ermöglicht es dir, lokal installierte KI-Modelle komfortabel zu steuern, Parameter fein abzustimmen und strukturierte JSON-Antworten zu erzwingen.

---

![Ollama Desktop Screenshot](./screenshots/response_html.png)

---

### ✨ Highlights
* **🤖 SSH Bot (Autonomer KI-Agent):** Exklusives Feature! Verwandelt die App in einen autonomen Systemadministrator, der Server per SSH verwaltet, Befehle ausführt und selbstständig auf Terminal-Ausgaben reagiert.
* **Vision-Unterstützung:** Bilder (.jpg,.png) hochladen und analysieren (z. B. mit llava) im Generate-Modus.
* **Dateien einlesen:** Importieren von Textdateien (.pdf, .txt, .json), um deren Inhalte direkt in den Kontext einzubinden.
* **RAG-Tool:** Chatten mit großen Dokumenten (.pdf/.txt) durch lokale Wissensextraktion.
* **Chat-Modus:** Modellwechsel während der Konversation möglich.
* **Tools & Functions:** Lokale Python-Code-Ausführung durch das Modell.
* **JSON-Modus:** Erzwingen von strukturierten Antworten.
* **Code-Ausführung:** Direktes Ausführen von Python, PowerShell oder Batch-Skripten.
* **Screenshots:** Verabeiten von Screenshots durch ein Vision LLM.
* **Formelausgabe:** Anzeigen von mathematischen Formeln (LaTeX Unterstützung).
* **Bildgenerierung:** Unterstützung für die Bildgenerierung der Modelle x/z-image-turbo und x/flux2-klein.

---

### 📥 [Neueste Version herunterladen](https://github.com/barni007-pro/ollama_desktop_client/releases/latest)

Du hast die Wahl zwischen der **Portablen** Version (keine Installation erforderlich) und der **Setup**-Version (Standard-Installation).

## 📦 Installation & Einrichtung

### 🚀 Option 1: Portable Version
1. **Download:** Lade die `Ollama_Desktop_Portable_x.x.x.x.zip` von der [Releases](https://github.com/barni007-pro/ollama_desktop_client/releases)-Seite herunter.
2. **Entpacken:** Entpacke das Archiv in einen Ordner deiner Wahl.
3. **Starten:** Führe die `Ollama_Desktop.exe` direkt aus dem entpackten Ordner aus.

### 💻 Option 2: Setup-Version (Installer)
1. **Download:** Lade die `Ollama_Desktop_Setup_x.x.x.x.zip` von der [Releases](https://github.com/barni007-pro/ollama_desktop_client/releases)-Seite herunter.
2. **Entpacken:** Entpacke die Installationsdatei aus dem ZIP-Archiv.
3. **Installieren:** Starte die Setup-Datei und folge den Anweisungen auf dem Bildschirm.
4. **Starten:** Öffne die Anwendung nach der Installation über das Startmenü oder die Desktop-Verknüpfung.

---

> [!IMPORTANT]
> **Ollama Server:** Stelle sicher, dass der Ollama-Server läuft (Terminal: `ollama serve`), bevor du den Desktop-Client startest.

---

## 🖼️ UI-Übersicht

<details>
  <summary><b>Hier klicken: Screenshots aller Tabs anzeigen (Bilder zum Vergrößern anklicken)</b></summary>

| Tab: Model Info | Tab: Model Parameter |
| :---: | :---: |
| [![Model Info](./screenshots/model_info.png)](./screenshots/model_info.png) | [![Model Parameter](./screenshots/model_parameter.png)](./screenshots/model_parameter.png) |
| **Tab: Tools** | **Tab: RAG Tool** |
| [![Tools](./screenshots/tools.png)](./screenshots/tools.png) | [![RAG Tool](./screenshots/rag_tool.png)](./screenshots/rag_tool.png) |
| **Tab: Request JSON** | **Tab: Response JSON** |
| [![Request JSON](./screenshots/request_json.png)](./screenshots/request_json.png) | [![Response JSON](./screenshots/response_json.png)](./screenshots/response_json.png) |
| **Tab: Response MarkDown** | **Tab: Response HTML** |
| [![Response MarkDown](./screenshots/response_markdown.png)](./screenshots/response_markdown.png) | [![Response HTML](./screenshots/response_html.png)](./screenshots/response_html.png) |
| **Tab: Code Parameter** | **Tab: Code Block** |
| [![Code Parameter](./screenshots/code_parameter.png)](./screenshots/code_parameter.png) | [![Code Block](./screenshots/code_block.png)](./screenshots/code_block.png) |

</details>

---

## 🚀 Schnellstart

1.  **Ollama-Server starten:** Starte den Ollama-Server im Hintergrund (Terminal: `ollama serve`).
2.  **LLM-Liste laden:** Klicke oben links in der App auf **Get LLM List**, um deine installierten Modelle zu laden.
3.  **Modell auswählen:** Wähle ein Modell aus dem Dropdown-Menü (z. B. `llama3` oder `gemma2`).
4.  **Prompt ausführen:** Gib deine Frage ein und drücke den **Play-Button (▶)**.

*Tipp: Stelle sicher, dass die Adresse oben links korrekt ist (Standard: `127.0.0.1:11434`).*

---

## 🔄 Betriebsmodi & Vision-Unterstützung

Über das **API**-Dropdown-Menü kannst du steuern, wie die App mit dem Modell kommuniziert.

### 1. Generate-Modus (Einzelanfrage)
Dieser Modus ist für Einzelaufgaben (One-Shot-Tasks) konzipiert.
* **Vision / Bilder:** Dies ist der *einzige* Modus, in dem du Bilder hochladen kannst (über die Schaltflächen `+ File` oder `+ Screenshot`). Nutze dafür Vision-fähige Modelle wie *llava* oder *moondream*.
* **Verhalten:** Jede Anfrage steht für sich allein; das Modell "vergisst" vorherige Fragen sofort.
* **Kontext:** Du kannst jedoch Kontext-Token in die nächste Anfrage einbeziehen, um auch im Generate-Modus eine Konversation aufrechtzuerhalten.

### 2. Chat-Modus (Konversation)
Der gesamte Konversationsverlauf wird gespeichert und mit jeder neuen Nachricht gesendet.
* **Modellwechsel:** Du kannst das **LLM mitten in einer Konversation wechseln** (z. B. von einem schnellen 7B-Modell zu einem intelligenten 70B-Modell), ohne den roten Faden zu verlieren.

### 🔀 Die Brücke: „Generate > Chat“
Da der Chat-Modus keine Bilder direkt empfangen kann, bietet die App diesen Workflow an:
1. Wähle **Generate** und lade ein Bild hoch (z. B. „Beschreibe dieses Bild“).
2. Warte auf die Antwort.
3. Klicke auf die Schaltfläche **Generate > Chat**.
*Die Analyse wird in den Chat-Verlauf kopiert, sodass du im Chat-Modus Folgefragen dazu stellen kannst.*

---

## 🤖 SSH Bot (Autonomer KI-Agent) — 🌟 Alleinstellungsmerkmal

Der integrierte SSH Bot verwandelt Ollama Desktop in einen **vollautomatisierten Linux-Systemadministrator**. Im Gegensatz zu anderen Clients, die nur Code generieren, kann sich diese App direkt mit deinem Server verbinden, Probleme analysieren und autonom beheben!

* **Autonome Ausführung:** Gib ein Ziel vor (z. B. "Analysiere den Webserver und behebe den Fehler"). Die KI verbindet sich via SSH, führt Befehle aus, liest die Terminal-Antwort (inkl. intelligenter RegEx-Erkennung für den Prompt) und plant selbstständig den nächsten logischen Schritt.
* **Sudo-Support:** Die App fängt Passwort-Abfragen (`sudo`) nahtlos ab und übermittelt das hinterlegte Passwort automatisch, ohne den Agentenfluss zu unterbrechen.
* **Sicherheits-Leitplanken:** Du behältst die volle Kontrolle. Begrenze die maximalen Agenten-Schritte (Endlosschleifen-Schutz) und wähle, ob der Bot **vollautonom (Auto-Execute)** agieren darf oder jeden Befehl erst zur manuellen Freigabe vorschlagen soll.
* **Individuelle Rollen:** Passe den Response- und System-Prompt an, um dem Bot spezifische Profile (z. B. Security-Auditor, Netzwerk-Admin) zuzuweisen.

---

## 🛠 Modell-Parameter

### 1. System-Prompt
Definiere die „Persönlichkeit“ der KI (z. B. „Du bist ein erfahrener C#-Entwickler“). Aktiviere das Kontrollkästchen **Use System Prompt**, um diese Anweisung vor jedem Chat zu senden.

### 2. Ausgabeformat (JSON-Modus)
Zwinge das Modell dazu, exakt in einem definierten **JSON-Schema**-Format zu antworten. Dies ist ideal für Entwickler, die strukturierte Daten benötigen.

### 3. Content-Prompt
Dieser Prompt erweitert die Eingabe um angehängte textbasierte Dateien wie **.txt**, **.json** oder **.pdf**.

### 4. Options-Parameter
| Parameter | Beschreibung |
| :--- | :--- |
| `temperature` | **Kreativität.** `0.0` ist deterministisch; `0.7-0.8` ist natürlich (Standard); `1.2+` ist experimentell. |
| `top_p` | **Nucleus Sampling.** Berücksichtigt Wörter, die eine kumulative Wahrscheinlichkeit `P` erreichen. |
| `num_ctx` | **Kontextfenster.** Legt fest, wie viele Token das Modell gleichzeitig verarbeiten kann. `2048` ist Standard; `4096-8192` für Dokumente. |
| `repeat_penalty` | Verhindert, dass das Modell Wörter wiederholt (empfohlen: `1.1-1.2`). |
| `seed` | Ein fester Wert (z. B. `42`) stellt sicher, dass derselbe Prompt mit denselben Parametern immer die gleiche Antwort liefert. |

*Du kannst manuell benutzerdefinierte Parameter hinzufügen, indem du auf die leere Zeile (markiert mit `*`) in der Tabelle klickst.*

---

## 🛠 Tools & Funktionsaufrufe (Function Calling)
Der Reiter **Tools** macht das LLM zu einem Agenten, der Aufgaben wie Wetterabfragen oder Berechnungen automatisch ausführen kann.
* **Tool JSON:** Definiere hier deine API-Schnittstelle, damit das Modell weiß, welche Parameter extrahiert werden müssen.
* **Python-Code:** Hinterlege die Logik, die lokal ausgeführt werden soll. Die App führt diesen Code automatisch aus, wenn das Modell das Tool anfordert.

---

## 📄 RAG-Tool (Chat mit Dokumenten)
Lade **.txt**- oder **.pdf**-Dateien hoch, um sie als Wissensdatenbank zu nutzen.
* **Workflow:** Die App zerlegt die Datei in Sätze, extrahiert Schlüsselwörter/Synonyme aus deiner Anfrage und stellt dem LLM passende Textsegmente als Hintergrundwissen zur Verfügung.
* **Delta-Parameter:** Steuert, wie viel Kontext (0-9 Sätze) um einen Treffer herum an das Modell gesendet wird.

---

## 💻 Code-Generierung & Ausführung
Führe Code in Python, PowerShell, Batch oder HTML/JavaScript direkt in der App aus.
* **Execute List:** Definiere deine Interpreter-Pfade (z. B. `python.exe`) im Reiter **Code Parameter**.
* **ShellExecute:** Wähle zwischen der Code-Ausführung im Hintergrund (Ausgabe wird erfasst) oder in einem externen Fenster.

---

## ⚖️ Lizenzen & Drittanbieter-Komponenten
* **Ollama_Desktop, Newtonsoft.Json, Scintilla5.NET, SSH.NET:** MIT-Lizenz.
* **WebView2:** Microsoft Corporation.
* **Markdig:** BSD-Clause 2.
* **PdfPig:** Apache-Lizenz 2.0.
* **Siticone.NetCore.UI:** Proprietäre Lizenz.

---

## ☕ Unterstützung
Ollama Desktop ist kostenlos und quelloffen. Wenn du die Entwicklung unterstützen möchtest, kannst du via PayPal spenden:

**[Über PayPal spenden](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=r.barnstorf@online.de&currency_code=EUR&source=url)**

Empfänger: `r.barnstorf@online.de`
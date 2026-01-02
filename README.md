# Ollama Desktop

**Ollama Desktop** ist eine grafische Benutzeroberfläche (GUI) für **Ollama**. Die Anwendung ermöglicht die komfortable Steuerung lokal installierter KI-Modelle, die Feinabstimmung von Parametern und die Erzwingung strukturierter JSON-Antworten.

---

## 🚀 Schnellstart

1. **Ollama-Server starten:** Starten Sie den Server im Hintergrund (Terminal: `ollama serve`).
2. **LLM-Liste laden:** Klicken Sie oben links auf **Get LLM List**.
3. **Modell wählen:** Wählen Sie ein Modell aus dem Dropdown-Menü (z. B. `llama3` oder `gemma2`).
4. **Anfrage stellen:** Geben Sie Ihre Frage ein und drücken Sie den **Play-Button (▶)**.

*Hinweis: Stellen Sie sicher, dass die Adresse korrekt ist (Standard: `127.0.0.1:11434`).*

---

## ✨ Hauptfunktionen

### Betriebsmodi
* **Generate Modus:** Optimiert für Einzelanfragen ("One-Shot"). Dies ist der einzige Modus mit **Vision-Support** für Bilder (z. B. via *llava* oder *moondream*).
* **Chat Modus:** Speichert den gesamten Gesprächsverlauf. Erlaubt den **Modell-Wechsel** mitten in einer Unterhaltung.
* **Brückenfunktion:** Über den Button **Generate > Chat** können Bild-Analysen nahtlos in den Chat-Kontext übernommen werden.

### RAG Tool (Chat mit Dokumenten)
Laden Sie eigene **.txt** oder **.pdf** Dateien hoch, um Fragen zu spezifischen Inhalten zu stellen.
* **Intelligente Suche:** Das System analysiert Anfragen und erstellt Listen von Suchwörtern und Synonymen.
* **Delta-Parameter:** Steuern Sie den Kontextbereich um gefundene Textstellen (0-9 Sätze).

### Tools & Function Calling
Verwandeln Sie das LLM in einen Agenten:
* **Automatisierung:** Definieren Sie Tool-Schnittstellen via JSON und hinterlegen Sie **Python-Code**, der bei Bedarf automatisch lokal ausgeführt wird.
* **Integration:** Rückgabewerte des Codes werden direkt in den Antwortprozess des Modells integriert.

### Code Generierung & Ausführung
* **Interpreter-Support:** Führen Sie generierten Code in Sprachen wie Python, PowerShell, Batch oder HTML/JavaScript direkt aus.
* **Konfiguration:** Hinterlegen Sie eigene Pfade zu Interpretern in der **Execute List**.

---

## 🛠 Parameter-Steuerung

Passen Sie das Modellverhalten über detaillierte Optionen an:

| Parameter | Beschreibung |
| :--- | :--- |
| `temperature` | Steuert Kreativität (0.0 = deterministisch, 0.7+ = natürlich). |
| `num_ctx` | Legt die Größe des Kontext-Fensters fest (z. B. 4096 für Dokumente). |
| `repeat_penalty` | Bestraft Wortwiederholungen. |
| `JSON Mode` | Erzwingt die Antwort in einem definierten JSON-Schema. |
| `System Prompt` | Definiert die "Persönlichkeit" der KI. |

*Die Parameterliste kann manuell um eigene Einträge erweitert werden.*

---

## ⚖️ Lizenzen & Komponenten

Dieses Projekt verwendet folgende Open-Source-Komponenten:

* **Ollama_Desktop (7soft):** MIT-Lizenz
* **Newtonsoft.Json:** MIT-Lizenz
* **Scintilla5.NET:** MIT-Lizenz
* **WebView2:** Microsoft Corporation
* **Markdig:** BSD-Clause 2
* **PdfPig:** Apache License 2.0
* **Siticone.NetCore.UI:** Proprietäre Lizenz

---

## ☕ Unterstützung

Die App ist komplett kostenlos und Open Source. Wenn Ihnen das Projekt gefällt, können Sie die Arbeit via PayPal unterstützen:

**[Jetzt via PayPal spenden](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=r.barnstorf@online.de&currency_code=EUR&source=url)**

Empfänger: `r.barnstorf@online.de`

# Ollama Desktop

> **Languages:** [English] | [**Deutsch**](README.de.md)

---

**Ollama Desktop** is a graphical user interface (GUI) for **Ollama**. It allows you to comfortably control locally installed AI models, fine-tune parameters, and enforce structured JSON responses.

---

## 🚀 Quick Start

1.  **Start Ollama Server:** Run the Ollama server in the background (Terminal: `ollama serve`).
2.  **Load LLM List:** Click **Get LLM List** in the top left corner of the app to load your installed models.
3.  **Select a Model:** Choose a model from the dropdown menu (e.g., `llama3` or `gemma2`).
4.  **Run a Prompt:** Enter your question and press the **Play button (▶)**.

*Tip: Ensure that the address in the top left is correct (Default: `127.0.0.1:11434`).*

---

## 🔄 Operating Modes & Vision Support

You can control how the app communicates with the model via the **API** dropdown menu.

### 1. Generate Mode (Single Request)
This mode is designed for one-shot tasks.
* **Vision / Images:** This is the *only* mode where you can upload images (using the `+ File` or `+ Screenshot` buttons). Use vision-capable models like *llava* or *moondream*.
* **Behavior:** Each request stands alone; the model "forgets" previous questions immediately.
* **Context:** However, you can include context tokens in the next request to maintain a conversation even in Generate mode.

### 2. Chat Mode (Conversation)
The entire conversation history is saved and sent with every new message.
* **Model Switching:** You can **switch the LLM** in the middle of a conversation (e.g., from a fast 7B model to a smart 70B model) without losing the thread.

### 🔀 The Bridge: "Generate > Chat"
Since Chat mode cannot receive images directly, the app offers this workflow:
1.  Select **Generate** and upload an image (e.g., "Describe this image").
2.  Wait for the response.
3.  Click the **Generate > Chat** button.
*The analysis will be copied to the chat history, allowing you to ask follow-up questions in Chat mode.*

---

## 🛠 Model Parameters

### 1. System Prompt
Define the "personality" of the AI (e.g., "You are an experienced C# developer"). Enable the **Use System Prompt** checkbox to send this instruction before every chat.

### 2. Output Format (JSON Mode)
Force the model to respond exactly in a defined **JSON Schema** format, which is ideal for developers needing structured data.

### 3. Content Prompt
This prompt extends the input prompt with attached text-based files like **.txt**, **.json**, or **.pdf**.

### 4. Options Parameters
| Parameter | Description |
| :--- | :--- |
| `temperature` | **Creativity.** `0.0` is deterministic; `0.7-0.8` is natural (default); `1.2+` is experimental. |
| `top_p` | **Nucleus Sampling.** Considers words that reach a cumulative probability `P`. |
| `num_ctx` | **Context Window.** Sets tokens the model can process at once. `2048` is standard; `4096-8192` for documents. |
| `repeat_penalty` | Prevents the model from repeating words (recommended: `1.1-1.2`). |
| `seed` | A fixed value (e.g., `42`) ensures the same prompt and parameters always yield the same answer. |

*You can manually add custom parameters by clicking the empty row (marked with `*`) in the table.*

---

## 🛠 Tools & Function Calling
The **Tools** tab turns the LLM into an agent that can perform tasks like checking weather or running calculations automatically.
* **Tool JSON:** Define your API interface here so the model knows which parameters to extract.
* **Python Code:** Provide the logic to be executed locally. The app runs this code automatically when the model requests the tool.

---

## 📄 RAG Tool (Chat with Documents)
Upload **.txt** or **.pdf** files to use them as a knowledge base.
* **Workflow:** The app splits the file into sentences, extracts keywords/synonyms from your query, and provides matching text segments to the LLM as background knowledge.
* **Delta Parameter:** Controls how much context (0-9 sentences) around a hit is sent to the model.

---

## 💻 Code Generation & Execution
Execute code in Python, PowerShell, Batch, or HTML/JavaScript directly within the app.
* **Execute List:** Define your interpreter paths (e.g., `python.exe`) in the **Code Parameter** tab.
* **ShellExecute:** Choose between running code in the background (output captured) or in an external window.

---

## ⚖️ Licenses & Third-Party Components
* **Ollama_Desktop, Newtonsoft.Json, Scintilla5.NET:** MIT License.
* **WebView2:** Microsoft Corporation.
* **Markdig:** BSD-Clause 2.
* **PdfPig:** Apache License 2.0.
* **Siticone.NetCore.UI:** Proprietary License.

---

## ☕ Support
Ollama Desktop is free and open source. If you'd like to support the development, you can donate via PayPal:

**[Donate via PayPal](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=r.barnstorf@online.de&currency_code=EUR&source=url)**

Empfänger: `r.barnstorf@online.de`

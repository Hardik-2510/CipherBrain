# 🔐 GCD-Based Text Encryption & Decryption (VB.NET)

This is a simple **Windows Forms (VB.NET)** application that demonstrates a **custom encryption–decryption technique** using **Unicode values and the GCD (Greatest Common Divisor)** concept.  
The project is intended for **educational purposes** to understand basic cryptographic logic.

---

## ✨ Features
- Text encryption using a key
- GCD-based reversible logic
- Simple Encode / Decode interface
- Unicode character handling
- Clear / Reset functionality

---

## 🧠 How It Works (Logic)
- Each character of the input text is converted to its Unicode value.
- A corresponding key character is also converted to Unicode.
- The **GCD of both values** is calculated.
- Encryption:  
EncryptedChar = InputChar + GCD(InputChar, KeyChar)

- Decryption reverses the process using the same GCD.

---

## 📝 Usage Rules
- Input text and key **must be the same length**
- **Only alphabets are supported**
- Encryption must be done **before decryption**
- Use the **same key** for decoding
- Do not reset or close the app before decoding
- Reset clears all stored data

---

## 🚀 How to Use
1. Enter plain text and key (same length)
2. Click **Encode** to encrypt
3. Enter encrypted text and same key
4. Click **Decode** to get original text
5. Use **Clear/Reset** to start over

---

## ⚠️ Limitations
- Not suitable for real-world security
- Decryption works only within the same session
- Custom algorithm (not industry-standard encryption)

---

## 🛠️ Technology Used
- VB.NET
- Windows Forms
- Unicode character encoding

---

## 📚 Purpose
This project is designed for:
- Academic demonstration
- Understanding encryption concepts
- Learning number theory (GCD) in programming

---

## 📄 License
This project is for **educational use only**.


# 🔐 CipherNotes — Secure Offline Notes Vault

An offline-first secure notes mobile application built with .NET MAUI that allows users to store sensitive notes locally using strong encryption. The app ensures full privacy by encrypting all data on-device using AES encryption with password-based key derivation (PBKDF2). No backend, no cloud, no data leakage.

---

## 📱 Features

- 📝 Create secure encrypted notes  
- 🔓 Decrypt notes using password  
- 📂 View list of saved notes (titles only)  
- 🗑️ Delete notes locally  
- 🔐 AES encryption for all stored content  
- 🔑 Password-based key derivation (PBKDF2)  
- 💾 Local storage using SQLite  
- 🚫 Fully offline (no network calls)  

---

## 🏗️ Architecture

```text
UI Layer (MAUI Views)
        ↓
ViewModels (State & Logic)
        ↓
Service Layer
   ├── EncryptionService
   ├── NoteService
   └── DatabaseService
        ↓
SQLite (Local Storage)

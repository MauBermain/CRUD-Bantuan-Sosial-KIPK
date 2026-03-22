# CRUD PENERIMA KIPK UNIVERSITAS HASYIM ASYARI 2024
## Ahmad BAdrul Furqon

## 🧾 Deskripsi
Project ini merupakan aplikasi berbasis VB.NET yang digunakan untuk mengelola data KIPK (Kartu Indonesia Pintar Kuliah).
Aplikasi ini terhubung dengan database MySQL menggunakan file kipk.sql.

## 🚀 Fitur Utama
CRUD Data Mahasiswa KIPK,
Login User (Admin),
Pencarian Data,
Laporan,
Koneksi ke Database MySQL,
Tampilan Windows Form (VB.NET)

## 🛠️Teknologi yang Digunakan
VB.NET (Visual Basic .NET),
MySQL Database,
Windows Forms

## 📂 Struktur Folder
```bash
CRUD-Bantuan-Sosial-KIPK/
│
├── Database/
│   └── kipk.sql
│
├── Forms/
│   ├── FormLogin.vb
│   ├── FormMenu.vb
│   ├── FormMahasiswa.vb
│
├── Modules/
│   ├── Koneksi.vb
│   └── ModuleCRUD.vb
│
├── App.config
├── CRUD-KIPK.sln
└── README.md
```

## 📂NuGet Package yang digunakan
1. ClosedXML
2. DocX
3. iTextSharp
4. microsoft.office.interop.word
5. mysql.data
6. system.data.odbc

## ⚙️ Cara Menjalankan Project
1. Clone Repository
```git clone https://github.com/MauBermain/CRUD-Bantuan-Sosial-KIPK.git```
2. Import Database
Buka phpMyAdmin atau MySQL
Buat database baru, contoh:
CREATE DATABASE kipk;
Import file:
kipk.sql
3. Konfigurasi Koneksi
Edit file App.config atau module koneksi:
Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=kipk")
4. Jalankan Project
Buka file .sln di Visual Studio
Klik Start / Run

## 📄 Lisensi
Project ini menggunakan lisensi bebas (MIT / bebas digunakan untuk pembelajaran)

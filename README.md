# 🏥 Hastane Bilgi Yönetim Sistemi

Bu proje, **Windows Forms (C#)** kullanılarak geliştirilmiş bir masaüstü **Hastane Bilgi Yönetim Sistemi** uygulamasıdır.  
Amaç; bir hastane ortamında **hasta, doktor ve randevu** işlemlerinin basit ve kullanıcı dostu bir arayüz üzerinden yönetilmesini sağlamaktır.  
Veri işlemleri **ADO.NET** aracılığıyla **SQL Server** üzerinde gerçekleştirilmiştir.

---

## 🧩 Özellikler

- 👨‍⚕️ **Doktor Yönetimi:** Doktor bilgilerini ekleme, silme, güncelleme ve listeleme  
- 🧍‍♀️ **Hasta Yönetimi:** Hasta kayıt işlemleri, bilgileri düzenleme ve görüntüleme  
- 📅 **Randevu Yönetimi:** Hasta ve doktor eşleşmeleriyle randevu oluşturma  
- 🔐 **Kullanıcı Girişi (opsiyonel):** Yönetici veya personel bazlı giriş sistemi  
- 💾 **Veritabanı İşlemleri:** ADO.NET ile SQL sorguları kullanılarak CRUD (Create, Read, Update, Delete) işlemleri  
- 📊 **Kullanıcı Arayüzü:** DataGridView bileşenleri ile tablo tabanlı veri görüntüleme  

---

## 🏗️ Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|------------|-----------|
| **C#** | Ana programlama dili |
| **.NET Framework / Windows Forms** | Masaüstü uygulama geliştirme platformu |
| **ADO.NET** | Veritabanı bağlantısı ve veri yönetimi |
| **SQL Server** | Verilerin saklandığı ilişkisel veritabanı |
| **Visual Studio** | Geliştirme ortamı |

---

## 📂 Proje Yapısı

HastaneBilgiYonetim/
│
├── FrmGirisler.cs → Ana form 
├── FrmDoktorDetay.cs → Doktor işlemleri
├── FrmHastaDetay.cs → Hasta işlemleri
├── FrmSekreterDetay.cs → Randevu işlemleri
├── App.config → Veritabanı bağlantı ayarları
├── HastaneBilgiYonetim.sln
└── README.md

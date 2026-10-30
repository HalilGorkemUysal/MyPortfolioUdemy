<div align="center">

# 💼 MyPortfolioUdemy

### ASP.NET Core MVC ile Kişisel Portfolyo ve Yönetim Paneli

.NET 6, Entity Framework Core ve SQL Server kullanılarak geliştirilen; kişisel portfolyo sayfasını, içerik yönetimi ekranlarını ve yönetim panelini bir araya getiren web uygulaması.

![.NET](https://img.shields.io/badge/.NET-6.0-512BD4?logo=dotnet&logoColor=white)
![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET_Core-MVC-512BD4)
![EF Core](https://img.shields.io/badge/Entity_Framework_Core-6.0-512BD4)
![SQL Server](https://img.shields.io/badge/SQL_Server-Database-CC2927?logo=microsoftsqlserver&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Programming-239120?logo=csharp&logoColor=white)

[Proje Kodları](https://github.com/gorkewmm/MyPortfolioUdemy) · [Geliştirici Profili](https://github.com/gorkewmm)

</div>

---

## 📌 Proje Hakkında

**MyPortfolioUdemy**, ASP.NET Core MVC mimarisini ve Entity Framework Core ile veritabanı işlemlerini uygulamalı olarak geliştirmek amacıyla hazırlanmış bir kişisel portfolyo projesidir.

Projenin ziyaretçilere yönelik tarafında kişisel tanıtım, portfolyo, referanslar ve iletişim gibi bölümler bir arada sunulur. Yönetim tarafında ise deneyimlerin ve yapılacak işlerin düzenlenmesi, mesajların incelenmesi ve temel veritabanı istatistiklerinin görüntülenmesi için ekranlar bulunur.

> **Geliştirme durumu:** Proje geliştirme aşamasındadır. Yönetim panelindeki bazı menüler henüz örnek şablon bağlantılarına yönlenmektedir. İletişim formunun veritabanına kayıt yapan bir gönderim işlemi mevcut kodda bulunmamaktadır.

## ✨ Özellikler

### 🌐 Ziyaretçi arayüzü

- Kişisel tanıtım ve hakkımda bölümü
- Portfolyo çalışmalarını sergilemek için ayrılmış bölüm
- Referanslar ve istatistikler için sayfa bileşenleri
- İletişim bilgileri ve iletişim formu arayüzü
- Tek bir sayfada birleştirilen modüler **ViewComponent** yapısı

### 🛠️ Yönetim paneli

- **Deneyim yönetimi:** Deneyim listeleme, ekleme, güncelleme ve silme (CRUD)
- **Yapılacaklar listesi:** Görev ekleme, düzenleme, silme ve tamamlandı/tamamlanmadı olarak işaretleme
- **Gelen kutusu:** Kayıtlı mesajları listeleme, detayını görüntüleme, okundu/okunmadı durumunu değiştirme ve silme
- **İstatistikler:** Yetenek sayısı, toplam mesaj sayısı, okunan ve okunmayan mesaj sayıları
- Ortak navbar, sidebar ve script bileşenleriyle oluşturulmuş yönetim paneli düzeni

## 🧰 Kullanılan Teknolojiler

| Teknoloji | Kullanım amacı |
| --- | --- |
| C# | Sunucu tarafı uygulama geliştirme |
| .NET 6 / ASP.NET Core MVC | MVC tabanlı web uygulaması |
| Entity Framework Core 6.0.28 | Veritabanı erişimi ve nesne-ilişkisel eşleme (ORM) |
| Microsoft.EntityFrameworkCore.SqlServer | SQL Server veritabanı sağlayıcısı |
| EF Core Migrations | Veritabanı şemasının sürümlenmesi |
| SQL Server | İlişkisel veri saklama |
| Razor Views ve ViewComponents | Arayüzün modüler şekilde oluşturulması |
| HTML, CSS ve JavaScript | Kullanıcı arayüzü |
| Bootstrap tabanlı yönetim paneli şablonu | Yönetim arayüzünün görsel yapısı |

## 🏗️ Proje Yapısı

```text
MyPortfolioUdemy/
├── MyPortfolioUdemy.slnx
├── MyPortfolioUdemy/
│   ├── Controllers/
│   │   ├── DefaultController.cs
│   │   ├── ExperienceController.cs
│   │   ├── MessageController.cs
│   │   ├── StatisticController.cs
│   │   └── ToDoListController.cs
│   ├── DAL/
│   │   ├── Context/
│   │   │   └── MyPortfolioContext.cs
│   │   └── Entities/
│   ├── Migrations/
│   ├── Models/
│   ├── ViewComponents/
│   ├── Views/
│   ├── wwwroot/
│   ├── Program.cs
│   └── MyPortfolioUdemy.csproj
└── README.md
```

**Katmanların görevleri:**

- `Controllers/`: HTTP isteklerini karşılayan ve ilgili işlemleri yöneten MVC controller sınıfları.
- `DAL/Entities/`: Veritabanı tablolarını temsil eden entity modelleri.
- `DAL/Context/`: EF Core `DbContext` sınıfı ve SQL Server bağlantısı.
- `Migrations/`: Veritabanı şemasının oluşturulması ve güncellenmesi için migration dosyaları.
- `ViewComponents/`: Portfolyo ve yönetim panelinin tekrar kullanılabilir bölümleri.
- `Views/`: Razor ile hazırlanmış sayfa ve bileşen görünümleri.
- `wwwroot/`: CSS, JavaScript, görsel ve diğer statik dosyalar.

## 🗃️ Veritabanı Modelleri

`MyPortfolioContext` içerisinde aşağıdaki veri kümeleri tanımlıdır:

| Entity | İçerik |
| --- | --- |
| `About` | Hakkımda bilgileri |
| `Contact` | İletişim bilgileri |
| `Experience` | İş / eğitim deneyimleri |
| `Feature` | Öne çıkan tanıtım alanı |
| `Message` | Mesaj kayıtları |
| `Portfolio` | Portfolyo çalışmaları |
| `Skill` | Yetenekler |
| `SocialMedia` | Sosyal medya bağlantıları |
| `Testimonial` | Referanslar / yorumlar |
| `ToDoList` | Yapılacak görevler |

## 🚀 Kurulum ve Çalıştırma

### Gereksinimler

- **.NET 6 SDK** (projenin hedeflediği sürüm; .NET 6'nın destek süresi sona ermiştir)
- **SQL Server** veya SQL Server Express
- İsteğe bağlı: **Visual Studio** veya **Visual Studio Code**
- EF Core migration komutlarını kullanmak için `dotnet-ef` aracı

### 1. Projeyi klonlayın

```bash
git clone https://github.com/gorkewmm/MyPortfolioUdemy.git
cd MyPortfolioUdemy
```

### 2. Veritabanı bağlantısını kendi ortamınıza uyarlayın

Mevcut projede SQL Server bağlantısı `MyPortfolioUdemy/DAL/Context/MyPortfolioContext.cs` içindeki `OnConfiguring` metodunda, geliştirici bilgisayarına özel bir sunucu adıyla tanımlanmıştır.

Yerel SQL Server örneğinize göre bu satırı güncelleyin. Örnek:

```csharp
optionsBuilder.UseSqlServer(
    "Server=localhost;Database=MyPortfolioDb;Trusted_Connection=True;TrustServerCertificate=True;");
```

> Üretim ortamlarında bağlantı bilgisini kaynak koda sabitlemek yerine yapılandırma dosyası, ortam değişkeni veya Secret Manager üzerinden yönetmeniz önerilir. Yukarıdaki bağlantı dizesi Windows kimlik doğrulaması kullanan yerel bir geliştirme ortamı için örnektir.

### 3. NuGet paketlerini geri yükleyin

```bash
dotnet restore MyPortfolioUdemy/MyPortfolioUdemy.csproj
```

### 4. Veritabanını oluşturun / güncelleyin

Gerekirse EF Core CLI aracını kurun:

```bash
dotnet tool install --global dotnet-ef --version 6.0.28
```

Projede mevcut migration dosyalarını uygulayın:

```bash
dotnet ef database update --project MyPortfolioUdemy/MyPortfolioUdemy.csproj
```

### 5. Uygulamayı başlatın

```bash
dotnet run --project MyPortfolioUdemy/MyPortfolioUdemy.csproj
```

Terminalde görüntülenen `http://localhost:...` veya `https://localhost:...` adresini tarayıcıda açın.

### Önemli sayfalar

| Sayfa | Rota |
| --- | --- |
| Portfolyo ana sayfası | `/Default/Index` |
| Deneyimler | `/Experience/ExperienceList` |
| Yapılacaklar | `/ToDoList/Index` |
| Gelen kutusu | `/Message/Inbox` |
| İstatistikler | `/Statistic/Index` |

## 🧭 Geliştirme Yol Haritası

- [x] MVC proje yapısı ve Entity Framework Core bağlantısı
- [x] Veritabanı entity modelleri ve migration dosyaları
- [x] Deneyimler için CRUD işlemleri
- [x] Yapılacaklar listesi ve durum güncelleme
- [x] Mesajların yönetim panelinde listelenmesi ve durumlarının değiştirilmesi
- [x] Temel veritabanı istatistikleri
- [ ] İletişim formunun sunucu tarafına bağlanması ve mesaj kaydı
- [ ] Yönetim panelindeki örnek menü bağlantılarının gerçek sayfalara dönüştürülmesi
- [ ] Kimlik doğrulama ve yetkilendirme ile yönetim alanının korunması
- [ ] Veritabanı bağlantısının güvenli yapılandırmaya taşınması
- [ ] Girdi doğrulaması, hata yönetimi ve güvenli silme işlemlerinin geliştirilmesi
- [ ] Örnek içeriklerin temizlenmesi ve arayüzün tamamlanması

## 👨‍💻 Geliştirici

**Halil Görkem**

GitHub: [@gorkewmm](https://github.com/gorkewmm)

---

<div align="center">
  <sub>ASP.NET Core MVC ve Entity Framework Core ile geliştirilmiş kişisel portfolyo projesi.</sub>
</div>

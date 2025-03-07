# NOTLAR

## Mimariler
* .Net Framework, sadece Windows desteklidir, masaüstü uygulamalarına uygun.
* .Net Core, çoklu işletim sistemi destekli, web uygulamalarına da uygun.
* ASP.Net ikisiyle de çalışır fakat farklı işletim sistemlerinde çalışması için .Net Core (günümüzde .Net olarak geçiyor)  üzerinden çalışacağız.
* Web geliştirmede ***C# + ASP.NET CORE + SQL SERVER*** üçlüsü ile çalışılması uygundur.
  
![Ekran görüntüsü 2025-01-29 172935](https://github.com/user-attachments/assets/026db42b-8027-4dc7-9a43-b13fe80822d6)


## Web Temel Kavramlar
user ->> client ->> request(ip || domain) --> hosting --> response --> client --> user

![Ekran görüntüsü 2025-01-29 175911](https://github.com/user-attachments/assets/62a7955e-20e6-4d0a-b0a8-3289bf6c91e1)


## HTTP Fonksiyonları
* Get: filtreleme, listeleme gösterme vs.
* Post: giriş yapma, ekleme yapma vs.
* Put: güncelleme yapma
* Patch: local güncelleme yapma (ufak değişikliklerde tercih edilir)
* Delete: silme işlemleri

![Ekran görüntüsü 2025-01-29 180846](https://github.com/user-attachments/assets/8d612a6e-5fab-4de1-af0d-d486b2c486e2)

## Frontend Fonksiyonları
* Uygulamanın önyüzü, grafiksel arayüzüdür.
* Backendde üretilen veri frontendde yollanır ve uygun şekilde kullanıcıya sunulur.
* Kullandığı Teknolojiler; ***Angular, React, Javascript, HTML, CSS, Vue.js, Bootstrap***

## Backend Fonksiyonları
* Verileri işler.
* Algoritmasal kodların yazıldığı alandır.
* Veritabanı işlemleri bu alanda gerçekleştirilir.
* Kullandığı Teknolojiler; ***Node.js, PHP, Java, Python, C#(.NET - ASP.NET CORE), C, C++, Ruby vb.***

## MVC Yaklaşımı
* Tasarım desenidir
* ASP.NET bu tasarım üzerine üzerine oturtturulmuş bir mimaridir.

## API 
* Web üzerinde çalışan backend.
* ***Herhangi bir client i (mikrafon, tablet, telefon, tv, matkap vb.) API ye bağlayıp internetten yönetilebilir yada farklı nesnelerle iletişim kurabilir hale getirebilirsiniz.***
* API farklı alanlarda kullanılır, web de kullanıyorsak ***Web API*** ismini veriyoruz.
* Web'de çalışabilen ve web uygulamaları, işletim sistemleri, veritabanları, donanımlar yahut yazılım kütüphaneleri ile iletişim kurabilen bir ***arayüzdür***
* Bir web uygulaması backend de API ile verilerini üretebilir.
* Genellikle web tabanlı uygulamalarda ***client*** ve ***server*** arasında iletişimi sağlayan bir sözleşme olarak kullanılmaktadır.

![Ekran görüntüsü 2025-01-31 225654](https://github.com/user-attachments/assets/b3e2e699-47fe-43ee-bbf1-acc9a3de383c)

## Asp.NET Core MVC Pipeline
Controller beyin gibidir. Veri ve tasarım istenmediğinde Console uygulaması olarak düşünebiliriz. Veri ve tasarım girdiğinde ise model ve view katmanını kullanır.

* ***Model: İşlenecek verilerin katmanıdır. Veritabanı işlemleri bu katmanda yapılır.***
* ***View: İstek neticesinde verilerin görselleştiri, düzenlenmesidir. Html, Css, js, Razor(cshtml yani cs+html), resim, müzik, video gibi.***
* ***Controller: Client ile gelen isteğe cevap verir. Veri işlemi gerekiyorsa Model'e istek atar, Model istenileni geri yollar. Aynı şekilde tasarım/çıktı düzenlemesi gerekiyorsa bu veri View e atılır, View düzenleme sonrası tekrar Controller a yollar. En son client request ine response atılır.***

![Ekran görüntüsü 2025-02-03 140619](https://github.com/user-attachments/assets/002e264f-ae78-4d28-98e0-4e4505277bfd)

## View'e İle Data'dan İlk Veri Gönderimi

* Model Bazlı Veri Gönderimi (dynamic)
* ViewBag (unboxing)
* ViewData (unboxing)
* TempData (unboxing)


![Ekran görüntüsü 2025-02-07 003149](https://github.com/user-attachments/assets/7060f881-4311-4717-86bf-54ca2b2b2f33)

## Kullanıcıdan Gelen Verilerin Doğrulanması Validations

![Ekran görüntüsü 2025-02-18 225505](https://github.com/user-attachments/assets/b67ee17f-96da-4973-a29b-12a6eb8dce84)

## Modüler Tasarım

Her bölüm için ayrı ayrı cshtml oluşturulur. Sayfa cshtml dosyasında kullanılacaklar çağrılarak (referans ederek) bir sayfa oluşturulur. Sayfa değişikliklerinde, yer değiştirmelerde referanslar değiştirilerek çok daha dinamik bir yapı elde ederiz.
- PartialView ve ViewComponent şeklinde 2 yolla yapılabilir.

![Ekran görüntüsü 2025-03-02 030003](https://github.com/user-attachments/assets/ee3ac008-0498-48dc-80a5-f1b21d164e15)

***PartialView ve ViewComponent Farkı***

![Ekran görüntüsü 2025-03-04 013727](https://github.com/user-attachments/assets/1b213672-02cf-4c67-bbdc-5870eeb94874)

## Middleware

![Ekran görüntüsü 2025-03-07 021903](https://github.com/user-attachments/assets/1a085451-6feb-4ca0-a2ec-ee598dbb678b)


* Request ile Response arasında çalışır.
* Configure metodu içerisinde middleware ler çağırılır. ASP Net Core mimarisinde tüm middleware ler "use" adı ile başlar.
* Middleware lerde tetiklenme sırası önemlidir.

  #### Hazır Middleware'ler
  * Run : Kendisinden sonra gelen middleware i tetiklemez. Akış kesmek için kullanılabilir (bu etkiye kısa devre denir)

    ![Ekran görüntüsü 2025-03-07 031821](https://github.com/user-attachments/assets/ce80a500-32ca-4eb4-9bd3-462bec0e8560)
    
```
// RUN MİDDLEWAR'İ
app.Run(async context =>
{
    Console.WriteLine("run MİDDLEWAR tetiklendi");
});
// RUN MİDDLEWARE SONRASIN ÇALIŞMIYOR.
```

  * Use : Run metoduna nazaran, devreye girdikten sonra süreçte sıradaki middleware i çağırmakta ve normal middleware işlevi bittikten sonra geriye dönüp devam edebilen bir yapıya sahiptir.

```
//USE MİDDLEWAR'İ 
app.Use(async (context, next) =>
{
    Console.WriteLine("use MİDDLEWAR  tetiklendi");
    next.Invoke();
    Console.WriteLine("STOP use MİDDLEWAR");
});
// SONRAKİ MİDDLEWAR'İ TETİKLİYOR (NEXT İNVOKE SAYESİNDE)
```

  * Map : Bazen middleware'i talep gönderen path'e göre filtrelemek isteyebiliriz. Bunun için Use yada Run fonksiyonlarında if kontrolü sağlayabilir yahut Map metodu ile daha profesyonel işlem yapabiliriz.
  
  * MapWhen : Map metodu ile sadece request'in yapıldığı path'e göre filtreleme yapılırken, MapWhen metodu ile gelen request'in herhangi bir özelliğine göre bir filtreleme işlemi gerçekleştirilebilir.















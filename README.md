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

***Controllers > ProductController.cs***

![Ekran görüntüsü 2025-02-06 193545](https://github.com/user-attachments/assets/8f10b82c-5fcb-43b1-8694-3bbbbdb22c7e)

***Views > Index.cshtml***

![Ekran görüntüsü 2025-02-06 193713](https://github.com/user-attachments/assets/ec36cf60-4a1e-4ff4-a377-12c2449d8b3b)










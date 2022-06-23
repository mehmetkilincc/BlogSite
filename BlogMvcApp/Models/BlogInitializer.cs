using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() { KategoriAdi="C#"},
                new Category() { KategoriAdi="Python"},
                new Category() { KategoriAdi="Java"},
                new Category() { KategoriAdi="Kotlin"}
            };
            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);

            }

            context.SaveChanges();
            List<Blog> bloglar = new List<Blog>()
            {
                new Blog()
                {   Baslik="C# Programlama Dili",
                    Aciklama="C# programlama dili hakkında herşey burada...",
                    EklenmeTarihi=DateTime.Now.AddDays(-10),
                    Anasayfa=true,
                    Onay=true,
                    Icerik="Yeni nesil programlama dili olan C sharp programlama konusunda yenilikleri de beraberinde getirmektedir. " +
                    "C# sunucu ve gömülü sistemleri için tasarlanmıştır. Microsoft tarafından geliştirilen C# .NET ortamında kullanılmak üzere geliştirilmiştir. " +
                    "Dilin tasarlanmasında Anders Hejlberg öncülük etmiştir. " +
                    "Zamanla gelişen bu programlama dili artık gerek masaüstü olsun gerek web uygulamaları olsun çoğu yerde kullanılmaktadır.",
                    Resim="1.jpg",
                    CategoryId= 1
                },
                new Blog()
                {   Baslik="C# İle Web Programlama",
                    Aciklama="C# programlama dili hakkında herşey burada...",
                    EklenmeTarihi=DateTime.Now.AddDays(-10),
                    Anasayfa=true,
                    Onay=true,
                    Icerik="C# nedir konusunda merak duyan herkes için başlangıç seviyesinde hazırlanan bu yazımızda genel hatlarıyla C# örnekleri sizlerle buluşturulacaktır. " +
                    "Böylece bu konuya bir giriş niteliğinde olan yazımızla C# dünyasına giriş yapmış olacaksınız."+
                    "C# ile yazılan programların çalışması için ‘.NET Kütüphaneleri’nin bulunduğu bilgisayarlarda bu sistemle uyumlu kütüphane ve derleyicinin olması yeterlidir. " +
                    "Bu kütüphane ve derleyici ‘.NET Framework’ da olabilir ECMA standartlarına sahip olan farklı bir kütüphane ya da derleyici de olabilir."+
                    "C# makine diline yakın olmasından ötürü orta seviyeli dil olarak kabul edilirken, insan algısına yakınlığı popüler olmasını sağlamıştır. " +
                    "Burada orta seviyeli dil hakkında bir cümlelik de olsa açıklama yapmak yerinde olacaktır. Çünkü bu kavram yanlış anlaşılmalara neden olabilmektedir."+
                    "Orta seviyeli dil o dilin güç seviyesini değil, makine diline olan seviyesini göstermektedir. " +
                    "Yani kodlama yapısı makine diline ne kadar yakınsa seviye ona nispeten düşmektedir. " +
                    "Aynı şekilde yüksek seviyeli bir dil demek, o dilin insan konuşma diline yakınlığıyla alakalıdır.",
                    Resim="1.jpg",
                    CategoryId= 1
                },
                new Blog()
                {   Baslik="C# Nedir Son Sözler",
                    Aciklama="C# programlama dili hakkında herşey burada...",
                    EklenmeTarihi=DateTime.Now.AddDays(-10),
                    Anasayfa=false,
                    Onay=true,
                    Icerik="C# nedir konulu yazımızla, sizlerde C# konusunda farkındalık oluşması amaçlanmıştır." +
                    " Burada sunulan örnek uygulamalar giriş seviyesinde olup daha ileri seviye uygulamalar için daha fazla araştırma yapıp bilgi sahibi olmak gerekmektedir."+
                    "Yazılım dünyasında birçok programlama dili bulunmaktadır. Her dilin kendine özgü özellikleri bulunmaktadır. " +
                    "C# deyince aklımıza asp-net nedir, sql nedir soruları da gelmektedir. Son zamanlarda mobil programlama nedir konusu da sık araştırılan konular arasındadır."+
                    "Uygulama geliştiriciler açısından C sharp programlama dilinin yeri farklıdır. " +
                    "Microsoft Visual Studio programıyla birlikte uygulama yazmak daha eğlenceli hale gelmektedir. " +
                    "Siz de C# bilginizi ilerilere taşıyarak yazılım konusunda aranan ve bilgisine başvurulan kimseler arasındaki yerinizi alabilirsiniz.",
                    Resim="2.jpg",
                    CategoryId= 1
                },
                new Blog()
                {   Baslik="Python Programlama Dili",
                    Aciklama="Python hakkında bilmek istediginiz herşey...",
                    EklenmeTarihi=DateTime.Now.AddDays(-30),
                    Anasayfa=true,
                    Onay=true,
                    Icerik="1991'den beri Python programlama dili sadece gereksiz programlar için tamamlayıcı bir dil olarak değerlendiriliyordu." +
                    "Hatta “Automate the Boring Stuff”(Türkçe'ye Sıkıcı Şeyleri Otomatikleştiren olarak " +
                    "çevirebileceğimiz popüler bir kitap) adında bir kitap dahi yayınlanmıştır. "+
                    "Bununla birlikte son birkaç yılda Python modern yazılım geliştirme, altyapı yönetimi ve " +
                    "veri analizinde birinci sınıf bir programlama dili olarak ön plana çıkmıştır." +
                    " Artık hackerlar için bir arka kapı oluşturucusu değil, web uygulaması oluşturma ve sistem yönetiminde önemli rol alma," +
                    " veri analizleri ve makine öğreniminde parlayan bir dil olarak ün kazanmıştır.",
                    Resim="2.jpg",
                    CategoryId= 2
                },
                new Blog()
                {   Baslik="Python ile Uygulama Programlama",
                    Aciklama="Python hakkında bilmek istediginiz herşey...",
                    EklenmeTarihi=DateTime.Now.AddDays(-10),
                    Anasayfa=true,
                    Onay=true,
                    Icerik="Python programlama dili ile konsol uygulamaları ve çoklu platformlara GUI uygulamaları" +
                    "oluşturabilirsiniz. Bunları bağım kurulum dosyları olarak kullanabilirsiniz. Python ile" +
                    "oluşturulan bir Script kendi başına bir binary serisi oluşturamaz, ancak  cx_Freeze and" +
                    "PyInstaller üçüncü taraf programlar sayesinde durum imkansızdan münküne dönüşmektedir.",
                    Resim="2.jpg",
                    CategoryId= 2
                },
                new Blog()
                {   Baslik="Veri Bilimi ve Makine Öğreniminde Python’un Yeri",
                    Aciklama="Python hakkında bilmek istediginiz herşey...",
                    EklenmeTarihi=DateTime.Now.AddDays(-20),
                    Anasayfa=true,
                    Onay=true,
                    Icerik="Sofistike veri analizleri günümüzde IT için en önemli konular haline gelmiştir. " +
                    "Python ise bu durumlar için en elverişli programlama dili olmuştur. " +
                    "Python arayüzündeki kütüphanelerin birçoğu makine öğrenimi ve veri bilimi üzerine elverişlidir. " +
                    "Bu alanlardaki kütüphanelerde ki yüksek kaliteli komutları, makine öğrenimi kütüphanelerinin ve diğer " +
                    "nümerik algoritma kütüphanelerinin sürekli gelişmesine çok yardımcı olmuştur. " ,
                    Resim="3.jpg",
                    CategoryId= 2
                },
                new Blog()
                {   Baslik="Java Programala dili ",
                    Aciklama="Java hakkında bilmek istediginiz herşey...",
                    EklenmeTarihi=DateTime.Now.AddDays(-14),
                    Anasayfa=true,
                    Onay=true,
                    Icerik="Java, Sun Microsystems mühendislerinden James Gosling tarafından geliştirilmeye başlanmış açık kodlu, nesneye yönelik(object-oriented)," +
                    "zeminden bağımsız, yüksek verimli, çok işlevli, yüksek seviye, adım adım işletilen yapısal bir dildir."+
                    "Java programlama dili pure object-oriented olmak amacı ile varlığını sürdüren nesneye yönelik programcılığı " +
                    "savunan ve sonuna kadar bu felsefeyi uygulamaya çalışan, platform independent yani belli bir platforma ihtiyaç duymayan " +
                    "bağımsız ve “wora” felsefesi ile ilerleyen bir dildir. Wora felsefesini açmak gerekirse eğer; “write once run anywhere”" +
                    " yani bir kere yaz heryerde kullan mantığı vardır."+
                    "Java dilinde program doğrudan anlaşılan koda dönüştürülmez.JVM(Java Sanal Makine) tarafından yorumlanan bayt " +
                    "koduna(.class dosyası) dönüştürülür.Bu sebeple de derlendiğinde herhangi bir yerde çalıştırılabilen bayt kodu dosyası " +
                    "oluşturur.Bir kez yaz ve herhangi bir yerde çalıştır doğasını buradan alır.",
                    Resim="3.jpg",
                    CategoryId= 3
                },
                new Blog()
                {   Baslik="Kotlin Programalama Dili",
                    Aciklama="Kotlin hakkında bilmek istediginiz herşey...",
                    EklenmeTarihi=DateTime.Now.AddDays(-5),
                    Anasayfa=true,
                    Onay=true,
                    Icerik="Kotlin, Java sanal makinesi (JVM) üzerinde çalışan ve ayrıca JavaScript kaynak koduna derlenebilir," +
                    " statik tipli bir programlama dilidir. İlk geliştirme Sankt-Peterburg, Rusya merkezli JetBrains programcıları " +
                    "tarafından yapılmıştır. İsmi Kotlin Adası'ndan gelmektedir.",
                    Resim="3.jpg",
                    CategoryId=4
                }

            };
            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);

            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
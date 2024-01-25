using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KitapHayalim.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {

                new Category() {
                   Name = "Sanat ve El Sanatları",
                   Description = "Resim, heykel, dikiş, örgü gibi sanat ve el becerileriyle ilgili kitaplar."
                },
                new Category() {
                   Name = "Mutfak ve Yemek",
                   Description = "Yemek tarifleri, pişirme teknikleri, diyet kitapları ve gurme lezzetlerle ilgili kitaplar."
                },
                new Category() {
                   Name = "Korku ve Gerilim",
                   Description = "Korku, gerilim ve psikolojik gerilim türündeki romanlar ve hikayeler."
                },new Category() {
                   Name = "Eğlence ve Mizah",
                   Description = "Mizah, komedi, esprili hikayeler ve güldüren kitaplar."
                },
                new Category() {
                   Name = "Felsefe ve Düşünce",
                   Description = "Felsefi metinler, düşünce sistemleri, etik, mantık ve filozofiyle ilgili kitaplar."
                },
                new Category() {
                   Name = "Bilimkurgu ve Fantazi",
                   Description = "Uzay, gelecek, mitoloji ve sihir gibi konuları içeren bilimkurgu ve fantastik romanlar."
                },
                new Category() {
                   Name = "Spor ve Egzersiz",
                   Description = "Spor dalları, egzersiz programları, sporcuların hikayeleri ve spor psikolojisiyle ilgili kitaplar."
                },new Category() {
                   Name = "Doğa ve Çevre",
                   Description = "Doğa, bitki ve hayvanlarla ilgili kitaplar, doğa fotoğrafçılığı ve çevre bilinciyle ilgili eserler."
                },
                new Category() {
                   Name = "Psikoloji ve Kişisel Gelişim",
                   Description = "Psikoloji, zihinsel sağlık, ilişkiler, özgüven ve kişisel gelişimle ilgili kitaplar."
                },
                new Category() {
                   Name = "Tıp ve Sağlık",
                   Description = "Tıp, sağlık bilgisi, hastalıklar, sağlıklı yaşam, alternatif tıp gibi konuları ele alan kitaplar."
                },

            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product() {
                   Publisher = "Yapıkredi Yayınları",
                   Author = "Orhan Pamuk",
                   Name = "Kırmızı Saçlı Kadın",
                   Description = "Bir aşk hikayesi ve sanatın büyüsü.",
                   Price = 810,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 1,
                   Image = "urun1.png",
                   Pages = "310"
                },new Product() {
                   Publisher = "Doğan Kitap",
                   Author = "Ahmet Ümit",
                   Name = "Beyoğlu Rapsodisi",
                   Description = "Lezzetli yemek tarifleri ve İstanbul'un lezzet yolculuğu.",
                   Price = 330,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 2,
                   Image = "urun2.png",
                   Pages = "310"
                },new Product() {
                   Publisher = "İthaki Yayınları",
                   Author = "Akinari Ueda",
                   Name = "Yağmur ve Ay Öyküleri",
                   Description = "Korku dolu bir gerilim romanı.",
                   Price = 150,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 3,
                   Image = "urun3.png",
                   Pages = "310"
                },new Product() {
                   Publisher = "Yapı Kredi Yayınları",
                   Author = "Orhan Kemal",
                   Name = "Baba Evi",
                   Description = "Eğlenceli ve mizahi bir roman.",
                   Price = 450,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 4,
                   Image = "urun4.png",
                   Pages = "310"
                },
                new Product() {
                   Publisher = "İş Bankası Kültür Yayınları",
                   Author = "Sabahattin Ali",
                   Name = "Kürk Mantolu Madonna",
                   Description = "Düşünceleri sorgulatan bir felsefe kitabı.",
                   Price = 230,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 5,
                   Image = "urun5.png",
                   Pages = "310"
                },new Product() {
                   Publisher = "Metis Yayınları",
                   Author = "Aslı Erdoğan",
                   Name = "Kırmızı Pelerinli Kent",
                   Description = "Bilimkurgu ve fantazi dolu bir macera romanı.",
                   Price = 130,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 6,
                   Image = "urun6.png",
                   Pages = "310"
                },new Product() {
                   Publisher = "Nobel Akademik Yayıncılık",
                   Author = "Daniel Gould , Robert S. Weinberg",
                   Name = "Spor ve Egzersiz Psikolojisinin Temelleri",
                   Description = "Spor ve egzersiz hakkında kapsamlı bir rehber.",
                   Price = 640,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 7,
                   Image = "urun7.png",
                   Pages = "310"
                },new Product() {
                   Publisher = "H. Vedat Atacan",
                   Author = "H. Vedat Atacan",
                   Name = "NEREDEN NEREYE!",
                   Description = "Doğa ve çevre konularında bilgilendirici bir kitap.",
                   Price = 110,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 8,
                   Image = "urun8.png",
                   Pages = "310"
                },
                new Product() {
                   Publisher = "Destek Yayınları",
                   Author = "Ayşe Gülen",
                   Name = "Bilinçaltının Gizli Şifreleri",
                   Description = "Psikoloji ve kişisel gelişim üzerine derinlemesine bir inceleme.",
                   Price = 730,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 9,
                   Image = "urun9.png",
                   Pages = "310"
                },new Product() {
                   Publisher = "Türkiye Diyanet Vakfı Yayınları",
                   Author = "Ayşegül Demirhan Erdemir",
                   Name = "Bilimin Işığında Başlangıçtan Cumhuriyete Türklerde Tıp ve Sağlık Kurumları",
                   Description = "Tıp ve sağlık alanında bir rehber kitap.",
                   Price = 74,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 10,
                   Image = "urun10.png",
                   Pages = "310"
                },new Product() {
                   Publisher = "Kubbealtı Neşriyatı Yayıncılık",
                   Author = "İnci A. Birol",
                   Name = "Türk Tezyini San'atlarında Motifler",
                   Description = "Kitap, Türk tiyatrosunun motiflerini açıklar.",
                   Price = 154,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 1,
                   Image = "urun11.png",
                   Pages = "224"
                },new Product() {
                   Publisher = "Gece Kitaplığı",
                   Author = "Sema Etikan",
                   Name = "Kırşehir El Sanatları",
                   Description = "Kırşehir'in eşsiz el sanatları canlanıyor.",
                   Price = 312,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 1,
                   Image = "urun12.png",
                   Pages = "271"
                },new Product() {
                   Publisher = "Motto Yayınları",
                   Author = "Genç Saraçaydın",
                   Name = "Ebru'dan İnsana",
                   Description = "Genç Saraçaydın: Tutkusuyla sınırları aşıyor.",
                   Price = 39,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 1,
                   Image = "urun13.png",
                   Pages = "94"
                },new Product() {
                   Publisher = "Akademisyen Kitabevi",
                   Author = "Ali Kemal Taşkın",
                   Name = "Halk Oyunları Çalışmalarının Ritim Yeteneği ve Çeviklik Üzerine Etkisi",
                   Description = "Halk oyunlarının ritim, çeviklik üzerinde etkisi.",
                   Price = 63,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 1,
                   Image = "urun14.png",
                   Pages = "92"
                },new Product() {
                   Publisher = "Arkadaş Yayıncılık",
                   Author = "Gönül Candaş",
                   Name = "Bereketli Olsun",
                   Description = "Sağlıklı, Ekonomik,lezzetli yemek sanatı.",
                   Price = 86,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 2,
                   Image = "urun15.png",
                   Pages = "332"
                },new Product() {
                   Publisher = "İletişim Yayınları",
                   Author = "Vedat Milor",
                   Name = "Buyurun Ziyafete",
                   Description = "Tutkuyla şekillenen restoran ve şarap eleştirmeni.",
                   Price = 70,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 2,
                   Image = "urun16.png",
                   Pages = "264"
                },new Product() {
                   Publisher = "Mundi",
                   Author = "Cenk Sönmezsoy",
                   Name = "Cafe Fernando",
                   Description = "Cenk Sönmezsoy'un tatlılarla dolu yemek hikâyesi.",
                   Price = 839,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 2,
                   Image = "urun17.png",
                   Pages = "416"
                },new Product() {
                   Publisher = "Hayykitap",
                   Author = "Canan Efendigil Karatay",
                   Name = "Karatay Mutfağı",
                   Description = "Karatay Mutfağı: Sağlıklı, lezzetli ve zayıflatıcı tarifler.",
                   Price = 83,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 2,
                   Image = "urun18.png",
                   Pages = "237"
                },new Product() {
                   Publisher = "Martı Yayınları",
                   Author = "N.G Kabal",
                   Name = "Saklambaç",
                   Description = "Sırlar, cinayetler ve kovalamacanın ardından gerçekler.",
                   Price = 46,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 3,
                   Image = "urun19.png",
                   Pages = "448"
                },new Product() {
                   Publisher = "Altın Kitaplar - Meşhur Romanlar Dizisi",
                   Author = "Stephen King",
                   Name = "O",
                   Description = "Korkunç yaratığın karanlıkla dans ettiği Derry.",
                   Price = 227,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 3,
                   Image = "urun20.png",
                   Pages = "462"
                },new Product() {
                   Publisher = "Yediveren Yayınları",
                   Author = "Işıl Işık",
                   Name = "Korku Günlüğü",
                   Description = "Karanlık dünyanın içinde keşiflere hazır olun!",
                   Price = 42,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 3,
                   Image = "urun21.png",
                   Pages = "144"
                },new Product() {
                   Publisher = "Yabancı",
                   Author = "Courtney Summers",
                   Name = "Proje",
                   Description = "1998'de başlayan ve yıllar süren karanlık sırlarla dolu bir hikaye.",
                   Price = 87,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 3,
                   Image = "urun22.png",
                   Pages = "328"
                },new Product() {
                   Publisher = "Eğlenceli Bilgi Yayınları",
                   Author = "Rachel Wright",
                   Name = "Suç Avcıları",
                   Description = "Delillerle suçluların izi, adalet sağlanıyor.",
                   Price = 38,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 4,
                   Image = "urun23.png",
                   Pages = "128"
                },new Product() {
                   Publisher = "Oky",
                   Author = "Marmara Çizgi",
                   Name = "Çarpışma 4",
                   Description = "İpek ve Burak, ilişkilerindeki yeni evrede zorlu yolculuğa çıkıyor.",
                   Price = 52,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 4,
                   Image = "urun24.png",
                   Pages = "104"
                },new Product() {
                   Publisher = "Duvarlara İnat",
                   Author = "Cafer Solgun",
                   Name = "Duvarlara İnat",
                   Description = "Yetenek cezaevinde keşfedilir, hayat değişir.",
                   Price = 28,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 4,
                   Image = "urun25.png",
                   Pages = "240"
                },new Product() {
                   Publisher = "Pan Yayıncılık",
                   Author = "Tan Oral",
                   Name = "Yüzyüze",
                   Description = "Kalemin izleriyle yüzler birleşti, sergiye dönüştü.",
                   Price = 31,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 4,
                   Image = "urun26.png",
                   Pages = "228"
                },new Product() {
                   Publisher = "Endişe Yayınları",
                   Author = "Abdulkerim Suruş",
                   Name = "İlim ve Felsefeye Giriş",
                   Description = "Gerçeği koruyan bilimsel kalkan: Bilimsellik madalyonu.",
                   Price = 8,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 5,
                   Image = "urun27.png",
                   Pages = "96"
                },new Product() {
                   Publisher = "Ağaç Yayınevi",
                   Author = "Murtaza Mutahhari",
                   Name = "Ahlak Felsefesi",
                   Description = "Doğru söylemek, vicdanın emri ve değeri.",
                   Price = 10,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 5,
                   Image = "urun28.png",
                   Pages = "311"
                },new Product() {
                   Publisher = "İnsan Yayınları",
                   Author = "Seyyid Yahya Yesribi",
                   Name = "İrfan Felsefesi",
                   Description = "İrfân'ın kapsamlı incelenmesi ve mistik felsefe perspektifi.",
                   Price = 130,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 5,
                   Image = "urun29.png",
                   Pages = "631"
                },new Product() {
                   Publisher = "Önsöz Yayıncılık",
                   Author = "Fevzi Yiğit",
                   Name = "Metafizik Ve Evrim",
                   Description = "Evrim, metafizik ve İslam felsefesinin kesişimi.",
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 5,
                   Image = "urun30.png",
                   Pages = "224"
                },new Product() {
                   Publisher = "Ayrıntı Yayınları",
                   Author = "Ursula K. Le Guin",
                   Name = "Karanlığın Sol Eli",
                   Description = "Androjen gezegende cinsiyet ve ikiliklerin sorgulanışı.",
                   Price = 83,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 6,
                   Image = "urun31.png",
                   Pages = "353"
                },new Product() {
                   Publisher = "Metis Yayınları",
                   Author = "Ursula K. Le Guin",
                   Name = "Mülksüzler",
                   Description = "Sistem çatışmaları, ütopya, eleştiri ve insan doğası.",
                   Price = 94,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 6,
                   Image = "urun32.png",
                   Pages = "344"
                },new Product() {
                   Publisher = "İthaki Yayınları",
                   Author = "J. R. R. Tolkien",
                   Name = "Hobbit",
                   Description = "Orta Dünya, macera, ejderha, kahramanlık, büyücü, hazineler, savaş.",
                   Price = 87,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 6,
                   Image = "urun33.png",
                   Pages = "336"
                },new Product() {
                   Publisher = "Epsilon Yayınevi",
                   Author = "George R. R. Martin",
                   Name = "Taht Oyunları",
                   Description = "Güç, iktidar, entrika, hırs, savaş, ihanet, kurgusal dünya.",
                   Price = 148,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 6,
                   Image = "urun34.png",
                   Pages = "850"
                },new Product() {
                   Publisher = "Akılçelen Kitaplar",
                   Author = "Tommaso Bernabei , Paul Cowcher",
                   Name = "Koşu",
                   Description = "Koşu, teknik, antrenman, strateji, sağlık, beslenme, rekabet.",
                   Price = 108,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 7,
                   Image = "urun35.png",
                   Pages = "258"
                },new Product() {
                   Publisher = "Nobel Yaşam",
                   Author = "Kolektif",
                   Name = "Futbol Bir Akıl Oyunu",
                   Description = "Spor psikolojisi, futbol, zihinsel dayanıklılık, potansiyel, uygulayıcılar, mitler, bilimsel çalışmalar.",
                   Price = 52,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 7,
                   Image = "urun36.png",
                   Pages = "169"
                },new Product() {
                   Publisher = "Akılçelen Kitaplar ",
                   Author = "Tommaso Bernabei , Paul Cowher , Remmert Wielinga",
                   Name = "Bisiklet",
                   Description = "Bisiklet sporuyla ilgili aklınıza gelecek her şey.",
                   Price = 108,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 7,
                   Image = "urun37.png",
                   Pages = "269"
                },new Product() {
                   Publisher = "Nobel Akademik Yayıncılık",
                   Author = "Onur Oral",
                   Name = "Spor ve Sağlık",
                   Description = "Spor, sağlık ve bilim birleşiyor, rehberlik ediyor.",
                   Price = 57,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 7,
                   Image = "urun38.png",
                   Pages = "124"
                },new Product() {
                   Publisher = "Yeni İnsan Yayınevi",
                   Author = "Vandana Shiva",
                   Name = "Tohumun Hikayesi",
                   Description = "Vandana Shiva: Tohumlarımızın kahramanı, geleceğimizin umudu.",
                   Price = 46,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 8,
                   Image = "urun39.png",
                   Pages = "364"
                },new Product() {
                   Publisher = "Ütopya Yayınevi",
                   Author = "Sibel Özbudun",
                   Name = "Kıyamete Çeyrek Kala!",
                   Description = "Kâr hırsı: Doğanın ve insanlığın tehlikesi.",
                   Price = 80,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 8,
                   Image = "urun40.png",
                   Pages = "500"
                },new Product() {
                   Publisher = "Orenda",
                   Author = "Kathryn Kellogg",
                   Name = "Sıfır Atık İçin 101 Yol",
                   Description = "Sıfır atık: Bilinçli tüketim, geri dönüşüm, doğaya saygı.",
                   Price = 56,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 8,
                   Image = "urun41.png",
                   Pages = "500"
                },new Product() {
                   Publisher = "Yeni İnsan Yayınevi",
                   Author = "Ceren Özcan Tatar",
                   Name = "Atıksız Yaşam",
                   Description = "Atıksız yaşam: Bilinçli tüketim, dönüşüm, zararsız çevre pratikleri.",
                   Price = 43,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 8,
                   Image = "urun42.png",
                   Pages = "112"
                },new Product() {
                   Publisher = " Psikonet",
                   Author = "David Burns",
                   Name = "İyi Hissetmek",
                   Description = "Dr. David D. Burns'un bilimsel terapisiyle iyi hissetmek.",
                   Price = 96,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 9,
                   Image = "urun43.png",
                   Pages = "408"
                },new Product() {
                   Publisher = " Alfa Yayıncılık",
                   Author = "Joe Navario",
                   Name = "Beden Dili",
                   Description = "Beden dilini öğrenin, iletişiminizi güçlendirin.",
                   Price = 87,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 9,
                   Image = "urun44.png",
                   Pages = "300"
                },new Product() {
                   Publisher = "Nobel Akademik Yayıncılık",
                   Author = "John W. Santrock",
                   Name = "Yaşam Boyu Gelişim",
                   Description = "Bireysel gelişimdeki yolculuğunuz için rehberlik eden kitap.",
                   Price = 281,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 9,
                   Image = "urun45.png",
                   Pages = "169"
                },new Product() {
                   Publisher = "Diyojen Yayıncılık",
                   Author = "Joseph Murphy",
                   Name = "Bilinçaltının Gücü",
                   Description = "Rüyaların Yolculuğunda Gizemli Gerçekleri Keşfedin.",
                   Price = 57,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 9,
                   Image = "urun50.png",
                   Pages = "288"
                },new Product() {
                   Publisher = "Mir Yayınları",
                   Author = "Arif Taşdemir",
                   Name = "Bal Tedavisi",
                   Description = "Doğal şifa kaynağı balın eski tıpta önemi.",
                   Price = 50,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 10,
                   Image = "urun46.png",
                   Pages = "139"
                },new Product() {
                   Publisher = "Asr Yayıncılık",
                   Author = "Ahmed Hacı Şerifi",
                   Name = "Doktorun Reçetesi",
                   Description = "Geleneksel tıpta şifayı arayanlar için kılavuz.",
                   Price = 200,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 10,
                   Image = "urun47.png",
                   Pages = "637"
                },new Product() {
                   Publisher = "Asr Yayıncılık",
                   Author = "Yezdan Amiri",
                   Name = "Şifa ve Derman",
                   Description = "Doğal çözümlerle sağlıklı yaşam için pratik rehber.",
                   Price = 110,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 10,
                   Image = "urun48.png",
                   Pages = "513"
                },new Product() {
                   Publisher = "Pegasus Yayınları",
                   Author = "Matthew Walker",
                   Name = "Niçin Uyuruz?",
                   Description = "Uykunun önemi ve etkilerini açıklayan kitap.",
                   Price = 108,
                   Stock = 10,
                   IsApproved = true,
                   IsHome = true,
                   CategoryId = 10,
                   Image = "urun49.png",
                   Pages = "400"
                }







            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
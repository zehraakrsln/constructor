// See https://aka.ms/new-console-template for more information
using constructor;
using constructor.Constructors;

Console.WriteLine("Hello, World!");



Matematik m = new Matematik();

int toplamSonucu = m.Topla(10, 3, 5);
int carpimSonucu = m.Carp(10, 3, 5 );
Console.WriteLine("toplam: " + toplamSonucu);
Console.WriteLine("Carpimi: " + carpimSonucu);


Marka marka = new Marka("BMW");
Model model = new Model("X5");
Kapi kapi = new Kapi(4);
Pencere pencere = new Pencere(4);
Kasa kasa = new Kasa("sedan");
Fiyat fiyat = new Fiyat(2000000);

Araba araba = new Araba(marka,model,kapi,pencere,kasa,fiyat);
YeniAraba yeni = new YeniAraba(araba);
yeni.Ozellikler();

/*
 Çöp toplayıcı 0 nesli nesnelerini temizledikten sonra, kalan nesneler için belleği sıkıştırır ve bunları 1 nesline yükseltir.
  0 nesli için GC işlemi yeterli belleği kurtaramazsa, işlem 1 nesli nesnelerine karşı çalışır. Bu işlemi atlatan nesneler 2 nesline yükseltilir.
 
Peki bellekte yeterli alan yoksa ne olur ?

“Çöp Toplayıcı” devreye girer ve basılmaya ihtiyaç duymadığı tüm nesnelerin belleğinin yığın bölgesinden anlaşılıyor.
Özetle; “new” anahtar değişkeni ile nesne içeriyordu, uygulama yığını belleğe gitti ve yer ayarlanamadı.
Çöp Toplayıcı devralındı ​​ve gerekli alan tahsisi yapıldı.

Generic Classlar
Generic metodlar, bir sınıfın bir veya daha fazla veri türüyle parametre verilmesi işlemine olanak tanır.
Bu sayede aynı sınıf yapısı farklı veri türleriyle kullanılabilir hale gelir. 
Örneğin, bir liste sınıfı oluşturulurken, generic metodlar kullanılarak bu liste farklı veri türleri ile ilgili işlemleri gerçekleştirebilir.

Generic yapılar genel olarak kod tekrarını azaltmakla birlikte daha okunabilir ve bakımı kolay hale getirir, yeniden kullanılabilirliği artırır ve daha esnek bir programlama yaklaşımı sunar diyebiliriz.
Diğer list ya da koleksiyon yapılarından en temel 2 farkı ise Performans ve Tip Güvenliği olarak ifade edebiliriz.


----Boxing & Unboxing 
Kutulama, bir değer türünü nesne olarak depolamak anlamına gelir = System.Object'te kutu değer türü
Kutudan çıkarma = değeri nesneden okuma = nesneden kutudan çıkarma değeri


1. Kutulama
Kutulama, bir değer türünü tür nesnesine veya bu değer türü tarafından uygulanan herhangi bir arayüz türüne dönüştürme işlemidir.
.NET CLR bir değer türünü kutular, yani onu System.Object örneğine sarar ve yönetilen (çöp toplanan) yığında depolar.
Kutulama örtük bir işlemdir.

2. Kutudan
Çıkarma Kutudan çıkarma, tür nesnesinden bir değer türüne veya bir arayüz türünden arayüzü uygulayan bir değer türüne açık bir dönüştürmedir.
Kutudan çıkarma, değer türünü nesneden çıkarır.
Bir kutudan çıkarma işlemi şunlardan oluşur:
i. Nesne örneğinin verilen değer türünün kutulanmış bir değeri olduğundan emin olmak için kontrol edilmesi.
ii. Değerin örnekten değer türü değişkenine kopyalanması.

Null değerini kutudan çıkarmaya çalışmak NullReferenceException'a neden olur.
Uyumsuz bir değer türüne ait bir referansı kutudan çıkarmaya çalışmak InvalidCastException'a neden olur.

Kutulama ve kutudan çıkarma işlemleri, hesaplama açısından maliyetli süreçler oldukları için performansı etkiler.
Bir değer türü kutulandığında, yeni bir nesne tahsis edilmeli ve oluşturulmalıdır. Daha az bir ölçüde, kutudan çıkarma için gereken dönüştürme de hesaplama açısından maliyetlidir.

Aşağıda, programlama sırasında kutulama/kutudan çıkarma işlemine istemeden neden olan ancak uzun vadede performansı etkileyecek bazı yaygın tuzaklar bulunmaktadır.

Bunlardan mümkün olduğunca kaçınmaya çalışın:

1. Bir değer türüyle “foreach” döngüsünü kullanma
2. Referans türleri için tasarlanmış koleksiyonlarda değer türlerini depolama
3. Değer türleriyle “as” operatörünü kullanma
4. Değer türleriyle “is” operatörünü kullanma
5. “object” türünü yöntem argümanları veya dönüş türleri için bir kapsayıcı olarak kullanma
6. Değer türleriyle “lock” ifadesini kullanma
7. Değer türlerini bir sözlükte anahtar olarak kullanma
8. Değer türleriyle “ref” veya “out” anahtar sözcüklerini kullanma
9. Değer türleriyle yöntem aşırı yüklemelerini kullanma
10. LINQ sorgularında değer türlerini kullanma
11. “Dinamik” türü kullanma
12. “Object” türünü genel bir tür argümanı olarak kullanma
 */
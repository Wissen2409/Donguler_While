
// Döngüler : 
// For, Foreach,While,Do While

// While döngüsü diğer tüm döngüler gibi, bir koşul sağlandığı sürece parantezlerinin içerisindeki kod bloklarını tekrarlar

// While, döngüsü, for döngüsünün gölgesinde kalmış gibidir. Emrah Eliş kanaat'i ortamlarda çok kullanılmaz.


// syntax 

/*

while(koşul)
{
}

// while döngüsü fordan farklı olarak, döngü değişkeni ve artırım ifadesi barındırmaz, sadece koşul ile çalışır ve koşul true olduğu sürece döner.


*/

// koşul true olarak verildi ve bu döngü sonsuza kadar döner
/*while(true){

    Console.WriteLine("sonsuza kadar dönecek");
}
*/

// While ile, 1-100 arası değerleri ekrana yazdıralım

/*int donguDegiskeni =0;

while(donguDegiskeni<100){
    Console.WriteLine(donguDegiskeni);
    donguDegiskeni++;

}
*/

// While çarpım tablosu : 

/*int i =1;
while(i<=10){

// bu döngü bir kere döngüğünde,
    int j = 1;
    while(j<=10){

        // bu döngü 10 kere dönecektir.
        Console.WriteLine("{0}x{1}={2}",i,j,i*j);

      j++;
    }
    Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*");
i++;

}
*/

// dik üçgen projemizi while ile çizelim 

/*

*
**
***
****
*****
******
********
*/

/*int satir = 0;
while (satir < 10){

    int sutun = 0;
    while(sutun<satir){

        Console.Write("*");
        sutun++;
    }
    Console.WriteLine();

    satir++;
}
*/

// Ekrandan aldığınız 10 adet not bilgisini ortalamasını ekrana yazdırınız

/*Console.WriteLine("Kaç Adet not gireceksiniz");
int notSayisi = int.Parse(Console.ReadLine());
int i = 0;
int toplamNot =0;
while (i < notSayisi){

    Console.WriteLine("{0}. notu giriniz",i+1);
    toplamNot+=int.Parse(Console.ReadLine());
    i++;
}

Console.WriteLine("Notlarınızın toplamı :{0} Ortalaması : {1}",toplamNot,toplamNot/notSayisi);
*/
// 1-den 10000 bine kadar tek sayı ve çift sayıların toplamı
/*int donguDegisken = 1;
int ciftSayi=0;
int tekSayi = 0;
while(donguDegisken<10000){

    if(donguDegisken%2==0){
        ciftSayi+=donguDegisken;
    }
    else{
        tekSayi+=donguDegisken;
    }
    donguDegisken++;
}
Console.WriteLine("Tek Sayiların toplamı {0}",tekSayi);
Console.WriteLine("Çift Sayıların toplamı {1}",ciftSayi);
*/


// while kullanarak sayı tahmin oyunu

etiket:
Random rnd = new Random();
int randomSayi = rnd.Next(1,100);
int donguDegisken=1;
bool kazanarakmiBitti = false;
while(donguDegisken<10){

    Console.WriteLine("{0}. tahmini giriniz",donguDegisken);
    int tahmin = int.Parse(Console.ReadLine());
    if(tahmin<randomSayi){
        Console.WriteLine("Yukarı");
    }
    if(tahmin>randomSayi){
        Console.WriteLine("aşağı");
    }
    if(randomSayi==tahmin){

        // oyun biter döngüden çıkılması lazım
        // oyun kazanıldığında, artık tahmin girilmemesi gerekiyor
        // döngüden çıkmak için


        // oyun bitti döngü sonlanacak ancak döngü iki şekilde sonlanır
        // 1- kazanınca
        // 2- kaybedince

        // bu ayrımı yapabilmek için, kazanınca bir bool değişkene true değer ataması yapacağız
        kazanarakmiBitti=true;
        break;
    }
donguDegisken++;
}
if(kazanarakmiBitti){
    Console.WriteLine("Tebrikler");
}
else{
    Console.WriteLine("Kaybettiniz tekrar deneyiniz");
    Console.WriteLine("Oyun tekrar başlaması için lütfen bir tuşa basınız");
    Console.ReadLine();

    goto etiket;
}

// eğer kaybettiyse, 5 hak tanınır, kaybettiği zaman kullanıcıya devam edip etmeyeceği sorulur,
// eğer devam ederse, 5 kredisinde bir tanesi düşer ve oyun tekrar başlar





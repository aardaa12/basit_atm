using System.ComponentModel;

Console.WriteLine( " Hoşgeldiniz!");
Console.WriteLine( "Lütfen yapmak isteidğiniz işlemi seçiniz.");
Console.WriteLine("1. Bakiye Sorgulama ");
Console.WriteLine("2 Para Çekme ");
Console.WriteLine("3. Para Yatırma");
int deger;

int bakiye = 100;


Console.WriteLine( "Lütfen yapmak istedğiniz işlemi giriniz.");
deger = Convert.ToInt32(Console.ReadLine());



if (deger == 1)
{
    Console.WriteLine( $"Hesaptaki bakiye:{bakiye} ");
    
}
if (deger == 2)
{
    int cekilecekTutar = 0;
    Console.WriteLine("Çekilecek değeri giriniz.");
   cekilecekTutar = Convert.ToInt32(Console.ReadLine());

    if (bakiye < cekilecekTutar)
    {
        Console.WriteLine("Hesabınızda bu kadar para bulunmamaktadır!!");

        return;
    }

    bakiye -= cekilecekTutar;

    Console.WriteLine($"Para başarıyla çekildi. Şuanki bakiyen: {bakiye}");

}
if (deger == 3) { 
 int parayatir = 0;
Console.WriteLine( $" Şuanki bakiyeniz: {bakiye}");
 Console.WriteLine(  "Lütfen yatırmak istediğiniz değeri giriniz:");
parayatir=Convert.ToInt32(Console.ReadLine());

    bakiye+= parayatir;
    Console.WriteLine($"Para başarıyla yatırıldı. Şuanki bakiyeniz: {bakiye}");
}
Console.WriteLine( " Başka bir işlem için lütfen paneli tekrar başlatınız!!");



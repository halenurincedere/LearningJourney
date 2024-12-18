using System;
class Program
{
    static void Main(string[] args)
    {
        //Kullanıcı adı al
        Console.Write("Lütfen kullanıcı adını giriniz:");
        string? ad = Console.ReadLine();
        ad = string.IsNullOrWhiteSpace(ad) ? "******" : ad; // Boşsa "Gizli" atar

        // kullanıcı soyadı al
        Console.Write("Lütfen soyadınızı giriniz:");
        string? soyad = Console.ReadLine();
        soyad = string.IsNullOrWhiteSpace(soyad) ? "*****" : soyad; // Boşsa "Gizli" atar

        //Ad soyad birleştir
        string tamAd = ad + " " + soyad;

        //Ekrana çıktıyı yazdır
        Console.WriteLine("Giriş Başarılı");

        Console.WriteLine("Hoşgeldin," + tamAd.ToUpper() );
    }
}
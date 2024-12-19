using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan geçerli bir girdi alana kadar döngü devam eder
        string? giris = null;

        while (string.IsNullOrWhiteSpace (giris))
        {
            Console.Write("Lütfen bir kelime veya cümle giriniz:");
            giris = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(giris))
            {
                Console.WriteLine("Boş Bırakmayınız, lütfen geçerli bir metin giriş yapınız!");
            }
        }
        //Kelimenin uzunluğunu hesaplama
        int uzunluk = giris.Length;

        //Sonucu ekrana yazdır
        Console.WriteLine($"Girdiğiniz kelimenin uzunluğu: {uzunluk} karakterdir.");
    }
}
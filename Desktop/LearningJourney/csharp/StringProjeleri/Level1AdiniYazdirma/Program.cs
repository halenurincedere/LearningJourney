using System;

class Program
{
    static void Main(string[] args)
    {
        //Projelerim başta türkçe daha sonra ingilizce olarak devam edecektir.

        // Kullanıcıdan adını al
        string? ad = null ;
        // Kullanıcın boş bir değer vermesini istemiyorum. 
        while (string.IsNullOrWhiteSpace(ad))
        {
            Console.Write("Lütfen adınızı giriniz:");
            ad = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(ad))
            {
                Console.WriteLine("Adınızı boş bırakamazsınız.Lütfen geçerli bir isim giriniz.");
            }
        }

        // Kullanıcıya selam ver ve mesajını ilet.
        Console.WriteLine("Merhaba, " + ad + "!");
        Console.WriteLine("Bu, senin ilk adımın! Küçük adımlarla büyük yollar kat edeceksin.");
        Console.WriteLine("Kendine güven, öğrenmeye devam et ve asla pes etme!");
    }
}

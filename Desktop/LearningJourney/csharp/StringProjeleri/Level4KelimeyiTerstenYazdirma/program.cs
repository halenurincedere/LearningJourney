using System

class program
{
    static void Main(string[]args)
    {
        string? giris = null;

        //Kullanıdan girdi al
        while (string.IsNullOrWhiteSpace(giris))
        {
            Console.Write("Lütfen bir kelime veya cümle giriniz");
            Console.ReadLine();

            if (string.IsNullOrWhiteSpace(giris))
            {
                Console.WriteLine("Boş bırakmayınız, lütfen geçerli bir giriş yapın!");
            }
        }
        //Kelimenin tersten yazdırmak
        char[] karakterDizisi = giris.ToCharArray();
        Array.Reverse(karakterDizisi);

        //sonucu yazdır
        Console.WriteLine ($"Girdiğiniz kelimenin tersi: {tersGirdi} ");
    }
}
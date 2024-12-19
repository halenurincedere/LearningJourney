namespace Degiskenler;

class Program
{
    static void Main(string[] args)
    {
        //int sayi;
        //sayi = 24;
        //Console.Write(sayi);

        int kisa, uzun, alan, cevre;
        Console.Write("Kısa kenar:");
        kisa = Convert.ToInt16(Console.ReadLine());
        uzun =Convert.ToInt16(Console.ReadLine());
        alan = kisa * uzun;
        cevre = kisa + kisa + uzun +uzun ;
        Console.Write("Alan :" + alan);
        Console.Write("Çevre :" + cevre);


    }
}

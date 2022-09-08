using System;


class Program

{
    static void Main (string[] args)
        {
        Console.WriteLine("Bir sayı giriniz= ");
        int deger = int.Parse(s: Console.ReadLine());

        int kalan, tersi=0;
        while (deger > 0)
        {
            kalan = deger % 10;
            tersi = tersi * 10 + kalan;
            deger = deger / 10;
        }
        Console.WriteLine(tersi);
        Console.ReadLine();
    }
}
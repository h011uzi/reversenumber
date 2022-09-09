
using System;

// Metin içerisinde kelime bulma


public class Example
{
    public static void Main()
    {
        string kelime;
        string metin;
        int index, say;

        Console.WriteLine("Metni gir ");
        metin = Console.ReadLine().ToLower();

        Console.WriteLine("Aranacak kelime = ");
        kelime = Console.ReadLine().ToLower();

        index = -1;
        say = 0;
        while ( (index = metin.IndexOf(kelime, index + 1)) != -1)
            ++say;

        Console.WriteLine(say);
        Console.Read();

    }

}

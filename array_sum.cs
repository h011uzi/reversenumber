
using System;

//Girilen dizi değerlerinin toplamını alma.

public class Example
{
    public static void Main()
    {
        Console.WriteLine("Diziye ait değerleri gir ");
        var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int sum = 0;
        Array.ForEach(array, i => sum += i);

        Console.WriteLine(sum);
        Console.ReadLine();
    }
}

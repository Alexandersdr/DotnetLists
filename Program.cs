using System;

namespace DotnetLists
{
 class Program
 {
    static void Main(string[] args)
    {
        Console.Clear();

        var meuArray = new int[5] { 1, 2, 3, 4, 5 };
        meuArray[0] = 12;
        Console.WriteLine(meuArray.Length);

    }
 }

}

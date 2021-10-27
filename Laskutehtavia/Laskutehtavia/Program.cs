using System;

namespace Laskutehtavia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ensimmäinen numero: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen numero: ");
            int luku2 = int.Parse(Console.ReadLine());
                Console.WriteLine("x = " + (luku2+3));
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
                Console.WriteLine("x = " + (luku2-2));
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
                Console.WriteLine("x = " + (luku2*5));
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
                Console.WriteLine("x = " + (luku1 / luku2));
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
                Console.WriteLine("x = " + (luku1 % luku2));
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
                Console.WriteLine("x = " + (luku1 += luku2));
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
                Console.WriteLine("x = " + (luku1 -= luku2));
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
                Console.WriteLine("x = " + (luku1 *= luku2*5));
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
                Console.WriteLine("x = " + (luku1 /= luku2));
        }
        
    }
}

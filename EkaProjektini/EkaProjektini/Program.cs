using System;

namespace EkaProjektini
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hyvää päivää");
            Console.WriteLine("Jyri Lindroos");
            Console.WriteLine("1\n11\n101\n1001");
            Console.Write("Anna etunimesi:");
            string nimi = Console.ReadLine();
            Console.WriteLine("Hei " + nimi + ", onpas sinulla komea nimi!");
            DateTime nykyhetki = DateTime.Now;
            Console.WriteLine(nykyhetki.Date.ToString("d"));
            double luku1 = 3.72, luku2 = 5.43;
            Console.Write(luku1 + " ");
            Console.Write("Floor: " + Math.Floor(luku1) + " ");
            Console.Write("Ceiling: " + Math.Ceiling(luku1) + " ");
            Console.WriteLine("Round: " + Math.Round(luku1));
            Console.Write(luku2 + " ");
            Console.Write("Floor: " + Math.Floor(luku2) + " ");
            Console.Write("Ceiling: " + Math.Ceiling(luku2) + " ");
            Console.WriteLine("Round: " + Math.Round(luku2));
        }
    }
}

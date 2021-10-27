using System;

namespace Metodeja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valitse tehtävä, jonka haluat suorittaa (1 - 17): ");
            int teht = int.Parse(Console.ReadLine());
            switch(teht)
            {
                case 1:
                    Console.Write("Ole hyvä ja anna ensimmäinen yhteenlaskettava: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Ole hyvä ja anna toinen yhteenlaskettava: ");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Lukujen " + x + " ja " + y + " summa on " + Yhteenlasku(x, y));
                    break;
                case 2:
                    Console.Write("Ole hyvä ja anna Celsiusaste, joka muutetaan Fahrenheitiksi: ");
                    int celsius = int.Parse(Console.ReadLine());
                    Console.WriteLine(celsius + "astetta celsiusta on " + Fahrenheit(celsius) + " astetta fahrenheitia");
                    break;
                case 3:
                    Console.Write("Ole hyvä ja anna ensimmäinen peruslaskettava: ");
                    int l1 = int.Parse(Console.ReadLine());
                    Console.Write("Ole hyvä ja anna toinen peruslaskettava: ");
                    int l2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(Perus(l1, l2));
                    break;
               case 4:
                    Console.Write("Ole hyvä ja anna jaettava: ");
                    int j1 = int.Parse(Console.ReadLine());
                    Console.Write("Ole hyvä ja anna jakaja: ");
                    int j2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Lukujen " + j1 + " ja " + j2 + " jakojäännös on " + Jakoj(j1, j2)); 
                    break;
               case 5:
                    Hei();
                    break;
               case 6:
               case 7:
               case 8:
               case 9:
               case 10:
                    Console.Write("Ole hyvä ja anna luku, josta teen kertotaulun: ");
                    int kerto = int.Parse(Console.ReadLine());
                    Kertotaulu(kerto);
                    break;
               case 11:
                    Console.Write("Ole hyvä ja anna ikäsi: ");
                    int ika = int.Parse(Console.ReadLine());
                    Console.WriteLine(Ika(ika));
                    break;
               case 12:
                    Console.Write("Ole hyvä ja anna luku, jota toistetaan (>10): ");
                    int toistettava = int.Parse(Console.ReadLine());
                    Toisto(toistettava);
                break;
/*            case 13:
                Tehtava13();
                break;
            case 14:
                Tehtava14();
                break;
            case 15:
                Tehtava15();
                break;
            case 16:
                Tehtava16();
                break;
            case 17:
                Tehtava17();
                break;
            default:
                break;*/
            }
        }
        static int Yhteenlasku(int luku1, int luku2)
        {
            return luku1 + luku2;
        }
        static double Fahrenheit(int celsius)
        {
            return celsius * 1.8 + 32;
        }
        static string Perus(int l1, int l2)
        {
            double t1, t2, t3, t4;
            t1 = l1 + l2;
            t2 = l1 - l2;
            t3 = l1 * l2;
            t4 = (double)l1 / l2;
            string palautus = "Lukujen " + l1 + " ja " + l2 + " peruslaskut olivat seuraavat:\n" + l1 + " + " + l2 + " = " + t1 + "\n" + l1 + " - " + l2 + " = " + t2 + "\n" + l1 + " * " + l2 + " = " + t3 + "\n" + l1 + " / " + l2 + " = " + t4;
            return palautus;
        }
        static int Jakoj(int j1, int j2)
        {
            return j1 % j2;
        }
        static void Hei()
        {
            Console.Write("Ole hyvä ja anna etunimesi: ");
            string nimi = Console.ReadLine();
            Console.WriteLine("Hei " + nimi + "!");
        }
        static void Kertotaulu(int kerto)
        {
            for(int x = 1; x <= 10; x++)
            {
                Console.WriteLine(x + " * " + kerto + " = " + x * kerto);
            }
        }
        static string Ika(int ika)
        {
            return ika + " - näytät ikäistäsi nuoremmalta!";
        }
        static void Toisto(int toistettava)
        {
            for(int x = 0; x < toistettava; x++)
            {
                for(int y = 0; y < toistettava; y++)
                {
                    Console.Write(toistettava + " ");
                }
                Console.WriteLine();
                for (int y = 0; y < toistettava; y++)
                {
                    Console.Write(toistettava);
                }
                Console.WriteLine();

            }
        }
    }
}

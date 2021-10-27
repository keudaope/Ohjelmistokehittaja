using System;

namespace ehtolauseita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valitse tehtävä, jonka haluat suorittaa (1-7): ");
            int tehtava = int.Parse(Console.ReadLine());
            Alku:
            switch(tehtava)
            {
                case 1:
                    Tehtava1();
                    break;
                case 2:
                    Tehtava2();
                    break;
                case 3:
                    Tehtava3();
                    break;
                case 4:
                    Tehtava4();
                    break;
               case 5:
                    Tehtava5();
                    break;
                case 6:
                     Tehtava6();
                     break;
                case 7:
                     Tehtava7();
                     break;
                default:
                    Console.WriteLine("Virheellinen valinta. Valitse 0-7: ");
                    Console.ReadLine();
                    goto Alku;
            }
            static void Tehtava1()
            {
                Console.Write("Anna ensimmäinen kokonaisluku: ");
                int luku1 = int.Parse(Console.ReadLine());
                Console.Write("Anna toinen kokonaisluku: ");
                int luku2 = int.Parse(Console.ReadLine());
                int suurin = luku1;
                if(luku2 > suurin)
                {
                    Console.WriteLine("Luvut suuruusjärjestyksessä: " + luku1 + " ja " + luku2);
                }
                else
                {
                    Console.WriteLine("Luvut suuruusjärjestyksessä: " + luku2 + " ja " + luku1);
                }
            }
            static void Tehtava2()
            {
                Console.Write("Anna ensimmainen kokonaisluku: ");
                int luku1 = int.Parse(Console.ReadLine());
                int suurin = luku1;
                Console.Write("Anna toinen kokonaisluku: ");
                int luku2 = int.Parse(Console.ReadLine());
                if(luku2 > suurin)
                {
                    suurin = luku2;
                }
                Console.Write("Anna kolmas kokonaisluku: ");
                int luku3 = int.Parse(Console.ReadLine());
                if(luku3 > suurin)
                {
                    suurin = luku3;
                }
                Console.WriteLine("Suurin luku oli: " + suurin);
            }
            static void Tehtava3()
            {
                Console.WriteLine("Anna kokonaisluku (0 - 9): ");
                int luku = int.Parse(Console.ReadLine());
                Alu:
                switch (luku)
                {
                    case 0:
                        Console.WriteLine("Lukusi kirjaimina on nolla");
                        break;
                    case 1:
                        Console.WriteLine("Lukusi kirjaimina on yksi");
                        break;
                    case 2:
                        Console.WriteLine("Lukusi kirjaimina on kaksi");
                        break;
                    case 3:
                        Console.WriteLine("Lukusi kirjaimina on kolme");
                        break;
                    case 4:
                        Console.WriteLine("Lukusi kirjaimina on neljä");
                        break;
                    case 5:
                        Console.WriteLine("Lukusi kirjaimina on viisi");
                        break;
                    case 6:
                        Console.WriteLine("Lukusi kirjaimina on kuusi");
                        break;
                    case 7:
                        Console.WriteLine("Lukusi kirjaimina on seitsemän");
                        break;
                    case 8:
                        Console.WriteLine("Lukusi kirjaimina on kahdeksan");
                        break;
                    case 9:
                        Console.WriteLine("Lukusi kirjaimina on yhdeksän");
                        break;
                    default:
                        Console.WriteLine("Virheellinen syöte. Anna numero välillä 0 - 9");
                        luku = int.Parse(Console.ReadLine());
                        goto Alu;
                        
                }
            }
            static void Tehtava4()
            {
                int[] luku = new int[5]; 
                Console.Write("Anna ensimmainen kokonaisluku: ");
                luku[0] = int.Parse(Console.ReadLine());
                int suurin = luku[0];
                for(int x = 1; x <=4; x++)
                {
                    Console.Write("Anna " + (x+1) + ". kokonaisluku: ");
                    luku[x] = int.Parse(Console.ReadLine());
                    if (luku[x] > suurin)
                    {
                        suurin = luku[x];
                    }
                }
                Console.WriteLine("Suurin luku oli: " + suurin);
            }
            static void Tehtava5()
            {
                Console.WriteLine("Millaisen tiedon haluat syöttää? (k = kokonaisluku, d = desimaaliluku, m = merkkijono): ");
                string syote = Console.ReadLine();
                Hyppy:
                switch(syote)
                {
                    case "k":
                        Console.Write("Anna kokonaisluku: ");
                        int kl = int.Parse(Console.ReadLine());
                        Console.WriteLine("Annoit luvun " + kl + "johon lisäsin 1: " + (kl + 1));
                        break;
                    case "d":
                        Console.Write("Anna desimaaliluku: ");
                        decimal dl = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Annoit luvun " + dl + "johon lisäsin 1: " + (dl + 1));
                        break;
                    case "m":
                        Console.Write("Anna merkkijono: ");
                        string mj = Console.ReadLine();
                        Console.WriteLine("Annoit merkkijonon " + mj + ", johon lisäsin *: " + (mj + "*"));
                        break;
                    default:
                        Console.Write("Virheellinen syöte. Anna joko k, d tai m: ");
                        syote = Console.ReadLine();
                        goto Hyppy;
                }
            }
            static void Tehtava6()
            {
                Console.Write("Anna pisteet (1 - 9): ");
                int pisteet = int.Parse(Console.ReadLine());
                Jump:
                switch(pisteet)
                {
                    case 1:
                    case 2:
                    case 3:
                        pisteet = pisteet * 10;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        pisteet = pisteet * 100;
                        break;
                    case 7:
                    case 8:
                    case 9:
                        pisteet = pisteet * 1000;
                        break;
                    default:
                        Console.Write("Virheellinen syöte. Anna luku välillä 1 - 9: ");
                        pisteet = int.Parse(Console.ReadLine());
                        goto Jump;
                }
                Console.WriteLine("Kokonaispisteesi ovat: " + pisteet);
            }
            static void Tehtava7()
            {
                string lause = "";
                Console.Write("Anna numero välillä 0 - 999: ");
                string nro = Console.ReadLine();
                int maara = nro.Length;
                if(maara == 3)
                {
                    lause += Sadat(nro[0]);
                    if (nro[1] == '1')
                    {
                        lause += Poikkeukset(nro[2]);
                    }
                    else
                    {
                        lause += Kymmenet(nro[1]);
                        lause += Ykkoset(nro[2]);
                    }
                }
                else if(maara == 2)
                {
                    Console.WriteLine("Nro[0] = " + nro[0]);
                    if(nro[0] == '1')
                    {
                        lause += Poikkeukset(nro[1]);
                    }
                    else
                    {
                        lause += Kymmenet(nro[0]);
                        lause += Ykkoset(nro[1]);
                    }
                    
                }
                
                else
                {
                    lause += Ykkoset(nro[0]);
                }
                Console.WriteLine(lause);
                static string Sadat(int luku)
                {
                    switch(luku)
                    {
                        case '9':
                            return "yhdeksänsataa ";
                        case '8':
                            return "kahdeksansataa ";
                        case '7':
                            return "seitsemänsataa ";
                        case '6':
                            return "kuusisataa ";
                        case '5':
                            return "viisisataa ";
                        case '4':
                            return "neljäsataa ";
                        case '3':
                            return "kolmesataa ";
                        case '2':
                            return "kaksisataa ";
                        case '1':
                            return "sata ";
                        default:
                            return "";
                    }       
                }
                static string Kymmenet(int luku)
                {
                    switch (luku)
                    {
                        case '9':
                            return "yhdeksänkymmentä ";
                        case '8':
                            return "kahdeksankymmentä ";
                        case '7':
                            return "seitsemänkymmentä ";
                        case '6':
                            return "kuusikymmentä ";
                        case '5':
                            return "viisikymmentä ";
                        case '4':
                            return "neljäkymmentä ";
                        case '3':
                            return "kolmekymmentä ";
                        case '2':
                            return "kaksikymmentä ";
                        case '1':
                            return "kymmenen ";
                        default:
                            return "";
                    }
                }
                static string Ykkoset(int luku)
                {
                    switch (luku)
                    {
                        case '9':
                            return "yhdeksän";
                        case '8':
                            return "kahdeksan";
                        case '7':
                            return "seitsemän";
                        case '6':
                            return "kuusi";
                        case '5':
                            return "viisi";
                        case '4':
                            return "neljä";
                        case '3':
                            return "kolme";
                        case '2':
                            return "kaksi";
                        case '1':
                            return "yksi";
                        default:
                            return "";
                    }
                }
                static string Poikkeukset(int luku)
                {
                    switch (luku)
                    {
                        case '9':
                            return "yhdeksäntoista";
                        case '8':
                            return "kahdeksantoista";
                        case '7':
                            return "seitsemäntoista";
                        case '6':
                            return "kuusitoista";
                        case '5':
                            return "viisitoista";
                        case '4':
                            return "neljätoista";
                        case '3':
                            return "kolmetoista";
                        case '2':
                            return "kaksitoista";
                        case '1':
                            return "yksitoista";
                        default:
                            return "";
                    }
                }
            }
            
        }
    }
}

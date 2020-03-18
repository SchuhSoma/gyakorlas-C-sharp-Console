using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlás_20200318
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("\n-------------------------\n");
            Feladat1();
            Console.WriteLine("\n-------------------------\n");
            Feladat2();
            Console.WriteLine("\n-------------------------\n");
            Feladat3();
            Console.WriteLine("\n-------------------------\n");
            Feladat4();
            Console.WriteLine("\n-------------------------\n");
            Feladat5();
            Console.WriteLine("\n-------------------------\n");
            Feladat6();
            Console.WriteLine("\n-------------------------\n");
            HaziFeladat1();
            Console.WriteLine("\n-------------------------\n");
            HaziFeladat2();
            Console.ReadKey();
        }

        private static void HaziFeladat2()
        {
            Console.WriteLine("Házi feldat 2");
            Console.WriteLine("Kérem adja meg a nevét: ");
            string Nev = Console.ReadLine();
            eleje:
            Console.WriteLine("Kérem adja meg a szemüveg dioptriáját: ");
            double Dioptria = double.Parse(Console.ReadLine());
            if (Dioptria > 0)
            {
                if (Dioptria < 1)
                {
                    Console.WriteLine("Az Ön látása {0}, jó a látása.", Nev);
                }
                if (1 <= Dioptria && Dioptria < 2)
                {
                    Console.WriteLine("Az Ön látása {0}, átlagos a látása.", Nev);
                }
                if (2 <= Dioptria && Dioptria < 3)
                {
                    Console.WriteLine("Az Ön látása {0}, átlagostól gyengébb a látása.", Nev);
                }
                if (3<= Dioptria && Dioptria < 4)
                {
                    Console.WriteLine("Az Ön látása {0}, gyenge a látása.", Nev);
                }
                if (4 <= Dioptria && Dioptria < 5)
                {
                    Console.WriteLine("Az Ön látása {0}, nagyon gyenge a látása.", Nev);
                }
                if (5 <= Dioptria && Dioptria < 6)
                {
                    Console.WriteLine("Az Ön látása {0}, nagyon-nagyon gyenge a látása.", Nev);
                }
            }
            else
            {
                Console.WriteLine("Hibás magasság");
                goto eleje;
            }
        }

        private static void HaziFeladat1()
        {
            Console.WriteLine("Házi feladat 1");
            Console.Write("Kérem adja meg a hatvány alapot :");
            double Hatvany_alap = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg hanyadik hatványt szeretné kiszámolni :");
            int Hanyadik_hatvany = int.Parse(Console.ReadLine());
            double Ertek = 0;
            for (int i = 0; i <= Hanyadik_hatvany; i++)
            {
                Ertek = Math.Pow(Hatvany_alap, i);
                Console.WriteLine("{0,-3}. hatvány := {1}", i, Ertek);
            }
        }

        private static void Feladat6()
        {
            Console.WriteLine("6.Feladat");
            Console.Write("Kérem adja meg a nevét : ");
            string Nev = Console.ReadLine();
            eleje:
            Console.Write("Kérem adja meg a magasságát méterben: ");
            double MagassagCm = double.Parse(Console.ReadLine()) * 100;
            if(MagassagCm>0)
            {
                if(MagassagCm<90)
                {
                    Console.WriteLine("Sajnos {0}, Ön rettentően alacsony.", Nev);
                }
                if (90<=MagassagCm && MagassagCm < 120)
                {
                    Console.WriteLine("Sajnos {0}, Ön eléggé alacsony.", Nev);
                }
                if (120 <= MagassagCm && MagassagCm < 150)
                {
                    Console.WriteLine("Sajnos {0}, Ön alacsony.", Nev);
                }
                if (150 <= MagassagCm && MagassagCm < 180)
                {
                    Console.WriteLine("Sajnos {0}, Ön normál magasságú.", Nev);
                }
                if (180 <= MagassagCm && MagassagCm < 210)
                {
                    Console.WriteLine("Sajnos {0}, Ön nagyon magas.", Nev);
                }
                if (210 <= MagassagCm )
                {
                    Console.WriteLine("Sajnos {0}, Ön Ön rendkívül magas.", Nev);
                }
            }
            else
            {
                Console.WriteLine("Hibás magasság");
                goto eleje;
            }
        }

        private static void Feladat5()
        {
            Console.WriteLine("5.Feladat");
            Console.Write("Kérem adja meg a kocka élének a hosszát: ");
            double Kocka_Elhossz = double.Parse(Console.ReadLine());
            double Felszin = 6 * Math.Pow(Kocka_Elhossz, 2);
            Console.WriteLine("Kocka Felszíne := {0}", Felszin);
            double Terfogat = Math.Pow(Kocka_Elhossz, 3);
            Console.WriteLine("Kocka Térfogata := {0}", Terfogat);
            double KorulSugar = (Math.Sqrt(3) / 2) * Kocka_Elhossz;
            Console.WriteLine("Kocka körül írt gömb sugara := {0}", KorulSugar);
            double BeirhatoSugar = 0.5 * Kocka_Elhossz;
            Console.WriteLine("Kocka beírt írt gömb sugara := {0}", BeirhatoSugar);

        }

        private static void Feladat4()
        {
            Console.WriteLine("4.Feladat");
            int BuvosKocka1;
            int BuvosKocka2;
            int Osszeg = 0;
            int db = 0;
            for (int i = 1; i <= 6; i++)
            {
                BuvosKocka1 = rnd.Next(1, 9);
                BuvosKocka2 = rnd.Next(1, 9);
                Osszeg = BuvosKocka1 + BuvosKocka2;
                if(Osszeg==11)
                {
                    db++;
                }
                Console.WriteLine("Kocka 1 dobás := {0},\t Kocka 2 dobás := {1}, \tdobás összeg := {2}", BuvosKocka1, BuvosKocka2, Osszeg );
            }
            Console.WriteLine("\n\tEnnyiszer dobtunk 11-et := {0}", db);
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.Feladat\n");
            double Asvanyi_Anyag;
            int db = 0;
            double Osszeg = 0;
            double Atlag = 0;
            for (int i = 1; i < 19; i++)
            {
                Asvanyi_Anyag = rnd.Next(45,75);
                Osszeg += Asvanyi_Anyag;
                Atlag = Osszeg / 18;
                if(Asvanyi_Anyag>65)
                {
                    db++;
                }

                Console.WriteLine("\t{0} kút ásványi anyag tartalma: {1}", i, Asvanyi_Anyag);
            }
            Console.WriteLine("\n\tEnnyi elkalommal volt több az ásványi anyag tartalom mint 65 mg/l: {0}",db);
            Console.WriteLine("\n\tA kutak ásványi anyag tartalmának átlaga: {0} mmg/l", Atlag);
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat");
            Console.Write(" Kérem adja meg az a oldalt:= ");
            double A_Oldal = double.Parse(Console.ReadLine());
            Console.Write(" Kérem adja meg az b oldalt:= ");
            double B_Oldal = double.Parse(Console.ReadLine());
            Console.Write(" Kérem adja meg az c oldalt:= ");
            double C_Oldal = double.Parse(Console.ReadLine());
            double S_Ertek = (A_Oldal + B_Oldal + C_Oldal) / 2;
            double Terulet = Math.Sqrt((S_Ertek * (S_Ertek - A_Oldal) * (S_Ertek - B_Oldal) * (S_Ertek - C_Oldal)));
            Console.WriteLine("Az Ön által megadott háromszög területe: = {0}", Terulet);
        }

        private static void Feladat1()
        {
            Console.WriteLine("1.Feladat");
            int Negyjegyu;
            for (int i =1000; i <= 9999; i++)
            {
                Negyjegyu = i;
                if(Negyjegyu%8==0)
                {
                    if(Negyjegyu%9==0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0} , ", Negyjegyu);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write("{0} , ", Negyjegyu);
                    }
                    Console.Write("{0} , ", Negyjegyu);
                }
            }
        }
    }
}

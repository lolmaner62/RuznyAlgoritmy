﻿using System;
using System.Collections.Generic;
using System.Linq;

/*

Při spuštění se zobrazí nabídka kde bude 9 možností, 8 algoritmů , 9 exit
Vybrána nabídka, zeptá se na počet prvků v poli, poté zobrazí pole, pokud zvolí řadící algoritmus, zobrazí 
seřazené pole, pokud hledací algoritmus, zeptá se na číslo které hledá, poté napíše jestli číslo je nebo ne
zeptá jestli chce pokračovat nebo ne, poté nabídka 卐卐卐卐卐卐卐卐卐卐卐卐卐
Od 0 do 1000
*/






namespace RuznyAlgoritmy
{
    class Program
    {
        
        static bool tocka = true;
        static void Main(string[] args)
        {
            while(tocka)
            {
                switch (ZobrazNabidku())
                {
                    case 1:
                        tocka = Algoritmy.Bez_Zarazky();
                        break;
                    case 2:
                        tocka = Algoritmy.Binarni();
                        break;
                    case 3:
                        tocka = Algoritmy.Naivni();
                        break;
                    case 4:
                        tocka = Algoritmy.Se_Zarazkou();
                        break;
                    case 5: tocka = Algoritmy.Bubble();
                        break;
                    case 6:
                        tocka = Algoritmy.Insert();
                        break;
                    case 7:
                        tocka = Algoritmy.Quick();
                        break;
                    case 8:
                        tocka = Algoritmy.Select();
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    case 69:
                        continue;
                    default:
                        Console.WriteLine("Jak????");
                        break;
                }
            }
            Environment.Exit(0);
            
        }

        static int ZobrazNabidku()
        {
            Console.WriteLine("Hledaci algoritmy: \n1: Bez zarazky \n2: Binarni \n3: Nainvni\n4: Se zarazkou");
            Console.WriteLine("Radici algoritmy:\n5: Bubble sort\n6: Insert\n7:Quick Sort\n8:Select sort \n9: Exit");
            if (int.TryParse(Console.ReadLine(), out int Odpoved))
            { 
                if (Odpoved <= 9 && Odpoved >= 1)
                {
                    return Odpoved;
                }
                else
                {
                    Console.WriteLine("Musi byt ve spravnem rozmezi opicaku");
                    return 69;
                }
            }
            else
            {
                Console.WriteLine("Musis napsat cislo opicaku");
                return 69;
            }
        }

    }
    static public class Algoritmy
    {
        static List<int> Vygeneruj()
        {
            Console.WriteLine("Kolik chcete cisel?");
            int pocet = int.Parse(Console.ReadLine());
            Random rng = new Random();
            List<int> output = new List<int>();
            for (int i = 0; i < pocet; i++)
            {
                output.Add(rng.Next(0, 1001));
                Console.WriteLine(output[i]);
            }

            return output;
        }
        static bool ChcetePokracovat()
        {
            Console.WriteLine("Chcete pokračovat? \n1: Ano \n2: Ne (Nebo cokoliv kromě jedničky :D");
            if (Console.ReadLine() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool Bez_Zarazky()
        {
            List<int> pole = Vygeneruj();
            Console.WriteLine("Ktere cislo hledame:");
            int hledane = int.Parse(Console.ReadLine());
            int nalezene = 0;
            foreach (var item in pole)
            {

                if (item == hledane)
                {
                    nalezene = 1;

                }
            }
            if (nalezene == 1)
            {
                Console.WriteLine("Nalezeno");
            }
            else
            {
                Console.WriteLine("Nenalezeno");
            }
            return ChcetePokracovat();
        }
        static public bool Se_Zarazkou()
        {
            List<int> pole = Vygeneruj();
            Console.WriteLine("Ktere cislo hledame:");
            int hledane = int.Parse(Console.ReadLine());
            int nalezene = 0;
            foreach (var item in pole)
            {

                if (item == hledane)
                {
                    nalezene = 1;
                    break;
                }
            }
            if (nalezene == 1)
            {
                Console.WriteLine("Nalezeno");
            }
            else
            {
                Console.WriteLine("Nenalezeno");
            }
            return ChcetePokracovat();
        }
        static public bool Binarni()
        {
            List<int> pole = Vygeneruj();
            Console.WriteLine("Ktere cislo hledame:");
            int hledane = int.Parse(Console.ReadLine());
            bool nalezene = false;
            pole.Sort();
            int Left = 0;
            int right = pole.Count - 1;
            do
            {
                int stred = (Left + right) / 2;
                if (pole[stred] == hledane)
                {
                    nalezene = true;
                    break;
                }
                if (pole[stred] < hledane)
                {
                    Left = stred + 1;
                }
                else
                {
                    right = stred - 1;
                }

            } while (Left <= right);
            if (nalezene)
            {
                Console.WriteLine("Nalezeno");
            }
            else
            {
                Console.WriteLine("Nenalezeno");
            }

            return ChcetePokracovat();
        }
        static public bool Naivni()
        {
            List<int> pole = Vygeneruj();
            Console.WriteLine("Ktere cislo hledame:");
            int hledane = int.Parse(Console.ReadLine());
            bool nalezene = false;
            for (int i = 0; i < pole.Count; i++)
            {
                if (pole[i] == hledane)
                {
                    nalezene = true;
                    break;
                }


            }
            if (nalezene)
            {
                Console.WriteLine("Nalezeno");
            }
            else
            {
                Console.WriteLine("Nenalezeno");
            }



            return ChcetePokracovat();
        }
        static public bool Bubble()
        {
            List<int> Pole = Vygeneruj();
            Console.WriteLine("Zmackni cokoliv aby si pokrocil :)");
            Console.ReadKey();
            for (int i = 0; i < (Pole.Count - 1); i++)
            {
                for (int j = 0; j < (Pole.Count - 1 - i); j++)
                {
                    if (Pole[j] > Pole[j + 1])
                    {
                        int pom = Pole[j];
                        Pole[j] = Pole[j + 1];
                        Pole[j + 1] = pom;
                    }
                }
            }
            foreach (var item in Pole)
            {
                Console.WriteLine(item);
            }
            return ChcetePokracovat();
        }
        static public bool Insert()
        {
            List<int> Pole = Vygeneruj();
            Console.WriteLine("Zmackni cokoliv aby si pokrocil :)");
            Console.ReadKey();
            for (int i = 1; i < Pole.Count; i++)
            {
                var ins = Pole[i];
                var j = i - 1;
                while ((j >= 0) && (Pole[j] > ins))
                {
                    Pole[j + 1] = Pole[j];
                    j--;
                }
                Pole[j + 1] = ins;
            }
            foreach (var item in Pole)
            {
                Console.WriteLine(item);
            }
            return ChcetePokracovat();
        }
        public static bool Quick()
        {
            List<int> Pole = Vygeneruj();
            Console.WriteLine("Zmackni cokoliv aby si pokrocil :)");
            Console.ReadKey();
            Pole = quicksort(0, Pole.Count - 1, Pole);

            foreach (var item in Pole)
            {
                Console.WriteLine(item);
            }
            return ChcetePokracovat();

        }
        private static List<int> quicksort(int l, int r, List<int> Pole)
        {
            int i = l;
            int j = r;
            int pivot = Pole[((l + r) / 2)];
            do
            {
                while (Pole[i] < pivot) i++;
                while (Pole[j] > pivot) j--;
                if (i <= j)
                {
                    var pom = Pole[i];
                    Pole[i] = Pole[j];
                    Pole[j] = pom;
                    i++; j--;
                }
            }
            while (i < j);
            if ((j - l) > 0) quicksort(l, j, Pole);
            if ((r - i) > 0) quicksort(i, r, Pole);

            return Pole;

        }
        public static bool Select()
        {
            List<int> Pole = Vygeneruj();
            Console.WriteLine("Zmackni cokoliv aby si pokrocil :)");
            Console.ReadKey();


            for (int i = 0; i < Pole.Count - 1; i++)
            {
                var max_pos = Pole.Count - 1 - i;
                for (int j = 0; j < Pole.Count - i; j++)
                {
                    if (Pole[j] > Pole[max_pos])
                    {
                        max_pos = j;
                    }
                }
                var pom = Pole[Pole.Count - 1 - i];
                Pole[Pole.Count - 1 - i] = Pole[max_pos];
                Pole[max_pos] = pom;
            }

            foreach (var item in Pole)
            {
                Console.WriteLine(item);
            }

            return ChcetePokracovat();
        }

    }
}

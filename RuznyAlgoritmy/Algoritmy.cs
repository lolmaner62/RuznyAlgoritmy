using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RuznyAlgoritmy
{
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
                output[i] = rng.Next(0, 1001);
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
            int nalezene = 0;
            pole.Sort();
            int Left = 0;
            int right = pole.Count;

            return ChcetePokracovat();
        }

    }
}

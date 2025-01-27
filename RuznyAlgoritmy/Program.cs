using System;

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
}

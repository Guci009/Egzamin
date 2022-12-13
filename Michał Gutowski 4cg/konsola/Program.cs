using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[10];
            Console.WriteLine("Podaj po kolei 10 liczb do tablicy");
            for (int i = 0; i < 10; i++)
            {
                tablica[i] = int.Parse(Console.ReadLine());
            }

            Tablice tablica1 = new Tablice();
            tablica1.tablica = tablica;
            tablica1.Posortuj();

            Console.WriteLine("Kliknij dowolny klawisz by zamknąć program");
            Console.ReadKey();
            
        }

        class Tablice
        {
            public int[] tablica;

            private int ZnajdzMaksymalna()
            {
                int maks = int.MinValue;

                for (int i = 0; i < 10; i++)
                {
                    if (tablica[i] > maks) maks = tablica[i];
                }

                return maks;
            }


            /********************************************************
            * nazwa funkcji: <Posortuj>
            * parametry wejściowe: <Brak>
            * wartość zwracana: <Nic nie zwraca, funkcja wypisuje na console wynik>
            * autor: <Michał Gutowski 4CG>
            * ****************************************************/
            public void Posortuj()
            {
                int min, pomoc;
                for (int i = 0; i < 10; i++)
                {
                    min = i;
                    for (int j = i; j < 10; j++)
                    {
                        if (tablica[j] < tablica[min]) min = j;
                    }
                    pomoc = tablica[min];
                    tablica[min] = tablica[i];
                    tablica[i] = pomoc;
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(tablica[i]);
                }
            }
        }
    }
}

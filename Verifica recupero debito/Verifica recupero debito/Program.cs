using System;
using System.Threading;
using System.Threading.Tasks;

namespace Verifica_recupero_debito
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Somma));
            Thread t2 = new Thread(new ThreadStart(Ciclo));
            Thread t3 = new Thread(new ThreadStart(Stampa));

            t1.Start();
            t2.Start();
            t3.Start();

            static void Somma()
            {
                int add1 = 10;
                int add2 = 20;
                int somma;

                Console.WriteLine("inizio thread 1");
                for(int i =0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    somma = add1 + add2;
                    Console.WriteLine("somma è " + somma);

                }
                Console.WriteLine("fine thread 1");
            }

            static void Ciclo()
            {
                int tabellina;
                Console.WriteLine("inizio thread 2");
                for(int i=0; i < 10; i++)
                {
                    Thread.Sleep(10);
                    tabellina = 70 * i;
                    Console.WriteLine($"tabellina del 70 x{i} = " + tabellina);
                }
                Console.WriteLine("fine thread 2");
            }



        }
    }
}

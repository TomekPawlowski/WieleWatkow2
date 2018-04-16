using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WieleWatkow2
{
    class Program
    {
        static int[] tablica = { 0, 1, 0, 1, 0, 10, 01, 110, 01, 0, 10, 000, 01, 101, 00, 11, 01, 001, 0101, 010, 10, 1, 10, 101, 01, 011, 01, 110, 0, 1, 0, 1, 00, 1, 0, 1, 01, 01, 10, 11, 01, 0, 01, 0101, 1, 1, 0 };

        static void Main(string[] args)
        {

           
         Task task1 = new Task(new Action(printSign1));
         Task task2 = new Task(new Action(printSign2));
            Task task3 = new Task(new Action(printSign3));
            Task task4 = new Task(new Action(printSign4));
            Task task5 = new Task(new Action(printSign5));
            Task task6 = new Task(new Action(printSign6));
            Task task7 = new Task(new Action(printSign7));
            Task task8 = new Task(new Action(printSign8));
            Task task9 = new Task(new Action(printSign9));
            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();
            task5.Start();
            task6.Start();
            task7.Start();
            task8.Start();
            task9.Start();

            Console.ReadLine();
        }

        public static void printSign1()

        {

            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                
                Console.SetCursorPosition(0, i);
                Console.ForegroundColor = (System.ConsoleColor.Green);
                Console.WriteLine(tablica[rand.Next(0,30)+1]);
                System.Threading.Thread.Sleep(250);



            }
        }

        public static void printSign2()

        {

            Random rand2 = new Random();
            for (int i = 0; i < 50; i++)
            {

                Console.SetCursorPosition(5, i);
                Console.ForegroundColor = (System.ConsoleColor.Green);
                Console.WriteLine(tablica[rand2.Next(0,25)+2]);
                System.Threading.Thread.Sleep(300);



            }
        }

        public static void printSign3()

        {

            Random rand3 = new Random();
            for (int i = 0; i < 50; i++)
            {

                Console.SetCursorPosition(10, i);
                Console.ForegroundColor = (System.ConsoleColor.Green);
                Console.WriteLine(tablica[rand3.Next(0, 20) + 4]);
                System.Threading.Thread.Sleep(200);



            }
        }

        public static void printSign4()

        {

            Random rand4 = new Random();
            for (int i = 0; i < 50; i++)
            {

                Console.SetCursorPosition(15, i);
                Console.ForegroundColor = (System.ConsoleColor.Green);
                Console.WriteLine(tablica[rand4.Next(0, 30) + 5]);
                System.Threading.Thread.Sleep(250);



            }
        }

        public static void printSign5()

        {

            Random rand5 = new Random();
            for (int i = 0; i < 50; i++)
            {

                Console.SetCursorPosition(20, i);
                Console.ForegroundColor = (System.ConsoleColor.Green);
                Console.WriteLine(tablica[rand5.Next(0, 30) + 6]);
                System.Threading.Thread.Sleep(300);



            }
        }

        public static void printSign6()

        {

            Random rand6 = new Random();
            for (int i = 0; i < 50; i++)
            {

                Console.SetCursorPosition(25, i);
                Console.ForegroundColor = (System.ConsoleColor.Green);
                Console.WriteLine(tablica[rand6.Next(0, 30) + 7]);
                System.Threading.Thread.Sleep(200);



            }
        }

        public static void printSign7()

        {

            Random rand7 = new Random();
            for (int i = 0; i < 50; i++)
            {

                Console.SetCursorPosition(30, i);
                Console.ForegroundColor = (System.ConsoleColor.Green);
                Console.WriteLine(tablica[rand7.Next(0, 20) + 7]);
                System.Threading.Thread.Sleep(150);



            }
        }

        public static void printSign8()

        {

            Random rand8 = new Random();
            for (int i = 0; i < 50; i++)
            {

                Console.SetCursorPosition(35, i);
                Console.ForegroundColor = (System.ConsoleColor.Green);
                Console.WriteLine(tablica[rand8.Next(0, 25) + 8]);
                System.Threading.Thread.Sleep(200);



            }
        }

        public static void printSign9()

        {

            Random rand9 = new Random();
            for (int i = 0; i < 50; i++)
            {

                Console.SetCursorPosition(40, i);
                Console.ForegroundColor = (System.ConsoleColor.Green);
                Console.WriteLine(tablica[rand9.Next(0, 15) + 9]);
                System.Threading.Thread.Sleep(150);



            }
        }

    }
}

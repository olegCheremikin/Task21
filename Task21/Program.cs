using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task21
{
    public class Garden
    {
        const int a = 5;
        const int b = 5;
        int[,] location = new int[a, b];
        public void Gardener1()
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (location[i, j] == 0)
                    {
                        location[i, j] = 1;
                        Thread.Sleep(1);
                    }
                }
            }
        }
        public void Gardener2()
        {
            for (int j = b - 1; j > -1; j--)
            {
                for (int i = a - 1; i > -1; i--)
                {
                    if (location[i, j] == 0)
                    {
                        location[i, j] = 2;
                        Thread.Sleep(1);
                    }
                }
            }
        }
        public void Rezult()
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(" {0}", location[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();
            ThreadStart threadStart = new ThreadStart(garden.Gardener1);
            Thread thread = new Thread(threadStart);
            thread.Start();
            garden.Gardener2();
            garden.Rezult();
            Console.ReadKey();
        }
    }
}


using System;
using System.Linq;
using System.Collections.Generic;

namespace задача_codewars
{
    class Program
    {

        static void Too(int[][] shoes, ref int i, ref double count)
        {
            int size1;

            int size2;

            for (int q = i + 1; q < shoes.Length; q++)
            {
                if (shoes[i][1] == shoes[q][1])
                {
                    size1 = shoes[i][0];
                    size2 = shoes[q][0];

                    if ((size1 + 1) == size2)
                    {
                        count++;
                    }
                    else if ((size2 + 1) == size1)
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
        }

        static void Roo(int[][] shoes, ref double count)
        {
            for (int i = 0; i < shoes.Length; i++)
            {
                Too(shoes, ref i, ref count);
            }

        }

        static bool Eoo()
        {

            double count = 0;

            //Random random = new Random();

            //int[][] shoes = new int[random.Next(3,4)][];

            //for (int i = 0; i < shoes.Length; i++)
            //{
            //    shoes[i] = new int[2] { random.Next(0, 2), random.Next(17, 20) };
            //}

            //for (int i = 0; i < shoes.Length; i++)
            //{
            //    for (int q = 0; q<shoes[i].Length; q++)
            //    {
            //        Console.Write(" " + shoes[i][q]);;

            //    }
            //    Console.WriteLine();
            //}

            int[][] shoes = new int[10][];

            shoes[0] = new int[2] { 0, 1 };
            shoes[1] = new int[2] { 0, 69 };
            shoes[2] = new int[2] { 1, 69 };
            shoes[3] = new int[2] { 0, 42 };
            shoes[4] = new int[2] { 0, 69 };
            shoes[5] = new int[2] { 0, 62 };
            shoes[6] = new int[2] { 1, 62 };
            shoes[7] = new int[2] { 1, 69 };
            shoes[8] = new int[2] { 1, 42 };
            shoes[9] = new int[2] { 1, 1 };


            Roo(shoes, ref count);

            if (count >= ((double)shoes.Length / 2) && shoes.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            if (Eoo())
            {
                Console.WriteLine("Пара найдена!");
            }
            else
            {
                Console.WriteLine("Пары нет!");
            }

            Console.ReadLine();
        }
    }
}

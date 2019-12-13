using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кувшины
{
    class Program
    {
        static bool flag = true;
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        static void transfusion(int big_cup, int small_cup, int total, List<int> path_max, List<int> path_min)
        {
            if (!flag)
            {
                return;
            }
            if (path_max.Last() == big_cup && path_min.Last() == 0)
            {
                flag = false;
                return;
            }

        }
        static void Main(string[] args)
        {
            int big_cup, small_cup, total;
            Console.WriteLine("Введите объем большего кувшина");
            big_cup = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем меньшего кувшина");
            small_cup = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество воды, которое нужно оставить в кувшине наибольшего объема");
            total = int.Parse(Console.ReadLine());
            List<int> path_max = new List<int>();
            List<int> path_min = new List<int>();
            path_min.Add(0);
            path_max.Add(0);
            if (total > big_cup && total > small_cup)
            {
                //Console.WriteLine("Impossible");
                flag = false;
            }
            else if (big_cup == small_cup && total % big_cup != 0)
            {
                //Console.WriteLine("Impossible");
                flag = false;
            }
            else if (big_cup == total)
            {
                path_max.Add(0);
                path_max.Add(total);
            }
            else if (small_cup == total)
            {
                path_min.Add(total);
                path_max.Add(0);
                path_min.Add(0);
                path_max.Add(total);
            }
            else
            {

            }
            Console.Write("большой кувшин: ");
            Console.Write("маленький кувшин:   ");
            Console.WriteLine();
            for (int i = 0; i < path_max.Count; i++)
            {
                Console.Write(path_min[i] + "            " + path_max[i]);
                Console.WriteLine();
            }
        }
    }
}

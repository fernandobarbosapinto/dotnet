using System;
using System.Collections.Generic;
using Course.Entities;

namespace CourseExampleConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("NOTEBOOK", 1200.00));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("NOTEBOOK", 1200.00);
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));

            //Quando o tipo é struct ele faz a comparação por conteúdo e não por referencia de memória.

            /*
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("TV"));

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}

using System;
using System.Collections.Generic;

namespace CourseExampleConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("TV"));

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}

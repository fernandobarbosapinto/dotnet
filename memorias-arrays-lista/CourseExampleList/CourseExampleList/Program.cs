using System;
using System.Collections.Generic;

namespace CourseExampleList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");
            lista.Insert(2, "Marco");

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Quantidade da lista: {lista.Count}");

            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine($"Primeiro nome com a letra 'A' {s1}");

            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Ultimo nome com a letra 'A': {s2}");

            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);
            
            List<string> list2 = lista.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");
            
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            
            lista.Remove("Alex");
            Console.WriteLine("---------------------");
            
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            
            lista.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------");
            
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

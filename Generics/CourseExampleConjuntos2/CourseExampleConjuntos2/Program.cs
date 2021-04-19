using System;
using System.Collections.Generic;

namespace CourseExampleConjuntos2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> myListA = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> myListB = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // PrintCollection(myListA);

            //UNION
            SortedSet<int> myListC = new SortedSet<int>(myListA);
            myListC.UnionWith(myListB);

            PrintCollection(myListC);

            //INTERSECTION
            SortedSet<int> myListD = new SortedSet<int>(myListA);
            myListD.IntersectWith(myListB);

            PrintCollection(myListD);

            //DIFFERENCE
            SortedSet<int> myListE = new SortedSet<int>(myListA);
            myListE.ExceptWith(myListB);

            PrintCollection(myListE);
        }

        static void PrintCollection<T>(IEnumerable<T> collection){
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using Course.Extensions;

namespace CourseExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 04, 20, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string txt = "Good morning dear students";
            Console.WriteLine(txt.Cut(10));
        }
    }
}

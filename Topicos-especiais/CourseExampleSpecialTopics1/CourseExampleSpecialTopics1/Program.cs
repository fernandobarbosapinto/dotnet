using System;

namespace CourseExampleSpecialTopics1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    Sintaxe alternativa: switch-case
                    Estrutura opcional a vários if-else encadeados, quando a condição envolve o teste
                    do valor de uma variável.
             */

            Console.WriteLine("Digite um valor inteiro de 1 à 7:");
            int x = int.Parse(Console.ReadLine());
            string day;

            /*Solução usando if e else*/
            if (x == 1)
            {
                day = "Sunday";
            }
            else if (x == 2)
            {
                day = "Monday";
            }
            else if (x == 3)
            {
                day = "Tuesday";
            }
            else if (x == 4)
            {
                day = "Wednesday";
            }
            else if (x == 5)
            {
                day = "Thursday";
            }
            else if (x == 6)
            {
                day = "Friday";
            }
            else if (x == 7)
            {
                day = "Saturday";
            }
            else
            {
                day = "Invalid value";
            }
            Console.WriteLine($"Weekday: {day}");

            /* Solução utilizando switch case*/
            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine($"Weekday: {day}");
        }
    }
}

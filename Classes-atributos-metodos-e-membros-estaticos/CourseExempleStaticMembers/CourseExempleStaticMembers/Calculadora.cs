using System;

namespace CourseExempleStaticMembers
{
    class Calculadora
    {
        public double Pi = 3.14;

        public double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        public double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }
    }
}

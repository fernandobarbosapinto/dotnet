using System;
using System.Collections.Generic;
using System.Text;

namespace FixationExerciseClassesAtributos3
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3, Nota4;

        public double NotaFinal()
        {
            return (Nota1 + Nota2 + Nota3 + Nota4) / 4;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courser
{
    internal class ClasseNotaAluno
    {
        public string Nome;
        public double NotaA;
        public double NotaB;
        public double NotaC;
        

        public double Media()
        {
            return  NotaA + NotaB  + NotaC;
        }
        public double NotaFalta()
        {
            return  60.00 - Media();
        }
    }
}

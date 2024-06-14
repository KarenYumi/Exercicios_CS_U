using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courser
{
    class ClasseDadosFuncionarios
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario + (Salario * porcentagem / 100.00);
        }

        public override string ToString()
        {
            return Nome + ", R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

﻿namespace Courser.Retangulo
{
    class ClasseRetangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2.00 * (Largura + Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Largura* Largura + Altura* Altura);
        }


    }
}

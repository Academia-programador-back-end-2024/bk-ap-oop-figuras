using System;

namespace FigurasGeometricasBkAp2024
{

    //Herança
    public class Quadrado : FiguraGeometrica
    {
        public Quadrado(int lado)
        {
            Lados = new int[2];
            Lados[0] = lado;
            Lados[1] = lado;
        }

        public override decimal CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
    }
}
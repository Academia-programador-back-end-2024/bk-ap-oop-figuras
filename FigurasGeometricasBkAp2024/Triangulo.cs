using System;

namespace FigurasGeometricasBkAp2024
{

    public class Triangulo : FiguraGeometrica
    {
        private string corpoMensagem = "é um triângulo {0}";

        private bool IsEquilatero
        {
            get
            {
                return
                    Lados[0] == Lados[1] &&
                    Lados[0] == Lados[2] &&
                    Lados[1] == Lados[2];
            }
        }

        private bool IsIsosceles
        {
            get
            {
                return (Lados[0] == Lados[1] && Lados[0] != Lados[2]) ||
                       (Lados[0] != Lados[1] && Lados[1] == Lados[2]) ||
                       (Lados[0] != Lados[1] && Lados[0] == Lados[2]);
            }
        }

        private bool IsEscaleno
        {
            get
            {
                return (Lados[0] != Lados[1] && Lados[0] != Lados[2]) ||
                       (Lados[0] != Lados[1] && Lados[1] != Lados[2]) ||
                       (Lados[0] != Lados[1] && Lados[0] != Lados[2]);
            }
        }

        public Triangulo(int ladoX, int ladoY, int ladoZ)
        {
            Lados = new int[3];
            Lados[0] = ladoX;
            Lados[1] = ladoY;
            Lados[2] = ladoZ;
        }

        public string MensagemTipoDeTriangulo()
        {
            if (IsEquilatero)
            {
                return string.Format(corpoMensagem, "equilátero");
            }
            if (IsIsosceles)
            {
                return string.Format(corpoMensagem, "isósceles");
            }
            if (IsEscaleno)
            {
                return string.Format(corpoMensagem, "escaleno");
            }
            return string.Empty;
        }

        public override decimal CalcularArea()
        {

            if (IsEquilatero)
            {
                //TODO
            }
            if (IsIsosceles)
            {
                //TODO
            }
            if (IsEscaleno)
            {
                //TODO
            }
            //UM calculo não é real.
            return base.CalcularArea() / 2;
        }

        public override decimal CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
    }
}
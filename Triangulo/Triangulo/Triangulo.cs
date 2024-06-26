using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    public class Triangulo
    {
        private const string EQUILATERO = "Triângulo Equilátero";
        private const string ISOSCELES = "Triângulo Isósceles";
        private const string ESCALENO = "Triângulo Escaleno";

        public bool isEquilatero
        { get
            {
                return lado1 == lado2 && lado1 == lado3;
            }
        }

        public bool isIsosceles
        {
            get
            {
                bool verifica12 = lado1 == lado2 ? true : false;
                bool verifica13 = lado1 == lado3 ? true : false;
                bool verifica23 = lado2 == lado3 ? true : false;

                return (verifica12 && !verifica13) || (!verifica12 && verifica13) || (!verifica13 && verifica23);
            }
        }

        public bool isEscanelo
        {
            get
            {
                bool verifica12 = lado1 == lado2 ? true : false;
                bool verifica13 = lado1 == lado3 ? true : false;
                bool verifica23 = lado2 == lado3 ? true : false;

                return !verifica12 && !verifica13 && !verifica23;
            }
        }

        public bool isInicializado = false;

        public decimal lado1;
        public decimal lado2;
        public decimal lado3;

        public string tipo;

        public Triangulo(decimal lado1, decimal lado2, decimal lado3)
        {
            bool possivel = trianguloPossivel(lado1, lado2, lado3);

            if (possivel)
            {
                this.lado1 = lado1;
                this.lado2 = lado2;
                this.lado3 = lado3;

                isInicializado = true;
            } else
            {
                Console.WriteLine("Não é possível criar um triângulo com essas medidas\n" +
                    "O lado do triängulo precisa ser menor que a soma dos outros 2!\n\n");
            }
            tipo = verificaTriangulo();
        }

        private bool trianguloPossivel(decimal lado1, decimal lado2, decimal lado3)
        {

            bool verificaLado1 = lado1 < lado2 + lado3 ? true : false;
            bool verificaLado2 = lado2 < lado1 + lado3 ? true : false;
            bool verificaLado3 = lado3 < lado1 + lado2 ? true : false;

            if (verificaLado1 && verificaLado2 && verificaLado3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string verificaTriangulo()
        {
            if (isInicializado)
            {
               
                if (isEquilatero)
                {
                    return EQUILATERO;
                }

                if (isIsosceles)
                {
                    return ISOSCELES;
                }
                if (isEscanelo)
                {
                    return ESCALENO;
                }

                return "Não achado triângulo";

            } else
            {
                return "Triângulo não inicializado";
            }
            
        }
    }
}

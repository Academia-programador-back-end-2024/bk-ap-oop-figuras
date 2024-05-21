namespace FigurasGeometricasTest
{
    //Métodos:
    //CalcularArea() (virtual): Retorna a área da figura.
    //CalcularPerimetro() (virtual): Retorna o perímetro da figura.

    public abstract class FiguraGeometrica
    {
        public int[] Lados { get; set; }
        public virtual decimal CalcularArea()
        {
            decimal area = 1;
            foreach (var item in Lados)
            {
                area *= item;
            }
            return area;
        }

        public abstract decimal CalcularPerimetro();
    }

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

    public class TrianguloTest
    {
        /// <summary>
        /// Dados três valores X, Y, Z, 
        /// verifique se eles podem ser os comprimentos dos lados de um triângulo 
        ///e, se forem, escreva uma mensagem informando se é um triângulo
        ///equilátero, 
        ///isósceles ou 
        ///escaleno.

        //        Observações:

        //O comprimento de um lado do triângulo é sempre menor do que a soma dos outros dois.

        //- Equilátero: Todos os lados iguais.
        //- Isósceles: Dois lados iguais.
        //- Escaleno: Todos os lados diferentes.
        /// </summary>
        /// Behavior Driven Development
        /// Test Driven Development 

        [Fact]
        public void Deve_Verificar_Que_O_Triangulo_É_Equilatero()
        {
            //Arrange - Preparar

            int x = 5, y = 5, z = 5;
            string mensagemEsperada = "é um triângulo equilátero";
            string mensagemResultado = string.Empty;
            Triangulo triangulo = new Triangulo(x, y, z);

            //A - Act - Ação            
            mensagemResultado = triangulo.MensagemTipoDeTriangulo();

            //A - Assert - Verificar
            Assert.StrictEqual(mensagemEsperada, mensagemResultado);
        }

        [Theory]
        [InlineData(5, 5, 4)]
        [InlineData(4, 5, 4)]
        [InlineData(4, 4, 5)]
        [InlineData(4, 5, 5)]
        public void Deve_Verificar_Que_O_Triangulo_É_Isósceles(int x, int y, int z)
        {
            //Arrange - Preparar
            string mensagemEsperada = "é um triângulo isósceles";
            string mensagemResultado = string.Empty;
            Triangulo triangulo = new Triangulo(x, y, z);

            //A - Act - Ação            
            mensagemResultado = triangulo.MensagemTipoDeTriangulo();

            //A - Assert - Verificar
            Assert.StrictEqual(mensagemEsperada, mensagemResultado);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(5, 4, 3)]
        [InlineData(4, 5, 3)]
        public void Deve_Verificar_Que_O_Triangulo_É_Escaleno(int x, int y, int z)
        {
            //Arrange - Preparar
            string mensagemEsperada = "é um triângulo escaleno";
            string mensagemResultado = string.Empty;
            Triangulo triangulo = new Triangulo(x, y, z);

            //A - Act - Ação            
            mensagemResultado = triangulo.MensagemTipoDeTriangulo();

            //A - Assert - Verificar
            Assert.StrictEqual(mensagemEsperada, mensagemResultado);
        }
    }

    public class FiguraGeometricaTest
    {
        [Fact]
        public void Deve_Calcular_Area_De_Uma_Figura()
        {

            FiguraGeometrica quadrado = new Quadrado(10);

            var area = quadrado.CalcularArea();

            Assert.Equal(100, area);

        }

        [Fact]
        public void Deve_Calcular_Area_De_Uma_Figura_Triangulo()
        {

            FiguraGeometrica triangulo = new Triangulo(10, 10, 10);

            var area = triangulo.CalcularArea();

            Assert.Equal(500, area);

        }
    }
}
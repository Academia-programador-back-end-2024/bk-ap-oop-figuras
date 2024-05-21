namespace FigurasGeometricasTest
{
    //M�todos:
    //CalcularArea() (virtual): Retorna a �rea da figura.
    //CalcularPerimetro() (virtual): Retorna o per�metro da figura.

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

    //Heran�a
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
        private string corpoMensagem = "� um tri�ngulo {0}";

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
                return string.Format(corpoMensagem, "equil�tero");
            }
            if (IsIsosceles)
            {
                return string.Format(corpoMensagem, "is�sceles");
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
            //UM calculo n�o � real.
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
        /// Dados tr�s valores X, Y, Z, 
        /// verifique se eles podem ser os comprimentos dos lados de um tri�ngulo 
        ///e, se forem, escreva uma mensagem informando se � um tri�ngulo
        ///equil�tero, 
        ///is�sceles ou 
        ///escaleno.

        //        Observa��es:

        //O comprimento de um lado do tri�ngulo � sempre menor do que a soma dos outros dois.

        //- Equil�tero: Todos os lados iguais.
        //- Is�sceles: Dois lados iguais.
        //- Escaleno: Todos os lados diferentes.
        /// </summary>
        /// Behavior Driven Development
        /// Test Driven Development 

        [Fact]
        public void Deve_Verificar_Que_O_Triangulo_�_Equilatero()
        {
            //Arrange - Preparar

            int x = 5, y = 5, z = 5;
            string mensagemEsperada = "� um tri�ngulo equil�tero";
            string mensagemResultado = string.Empty;
            Triangulo triangulo = new Triangulo(x, y, z);

            //A - Act - A��o            
            mensagemResultado = triangulo.MensagemTipoDeTriangulo();

            //A - Assert - Verificar
            Assert.StrictEqual(mensagemEsperada, mensagemResultado);
        }

        [Theory]
        [InlineData(5, 5, 4)]
        [InlineData(4, 5, 4)]
        [InlineData(4, 4, 5)]
        [InlineData(4, 5, 5)]
        public void Deve_Verificar_Que_O_Triangulo_�_Is�sceles(int x, int y, int z)
        {
            //Arrange - Preparar
            string mensagemEsperada = "� um tri�ngulo is�sceles";
            string mensagemResultado = string.Empty;
            Triangulo triangulo = new Triangulo(x, y, z);

            //A - Act - A��o            
            mensagemResultado = triangulo.MensagemTipoDeTriangulo();

            //A - Assert - Verificar
            Assert.StrictEqual(mensagemEsperada, mensagemResultado);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(5, 4, 3)]
        [InlineData(4, 5, 3)]
        public void Deve_Verificar_Que_O_Triangulo_�_Escaleno(int x, int y, int z)
        {
            //Arrange - Preparar
            string mensagemEsperada = "� um tri�ngulo escaleno";
            string mensagemResultado = string.Empty;
            Triangulo triangulo = new Triangulo(x, y, z);

            //A - Act - A��o            
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
using FigurasGeometricasBkAp2024;

namespace FigurasGeometricasTest;



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
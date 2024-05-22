using FigurasGeometricasBkAp2024;

namespace FigurasGeometricasTest;



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
//# Atividade OOP

//Dados três valores X, Y, Z, verifique se eles podem ser os comprimentos dos lados de um triângulo e,
//se forem, escreva uma mensagem informando se é um triângulo equilátero, isósceles ou escaleno.

//Observações:

//O comprimento de um lado do triângulo é sempre menor do que a soma dos outros dois.

//- Equilátero: Todos os lados iguais.
//- Isósceles: Dois lados iguais.
//- Escaleno: Todos os lados diferentes.

using System;

public class Triangulo
{
    const EQUILATERO = "Triângulo Equilátero";
    const ISOSCELES = "Triângulo Isósceles";
    const ESCALENO = "Triângulo Escaleno";
    public decimal lado1;
    public decimal lado2;
    public decimal lado3;

    public Triangulo(decimal lado1, decimal lado2, decimal lado3)
    {
        bool trianguloPossivel = trianguloPossivel(lado1, lado2, lado3);

        if (trianguloPossivel)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }
    }

    private bool trianguloPossivel(decimal lado1, decimal lado2, decimal lado3)
    {

        bool verificaLado1 = lado1 < lado2 + lado3 ? true : false;
        bool verificaLado2 = lado2 < lado1 + lado3 ? true : false;
        bool verificaLado3 = lado3 < lado1 + lado2 ? true : false;

        if (verificaLado1 && verificaLado2 && verificaLado3)
        {
            return true;
        } else
        {
            return false;
        }
    }

    public string verificaTriangulo()
    {
        bool verifica12 = lado1 == lado2 ? true : false;
        bool verifica13 = lado1 == lado3 ? true : false;
        bool verifica23 = lado2 == lado3 ? true : false;
        if (verifica12 && verifica13)
        {
            return EQUILATERO;
        }

        if ((verifica12 && !verifica13) || (!verifica12 && verifica13) || (!verifica13 && verifica23))
        {
            return ISOSCELES;
        }
        if (!verifica12 && !verifica13 && !verifica23)
        {
            return ESCALENO;
        }
    }
}

public class Principal
{
    static void main(string[] args)
    {
        Triangulo triangulo = new Triangulo(2, 2, 2);

        Console.WriteLine(triangulo.verificaTriangulo());
    }
}
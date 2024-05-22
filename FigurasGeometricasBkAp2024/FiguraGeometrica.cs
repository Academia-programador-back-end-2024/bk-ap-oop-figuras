namespace FigurasGeometricasBkAp2024
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
}
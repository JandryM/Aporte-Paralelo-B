using System;
namespace AporteB
{
    class Program
    {
        public static void Main (string[]args)
        {
            Cuadrado cuadrado = new Cuadrado("Cuadrado","Azul");
            cuadrado.Imprimir();
            
            Rectangulo rectangulo = new Rectangulo("Rectangulo", "Cafe");
            rectangulo.Imprimir();
            
            Circulo circulo = new Circulo("Circulo", "Violeta");
            circulo.Imprimir();
            
            List<Figura> listafiguras= new List<Figura>();
            listafiguras.Add(cuadrado);
            listafiguras.Add(rectangulo);
            listafiguras.Add(circulo);

            foreach(Figura item in listafiguras)
            {   
                item.Calcular();
            }
        }
    }
}


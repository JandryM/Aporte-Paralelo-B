using System;
namespace AporteB
{
      abstract class Figura
    {
        public string Nombre {get;set;}
        public string Color {get;set;}
        public void Imprimir()
        {
            Console.WriteLine("El nombre de la figura es: "+ Nombre+ " \n Y su color es: " +Color);
        }
        public abstract void Calcular();
    }
}
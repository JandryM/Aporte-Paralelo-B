using System;
namespace AporteB
{
    class Cuadrado: Figura
    {
        int lados {get;set;}
        public Cuadrado(string Nombre, string Color)
        {
            this.Nombre= Nombre;
            this.Color= Color;
        }
        public override void Calcular()
        {
            int total;
            Console.WriteLine("Ingrese el valor de los lados del cuadrado: ");
            lados= int.Parse(Console.ReadLine());
            total=lados*4;
            Console.WriteLine("El area del cuadrado es: "+ total);
        }
    }
}
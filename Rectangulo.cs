using System;
namespace AporteB
{
    class Rectangulo:Figura
    {
        int Base {get;set;}
        int Altura {get;set;}
        public Rectangulo(string Nombre, string Color)
        {
            this.Nombre= Nombre;
            this.Color= Color;
        }
        public override void Calcular()
        {
            int total;
            Console.WriteLine("Ingrese la base del rectangulo: ");
            Base= int.Parse (Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo: ");
            Altura= int.Parse(Console.ReadLine());
            total= Base*Altura;
            Console.WriteLine("El area del RECTANGULO es: "+ total);
        }
    }
}
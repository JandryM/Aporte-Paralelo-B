using System;
namespace AporteB
{
    class Circulo:Figura
    {
        double pi= 3.1416;
        double radio {get;set;}
        public Circulo(string Nombre, string Color)
        {
            this.Nombre= Nombre;
            this.Color= Color;
        }
        public override void Calcular()
        {
            double total;
            Console.WriteLine("Ingrese el radio del circulo: ");
            radio= double.Parse(Console.ReadLine());
            total= pi*Math.Pow(radio,2);
            Console.WriteLine("El area del CIRCULO es: "+ total);
        }
    }
}
// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaración variablaes
            //Clases

            Console.WriteLine("CALCULO DE AREA Y PERIMETRO DE UN TRIANGULO");

            //SE SOLICITA EL INGRESO DE LOS 8 PUNTOS PARA REALIZAR LAS OPERACIONES
            Console.WriteLine("Ingrese Valor X1");
            string? valor1 = Console.ReadLine();

            
            Console.WriteLine("Ingrese Valor Y1");
            string? valor2 = Console.ReadLine();

            
            Console.WriteLine("Ingrese Valor X2");
            string? valor3 = Console.ReadLine();

           
            Console.WriteLine("Ingrese Valor Y2");
            string? valor4 = Console.ReadLine();

            
            Console.WriteLine("Ingrese Valor X3");
            string? valor5 = Console.ReadLine();

           
            Console.WriteLine("Ingrese Valor Y3");
            string? valor6 = Console.ReadLine();

            
            Console.WriteLine("Ingrese Valor X4");
            string? valor7 = Console.ReadLine();

            
            Console.WriteLine("Ingrese Valor Y4");
            string? valor8 = Console.ReadLine();

            //SE ASIGNAN LOS VALORES X y Y A CADA VERTICE (CLASE VERTICE)
            Vertice v1 = new Vertice
            {
                x = Int32.Parse(valor1), 
                y = Int32.Parse(valor2)
            };
            Vertice v2 = new Vertice
            {
                x = Int32.Parse(valor3),
                y = Int32.Parse(valor4)
            };
            Vertice v3 = new Vertice
            {
                x = Int32.Parse(valor5),
                y = Int32.Parse(valor6)
            };
            Vertice v4 = new Vertice
            {
                x = Int32.Parse(valor7),
                y = Int32.Parse(valor8)
            };

            //SE ASIGNAN LOS VERTICES AL RECTÁNGULO (CLASE RECTANGULO)
            Rectangulo rectangulo = new Rectangulo();

            rectangulo.v1 = v1;
            rectangulo.v2 = v2;
            rectangulo.v3 = v3;
            rectangulo.v4 = v4;
            
            //SE MUESTRAN LOS RESULTADOS
            Console.WriteLine("El area del rectangulo es: " + rectangulo.GetAreaRectangulo() + "u^2");
            Console.WriteLine("El perimetro del rectangulo es: " + rectangulo.GetPerimetroRectangulo() + "u");


            Console.Read();

        }
    }
}

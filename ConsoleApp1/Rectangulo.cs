using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangulo
    {
        public Vertice v1 { get; set; }
        public Vertice v2 { get; set; }
        public Vertice v3 { get; set; }
        public Vertice v4 { get; set; }

        public double area { get; set; }
        public double perimetro { get; set; }

        public double GetAreaRectangulo()
        {
            double baseTriangulo = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + Math.Pow(v2.y - v1.y, 2));
            double alturaTriangulo = Math.Sqrt(Math.Pow(v3.x - v2.x, 2) + Math.Pow(v3.y - v2.y, 2));
            area = baseTriangulo * alturaTriangulo;
            return area;
        }

        public double GetPerimetroRectangulo()
        {
            double baseInferior = Math.Sqrt(Math.Pow((v2.x - v1.x), 2) + Math.Pow((v2.y - v1.y), 2));
            double baseSuperior = Math.Sqrt(Math.Pow((v4.x - v3.x), 2) + Math.Pow((v4.y - v3.y), 2));
            double ladoIzquiero = Math.Sqrt(Math.Pow((v4.x - v1.x), 2) + Math.Pow((v4.y - v1.y), 2));
            double ladoDerecho = Math.Sqrt(Math.Pow((v3.x - v2.x), 2) + Math.Pow((v3.y - v2.y), 2));
            perimetro = baseInferior + ladoIzquiero + baseSuperior + ladoDerecho;
            return perimetro;
        }
    }
}
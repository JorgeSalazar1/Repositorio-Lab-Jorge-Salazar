using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_JJSC_1202022
{
    internal class Circulo
    {
        private double radio;
        public Circulo(double radio)
        {
        }

        private double ObtenerPerimetro(double radio)
        {
            double perimetro = (2 * radio) * 3.14159;
            Console.WriteLine("El perimetro de su figura es: " + perimetro);
            return perimetro;
        }

        private double ObtenerArea(double radio)
        {
            double area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("El area de su figura es  "+ area);
            return area;
        }

        private double ObtenerVolumen(double radio)
        {
            double volumen = (4 * Math.PI * Math.Pow(radio, 3)) / 3;
            Console.WriteLine("El volumen de su figura es: " + volumen);
            return volumen;
            Console.ReadKey();
        }

        public void CalcularGeometria(ref double Perimetro, ref double Area, ref double Volumen)
        {
            this.ObtenerPerimetro(Perimetro);
            this.ObtenerArea(Area);
            this.ObtenerVolumen(Volumen);
        }
    }
}

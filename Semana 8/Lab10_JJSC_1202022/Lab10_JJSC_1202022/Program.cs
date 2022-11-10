// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using Lab10_JJSC_1202022;
double radio;

Console.WriteLine("Ingrese el radio del circulo");
radio = Convert.ToDouble(Console.ReadLine());
Circulo objCirculo = new Circulo(radio);

objCirculo.CalcularGeometria(ref radio, ref radio, ref radio);

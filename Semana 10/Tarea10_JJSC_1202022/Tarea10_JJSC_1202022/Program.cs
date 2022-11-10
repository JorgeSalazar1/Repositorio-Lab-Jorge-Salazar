using Tarea10_JJSC_1202022;

TrianguloRectangulo triangulo = new TrianguloRectangulo();

Console.WriteLine("Ingrese el cateto A:");
triangulo.catetoA = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el angulo opuesto a A: ");
triangulo.anguloOpuestoA = double.Parse(Console.ReadLine());

Console.WriteLine("Cateto B : " + triangulo.ObtenerCatetoB());
Console.WriteLine("Hipotenusa: " + triangulo.ObtenerHipotenusa());
Console.WriteLine("Angulo opuesto a B: " + triangulo.ObtenerAnguloOpuestoB());
Console.WriteLine("Area del triangulo: " + triangulo.ObtenerArea());

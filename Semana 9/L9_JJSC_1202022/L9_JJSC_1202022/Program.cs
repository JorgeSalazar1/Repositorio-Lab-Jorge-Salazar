// See https://aka.ms/new-console-template for more information
using L9_JJSC_1202022;

Automovil objAutomovil = new Automovil(2022, 150000, "Mercedes Benz", true, 7.73);

int opcion;
do
{
    Console.WriteLine("1. Cambiar el modelo");
    Console.WriteLine("2. Cambiar el precio");
    Console.WriteLine("3. Cambiar la marca");
    Console.WriteLine("4. Cambiar la disponibilidad");
    Console.WriteLine("5. Cambiar el tipo de cambio");
    Console.WriteLine("6. Aplicar descuento");

    Console.Write("Ingrese una opción: ");
    opcion = int.Parse(Console.ReadLine());
}
while(opcion != 0);


static void manejarOpcion (int opcion, Automovil automovil)
{
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese un nuevo modelo");
            automovil.modelo = int.Parse(Console.ReadLine());
            break;
        case 2:
            Console.WriteLine("Ingrese un nuevo precio");
            automovil.precio = int.Parse(Console.ReadLine());
            break;
        case 3:
            Console.WriteLine("Ingrese una nueva marca");
            automovil.marca = Console.ReadLine();
            break;
        case 4:
            Console.WriteLine("Cambie la disponibilidad");
            automovil.disponibilidad = bool.Parse(Console.ReadLine());
            break;
        case 5:
            Console.WriteLine("Ingrese el nuevo tipo de cambio");
            automovil.tipoDeCambioDolar = int.Parse(Console.ReadLine());
            break;
        case 6:
            Console.WriteLine("Ingrese el nuevo descuento");
            automovil.descuentoAplicado = int.Parse(Console.ReadLine());
            break;
            }
     }


static void Main(string[] args)
{
    Automovil objAutomovil = new Automovil(2022, 150000, "Mercedes Benz", true, 7.73);
    }


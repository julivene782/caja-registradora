//etapa 1 
string name = "KIOSKO EL RECREO";
Console.WriteLine(name);

Console.WriteLine("Ingrese su nombre: " );
string user = Console.ReadLine();
Console.WriteLine($"Bienvenido, {user}. La Caja esta abierta.");
Console.ReadLine();

//etapa 2 
Console.WriteLine("Ingrese el nombre del producto: ");
string product = Console.ReadLine();
Console.WriteLine("Ingrese el precio del producto: ");
decimal price = decimal.Parse(Console.ReadLine());  

Console.WriteLine($"Producto cargado: {product} - Precio: ${price}");
Console.ReadLine();

//etapa 3 
const decimal DescuentoDiez = 0.10m;
const decimal DescuentoCinco = 0.05m;

decimal total = 0;
int cantidadProductos = 0;
int opcion;

do
{
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el nombre del producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            decimal precioProducto = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Producto cargado: {nombreProducto} - Precio: ${precioProducto}");

            total += precioProducto;
            cantidadProductos++;

            break;

        case 2:
            decimal descuento = 0;

            if (total > 50000)
            {
                descuento = total * DescuentoDiez;
            }
            else if (total > 20000)
            {
                descuento = total * DescuentoCinco;
            }
            else
            {
                descuento = 0;
            }

            decimal totalConDescuento = total - descuento;

            Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal: ${total}");
            Console.WriteLine($"Descuento aplicado: ${descuento}");
            Console.WriteLine($"Total con descuento: ${totalConDescuento}");

            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

}
while (opcion != 2);









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

//etapa 3 - 4 - 5 - 6 

const decimal DescuentoDiez = 0.10m;
const decimal DescuentoCinco = 0.05m;
const decimal DescuentoEfectivo = 0.10m;
const decimal RecargoCredito = 0.15m;

Console.Write("Ingrese el nombre del cajero: ");
string cajero = Console.ReadLine();

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
            //estapa 4 - desc por el monto
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
            
            // etapa 5 - medio de pago 
            int medioPago;
            decimal descuentoMedioPago = 0;
            decimal recargo = 0;
            decimal totalFinal = totalConDescuento;

            do
            {
                Console.WriteLine("Medio de pago:");
                Console.WriteLine("1 - Efectivo");
                Console.WriteLine("2 - Débito");
                Console.WriteLine("3 - Crédito");

                medioPago = int.Parse(Console.ReadLine());

                switch (medioPago)
                {
                    case 1:
                        descuentoMedioPago = totalConDescuento * DescuentoEfectivo;
                        totalFinal = totalConDescuento - descuentoMedioPago;
                        break;

                    case 2:
                        totalFinal = totalConDescuento;
                        break;

                    case 3:
                        recargo = totalConDescuento * RecargoCredito;
                        totalFinal = totalConDescuento + recargo;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            }
            while (medioPago < 1 || medioPago > 3);
            
            //Etapa 6 - ticket final
            decimal descuentoTotal = descuento + descuentoMedioPago;

            MostrarLinea();

            Console.WriteLine("KIOSCO EL RECREO");

            MostrarLinea();

            Console.WriteLine($"Cajero: {cajero}");
            Console.WriteLine($"Productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal: ${total}");
            Console.WriteLine($"Descuento: ${descuentoTotal}");
            Console.WriteLine($"Recargo: ${recargo}");

            MostrarLinea();

            Console.WriteLine($"TOTAL: ${totalFinal}");

            MostrarLinea();

            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

}
while (opcion != 2);
// Generar las líneas del ticket con un for
void MostrarLinea()
{
    for (int i = 0; i < 28; i++)
    {
        Console.Write("-");
    }

    Console.WriteLine();
}








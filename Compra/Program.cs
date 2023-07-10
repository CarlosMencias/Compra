
class Program

{
    static void Main(string[] args)
    {
        Producto producto = new Producto

        {
            nombre = "Peras",
            precio = 0.50m,
            cantidadDisponible = 50
        };


        producto.MostrarDetalles();

        Console.Write("Ingrese la cantidad deseada: ");
        int cantidadCompra = Convert.ToInt32(Console.ReadLine());
        producto.ActualizarCantidad(cantidadCompra);

        Console.WriteLine("\nDespués de la compra:");
        producto.MostrarDetalles();

        decimal costoTotal = producto.CalcularCostoTotal();
        Console.WriteLine("\nCosto total de los productos disponibles: $" + costoTotal);
    }
}

using System;

class Producto
{
    public string? nombre;
    public decimal precio;
    public int cantidadDisponible;

    public Producto()
    {
        nombre = null;
        precio = 0;
        cantidadDisponible = 0;
    }

    public Producto(string nombre, decimal precio, int cantidadDisponible)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.cantidadDisponible = cantidadDisponible;
    }

    public decimal CalcularCostoTotal()
    {
        return precio * cantidadDisponible;
    }


    public void ActualizarCantidad(int cantidadComprada)
    {
        cantidadDisponible -= cantidadComprada;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Nombre................:{nombre,20}\n");
        Console.WriteLine($"Precio................:{precio,20:C2}\n");
        Console.WriteLine($"Cantidad disponible...:{cantidadDisponible,20}\n");
    }
}
namespace Clase_3;

public class PasajeParametros
{
    
    public void ModificarPorReferencia(ref int numero)
    {
        numero *= 2; // Multiplica el número por 2
        Console.WriteLine("Dentro de ModificarPorReferencia: " + numero);
    }

    public void AsignarPorOut(out int numero,out string nombre)
    {
        numero = 100; // Asigna un nuevo valor al número
        nombre = "Juan";
        Console.WriteLine("Dentro de AsignarPorOut: " + numero);
        Console.WriteLine();
    }
}
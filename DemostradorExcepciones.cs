using System.Data;
using System.Runtime.CompilerServices;

namespace Clase_3;

public class DemostradorExcepciones
{
    public void DividirPorCero()
    {
        try
        {
            int divisor = 0;
            int resultado = 10 / divisor;
        }
        // catch (DivideByZeroException ex)
        // {
        //     Console.WriteLine("Se ha producido una excepción: " + ex.Message);
        // }
        catch (Exception e)
        {
            Console.WriteLine("Se ha producido una excepción: " + e.Message);
        }
    }
}
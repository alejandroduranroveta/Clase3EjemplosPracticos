namespace Clase_3
{
    public class PasarParametros
    {
        // Método que recibe un parámetro por valor.
        // Cuando pasamos un parámetro por valor, se crea una copia del valor en un nuevo lugar de memoria.
        // Por lo tanto, cualquier cambio hecho en este método no afectará el valor original.
        public int PasarPorValor(int valor, string valorString)
        {
            valor = 20;
            valorString = "20";
            Console.WriteLine("Valor dentro de PasarPorValor: " + valor);
            return valor;
        }
        
        // Método que recibe un parámetro por referencia.
        // Cuando pasamos un parámetro por referencia, estamos pasando la dirección de memoria del valor original.
        // Por lo tanto, cualquier cambio hecho en este método afectará el valor original.
        
        public void PasarPorReferencia(ref int valor)
        {
            valor = 30;
            Console.WriteLine("Valor dentro de PasarPorReferencia: " + valor);
        }

        // Método que utiliza un parámetro out.
        // Los parámetros out son similares a los parámetros ref, pero no requieren que la variable que se pasa esté inicializada.
        public void PasarPorOut(out int valor)
        {
            valor = 40; // Debemos asignar un valor antes de que termine el método.
            Console.WriteLine("Valor dentro de PasarPorOut: " + valor);
        }
    }
}
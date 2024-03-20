namespace Clase_3;

public class Generica<T>
{
    private T dato;

    public Generica(T valor)
    {
        this.dato = valor;
    }

    public T GetDato()
    {
        return this.dato;
    }
}
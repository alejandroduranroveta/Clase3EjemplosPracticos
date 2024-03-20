namespace Clase_3;

public interface IAnimal
{
    void HacerSonido();
    //void Moverse();
}

public class Perro : IAnimal
{
    public void HacerSonido()
    {
        Console.WriteLine("Guau Guau");
    }

    // public void Moverse()
    // {
    //     Console.WriteLine("En circulos  ");
    // }
}
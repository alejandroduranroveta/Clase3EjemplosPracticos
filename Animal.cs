namespace Clase_3;

public class Animal
{
    //VIRTUAL-> Se puede sobreescribir
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido.");
    }
}

public class Gato : Animal
{
    //OVERRIDE-> Sobreescribe el método de la clase base
    public override void HacerSonido()
    {
        base.HacerSonido();
        Console.WriteLine("El gato hizo Miu.");
    }
}
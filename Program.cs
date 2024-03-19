namespace Clase_3;

class Program
{
    static void Main(string[] args)
    {
        Estructuras demo = new Estructuras();

        //demo.EjemploArray();
        //demo.EjemploLista();
        demo.EjemploListaObjetos();
        
        //demo.EjemploDiccionario();
        //demo.EjemploCola();
        //demo.EjemploPila();
        
        //PARAMETROS
        // PasarParametros ejemplo = new PasarParametros();
        //
        // int valor = 10;
        // Console.WriteLine("Valor original: " + valor);
        //
        // int valor1 = ejemplo.PasarPorValor(valor, "10");
        // Console.WriteLine("Después de PasarPorValor: " + valor);
        // Console.WriteLine("Después de PasarPorValor: " + valor1);
        //
        // ejemplo.PasarPorReferencia(ref valor);
        // Console.WriteLine("Después de PasarPorReferencia: " + valor);
        //
        // int valorOut;
        // ejemplo.PasarPorOut(out valorOut);
        // Console.WriteLine("Después de PasarPorOut: " + valorOut);
    }
}

// • Pasaje	de	parámetros	en	C#.


//• Diferencias	entre	referencia	e	instancia	a	nivel	conceptual.
//• Palabras	reservadas:	ref,	out.
//• Constructores	y	uso	de	this()	y	base().
// • Colecciones.
// • Generics.
//  • Estructuras	de	control	nuevas:	foreach.
//• Interfaces.
// • XML,	XMLWriter,	XMLReader,	Parsers
//• Expresiones	Lambda
//  • Excepciones
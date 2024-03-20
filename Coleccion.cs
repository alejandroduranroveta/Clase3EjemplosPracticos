namespace Clase_3;

public class Coleccion
{
    public void EjemploArray()
    {
        // Definición y ejemplo de uso de un array
        
        int[] array = new int[5]; // Crear un array de enteros con 5 elementos
        //FOR
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 2; // Asignar valores al array
        }

        Console.WriteLine("Array:");
        //FOREACH IN
        foreach (int num in array)
        {
            Console.Write(num + " "); // Mostrar los elementos del array
        }
        Console.WriteLine();

        //MOSTRAR QUE SUCEDE SI IMPRIMO TODO EL ARRAY
        Console.WriteLine("Array sin iterar" + array);
    }

    public void EjemploLista()
    {
        
        // List<string> lista = new List<string>(); // Crear una lista de strings vacía
        //
        // lista.Add("Hola");
        // lista.Add("Mundo");
        // lista.Add("!");
        //
        // Console.WriteLine("\nLista:");
        // foreach (string elemento in lista)
        // {
        //     Console.Write(elemento + " "); // Mostrar los elementos de la lista
        // }
        // Console.WriteLine();
        
        // List<int> listaEnteros = new List<int> { 1, 2, 3, 4, 5 }; //una lista con elementos ya definidos
        // listaEnteros.Add(6);
        // Console.WriteLine("IMPRIMO EL INDICE 0 " + listaEnteros[0]);
        // Console.WriteLine(listaEnteros);
    }
    
    public void EjemploListaObjetos()
    {
        // Definición y ejemplo de uso de una lista de objetos compuestos

        // List<Persona> listaPersonas = new List<Persona>(); // Crear una lista de Personas vacía
        //
        // // Agregar objetos Persona a la lista
        // listaPersonas.Add(new Persona { Nombre = "Juan", Edad = 30 });
        // listaPersonas.Add(new Persona { Nombre = "Ana", Edad = 25 });
        // listaPersonas.Add(new Persona { Nombre = "Pedro", Edad = 35 });
        //
        // Persona p = new Persona();
        // p.Edad = 30;
        // p.Nombre = "Roberth";
        //
        // listaPersonas.Add(p);
        //
        //
        // Console.WriteLine("\nLista de Personas:");
        // foreach (Persona persona in listaPersonas)
        // {
        //     Console.WriteLine("Nombre: " + persona.Nombre + ", Edad: " + persona.Edad); // Mostrar los elementos de la lista
        // }
    }
    

    public void EjemploDiccionario()
    {
        // Definición y ejemplo de uso de un diccionario
        //Diccionario: Clave-valor 
        Dictionary<int, string> diccionario = new Dictionary<int, string>(); // Crear un diccionario vacío
        diccionario.Add(1, "Lunes");
        diccionario.Add(2, "Martes");
        diccionario.Add(3, "Miércoles");

        Console.WriteLine("\nDiccionario:");
        
        //RECORRER  EL DICCIONARIO (KEYVALUEPAIR)
        foreach (KeyValuePair<int, string> claveValor in diccionario)
        {
            Console.WriteLine("Key: {0}, Value: {1}", claveValor.Key, claveValor.Value); // Mostrar los elementos del diccionario
        }
    }

    public void EjemploCola()
    {
        // Definición y ejemplo de uso de una cola
        Queue<int> cola = new Queue<int>(); // Crear una cola vacía
        // Agregar elementos a la cola
        cola.Enqueue(1); 
        cola.Enqueue(2);
        cola.Enqueue(6);

        Console.WriteLine("\nCola:");
        //DESENCOLAR(DEQUEUE)
        while (cola.Count > 0)
        {
            Console.Write(cola.Dequeue() + " "); // Sacar elementos de la cola
        }
        //Mostrar que sucede si imprimo la cola
        Console.WriteLine(cola);
    }

    public void EjemploPila()
    {
        // Definición y ejemplo de uso de una pila
        Stack<int> pila = new Stack<int>(); // Crear una pila vacía
        // Agregar elementos a la pila
        pila.Push(1); 
        pila.Push(2);
        pila.Push(5);

        Console.WriteLine("\nPila:");
        while (pila.Count > 0)
        {
            Console.Write(pila.Pop() + " "); // Sacar elementos de la pila
        }
        Console.WriteLine();
    }
}
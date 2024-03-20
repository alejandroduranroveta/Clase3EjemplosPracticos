namespace Clase_3;

class Program
{
    static void Main(string[] args)
    {
        //STRUCT
        // Struct.Point2 point = new Struct.Point();
        // point.X = 10;
        // point.Y = 20;
        // //
        // Console.WriteLine($"Point: ({point.X}, {point.Y})");
        
        //COLECCIONES
        Coleccion demo = new Coleccion();

         //demo.EjemploArray();
        // demo.EjemploLista();
        //demo.EjemploListaObjetos();
        
        //demo.EjemploDiccionario();
        //demo.EjemploCola();
        //demo.EjemploPila();
        
        //PARAMETROS
          PasajeParametros demoParametros = new PasajeParametros();
         //
         // int valorRef = 10;
         // Console.WriteLine("Antes de ModificarPorReferencia: " + valorRef);
         // demoParametros.ModificarPorReferencia(ref valorRef);
         // Console.WriteLine("Después de ModificarPorReferencia: " + valorRef);
         //
         // int valorOut;
         // int valorOut2
          //demoParametros.AsignarPorOut(out valorOut , out valorOut2);
         // Console.WriteLine("Después de AsignarPorOut2: " + valorOut + " valorOut2 " + valorOut2);
            
         // // Crear un empleado con el constructor por defecto
         // Employee empleado1 = new Employee();
         // Console.WriteLine("Empleado1 salario: " + empleado1.Salary);
         // //
         // // // Crear un empleado con un salario anual
         // Employee empleado2 = new Employee(50000);
         // Console.WriteLine("Empleado2 salario: " + empleado2.Salary);
         // //
         // // // Crear un empleado con un salario semanal y el número de semanas
         // Employee empleado3 = new Employee(1000, 52);
         // Console.WriteLine("Empleado3 salario: " + empleado3.Salary);
        
        //BASE-> llamado metodo de la clase padre 
        // Gato cat = new Gato();
        // cat.HacerSonido();

        //THIS Y CLASE DENTRO DE CLASE
        // Create objects:
        // ClaseThis.Employee E1 = new ClaseThis.Employee("Mingda Pan", "mpan");
        // E1.PrintEmployee();

        //GENERICAS

        // Generica<int> miInt = new Generica<int>(10);
        // Console.WriteLine("LA DE INT " + miInt.GetDato()); 
        //
        // // Crear una instancia de MiClaseGenerica para string
        // Generica<string> miString = new Generica<string>("Hola mundo");
        // Console.WriteLine("LA DE STRING " + miString.GetDato()); 

        //DEMOSTRADOR DE EXCEPCIONES
        // DemostradorExcepciones dE = new DemostradorExcepciones();
        // dE.DividirPorCero();
    }
}

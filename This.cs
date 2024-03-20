namespace Clase_3;

public class ClaseThis
{
    public class Employee
    {
        private string name;
        private string alias;
        private decimal salary = 3000.00m;

        // Constructor:(mismo nombre que la clase)
        public Employee(string name, string alias)
        {
            // Use this to qualify the fields, name and alias:
            this.name = name;
            this.alias = alias;

        }
        public decimal Salary
        {
            
            get { return salary; }
        }

        //IMPRIMIR EMPLEADO
        public void PrintEmployee()
        {
            Console.WriteLine("Name: {0}\nAlias: {1}", name, alias);
            
            //PASO EL OBJETO USANDO EL THIS
            Console.WriteLine("Taxes: {0:C}", Tax.CalcTax(this));
        }

        
    }

    public class Tax
    {
        public static decimal CalcTax(Employee E)
        {
            return 0.08m * E.Salary;
        }
    }
}


/*
Output:
    Name: Mingda Pan
    Alias: mpan
    Taxes: $240.00
 */


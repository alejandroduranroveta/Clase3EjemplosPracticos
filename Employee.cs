namespace Clase_3;

    public class Employee //Un empleado tiene un salario
    {
        
        public int Salary;
        
        //Empleado sin salario
        public Employee() { }

        //Empleado que recibe un salario anual
        public Employee(int annualSalary)
        {
            Salary = annualSalary; 
        }
        
    //Empleado que recibe un salario semanal 
        public Employee(int weeklySalary, int numberOfWeeks)
        {
            Salary = weeklySalary * numberOfWeeks;
        }
    }
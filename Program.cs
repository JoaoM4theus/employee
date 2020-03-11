using System;
using System.Globalization;
using System.Collections.Generic;

namespace Employee {
    class Program {
        static void Main(string[] args) {
            //NUMERO DE FUNCIONARIOS
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            //REGISTRAR FUNCIONARIOS
            int cont = 1;
            List<Employee> list = new List<Employee>();
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Emplyoee #" + cont); cont++; //ACRESCENTANDO PARA O PRÓXIMO FUNCIONARIO.
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                list.Add(new Employee(id, name, salary));//ADICIONANDO OS ATRIBUTOS NA LISTA.
            }

            Console.Write("Enter the employee id that will have salary increase: ");//PEGANDO ID DO FUNCIONARIO.
            int _id = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == _id);//PROCURANDO O ELEMENTO NA LISTA

            if (emp != null) {
                Console.Write("Enter the porcentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees:");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas_funcionarios.entidades
{
    internal class Company
    {
        public List<Employee> Employees { get; set; }

        public Company()
        {
            Employees = new List<Employee>();
        }

        public void AdicionarFuncionarios(Employee emp)
        {
            Employees.Add(emp);
        }

        public void MostrarFuncionarios()
        {
            Console.WriteLine($"funcionarios da Compania:");
            foreach (Employee emp in Employees)
            {
                Console.WriteLine($"Nome do funcionario: {emp.Name}, Posiçao do funcionario: {emp.Position}");
            }
        }
    }
}

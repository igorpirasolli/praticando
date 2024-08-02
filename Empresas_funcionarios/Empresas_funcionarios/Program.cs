using Empresas_funcionarios.entidades;

namespace Empresas_funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee funcionario1 = new Employee("igor", "gerente");
            Employee funcionario2 = new Employee("isabelle", "auxiliar de produçao");

            Company company = new Company();

            company.AdicionarFuncionarios(funcionario1);
            company.AdicionarFuncionarios(funcionario2);

            company.MostrarFuncionarios();


        }
    }
}
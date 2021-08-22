using System;

namespace funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario infoFuncionario = new Funcionario();
            Console.WriteLine("Digite o nome do funcionário:");
            infoFuncionario.nome = Console.ReadLine();

            Console.WriteLine("Digite o salário do funcionário:");
            infoFuncionario.salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o código do funcionário:");
            infoFuncionario.codigo = Convert.ToInt32(Console.ReadLine());

            infoFuncionario.mostrar();
            Console.ReadKey();






        }
    }
}

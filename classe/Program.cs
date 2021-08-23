using System;

namespace classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta objetoConta = new Conta(); //Declarando uma variavel e tipando
            objetoConta.numero = 100;
            objetoConta.saldo = 500;
            objetoConta.titular = "Gabriel";
            objetoConta.Mostrar();

            Console.WriteLine("__Conta 2__");
            Conta conta2 = new Conta();
            conta2.numero = 200;
            conta2.saldo = 600;
            conta2.titular = "Baltazar";
            conta2.Mostrar();
            
            conta2.Transferir(200, objetoConta);
            Console.WriteLine("Apos transferencia 1!");
            conta2.Mostrar();
            objetoConta.Mostrar();

            conta2.Transferir1(500,objetoConta);
            Console.WriteLine("Apos transferencia 2!");
            conta2.Mostrar();
            objetoConta.Mostrar();

            



            /* Conta c3 = new Conta();
            Console.WriteLine("Digite o numero da conta: ");
            c3.numero = Convert.ToInt32(Console.ReadLine());   
            
            Console.WriteLine("Digite o nome do titular: ");
            c3.titular = Console.ReadLine();

            Console.WriteLine("Digite o saldo: ");
            c3.saldo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saldo da conta c3 R$"+c3.saldo);
            Console.WriteLine("Qual valor quer sacar da conta? ");
            double vs = Convert.ToInt32(Console.ReadLine());
            c3.Sacar(vs);
            Console.WriteLine("Saldo de c3 apos o saque R$ "+c3.saldo);
            Console.WriteLine("Qual valor quer depositar na conta? ");
            double vd = Convert.ToInt32(Console.ReadLine());
            c3.Depositar(vd);
            c3.Mostrar(); */

            Console.ReadKey();
        }
    }
}

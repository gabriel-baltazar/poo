using System;

    class Conta 
    {
        //Declaração de atributos
        public int numero;
        public string titular;
        public double saldo;

        //Declaração dos metodos
        public void Sacar(double valorSaque)
        {
            if(valorSaque <= saldo)
                saldo -= valorSaque;
            else
                Console.WriteLine("Saldo insuficiente");
                
            
        }
        public void Depositar(double valorDeposito)
        {
            if (valorDeposito > 0)
                saldo += valorDeposito;
            else
                Console.WriteLine("Valor invalido para deposito");
        }
        public void Mostrar()
        {
            Console.WriteLine("O saldo da conta é R$ "+saldo);
            Console.WriteLine("O titular da conta é "+titular);
            Console.WriteLine("O numero da conta é "+numero);
        }


    }
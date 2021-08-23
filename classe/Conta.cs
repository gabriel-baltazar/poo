using System;

    class Conta 
    {
        //Declaração de atributos
        public int numero;
        public string titular;
        public double saldo;

        //Declaração dos metodos
        public bool Sacar(double valorSaque)
        {
            if(valorSaque <= saldo && valorSaque > 0)
            {
                saldo -= valorSaque;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            
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
            Console.WriteLine("O saldo da conta é R$ " + saldo + "\tO titular da conta é " + titular + "\tO numero da conta é " + numero);
        }
        public void Transferir(double valor, Conta objeto)// sem validaçao e ineficiente
        {
            saldo -= valor;
            objeto.saldo += valor; 
        }
        public void Transferir1(double valor, Conta objeto) //com validacao e aproveitando metodos existentes
        {
            if (Sacar(valor))
                objeto.Depositar(valor);
            
        }


    }
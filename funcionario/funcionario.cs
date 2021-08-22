using System;

class Funcionario
{
    public int codigo;
    public string nome;
    public double salario;

  
    public void mostrar()
    {
        Console.WriteLine("Codigo: " + codigo + "\tNome: "+ nome + "\tSalario: "+salario);

    }

}
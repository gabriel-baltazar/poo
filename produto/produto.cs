using System;


class Produto 
{
    public int codigo;
    public string descricao;
    public double preco;
    

    public void Mostrar()
    {
                Console.WriteLine("Codigo: " + codigo + "\tDescrição: " + descricao + "\tPreço: " + preco);


    }
}
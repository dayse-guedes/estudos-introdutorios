//Entendendo os conceitos de orientação a objetos

//Classe e objetos

using System;

class Carro
{
    // Atributos da classe Carro
    public string Modelo;
    public string Cor;
    public int Ano;

    // Método da classe Carro
    public void Acelerar()
    {
        Console.WriteLine("O carro está acelerando!");
    }
}

class Program
{
    static void Main()
    {
        // Criando um objeto da classe Carro
        Carro meuCarro = new Carro();

        // Definindo os valores dos atributos do objeto
        meuCarro.Modelo = "Sedan";
        meuCarro.Cor = "Azul";
        meuCarro.Ano = 2023;

        // Chamando o método do objeto
        meuCarro.Acelerar();
    }
}

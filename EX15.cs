using System;

public class Pessoa
{
    public string Nome { get; set; }
}

public class Casa
{
    private Pessoa pessoa;

    public void AdicionarMorador(Pessoa pessoa)
    {
        this.pessoa = pessoa;
    }

    public void ExibirMorador()
    {
        Console.WriteLine($"Morador da casa: {pessoa.Nome}");
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa pessoa = new Pessoa();

        Console.Write("Digite o nome do morador: ");
        pessoa.Nome = Console.ReadLine();

        Casa casa = new Casa();

        casa.AdicionarMorador(pessoa);

        Console.WriteLine("\n--- Casa ---");
        casa.ExibirMorador();
    }
}
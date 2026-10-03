public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: R$ {Preco:F2}");
        Console.WriteLine($"Quantidade: {Quantidade}");
    }

    public double CalcularValorTotal()
    {
        return Preco * Quantidade;
    }
}

public class Program
{
    public static void Main()
    {
        Produto p1 = new Produto();
        p1.Nome = "Arroz";
        p1.Preco = 25.00;
        p1.Quantidade = 2;

        Produto p2 = new Produto();
        p2.Nome = "Feijão";
        p2.Preco = 8.00;
        p2.Quantidade = 3;

        Produto p3 = new Produto();
        p3.Nome = "Macarrão";
        p3.Preco = 5.00;
        p3.Quantidade = 4;

        p1.ExibirDados();
        Console.WriteLine($"Valor total: R$ {p1.CalcularValorTotal():F2}");

        Console.WriteLine();

        p2.ExibirDados();
        Console.WriteLine($"Valor total: R$ {p2.CalcularValorTotal():F2}");

        Console.WriteLine();

        p3.ExibirDados();
        Console.WriteLine($"Valor total: R$ {p3.CalcularValorTotal():F2}");
    }
}

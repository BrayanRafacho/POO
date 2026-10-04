public class Produto
{
    private string nome;
    private decimal preco;

    public Produto(string nome, decimal preco)
    {
        this.nome = nome;

        if (preco >= 0)
        {
            this.preco = preco;
        }
        else
        {
            this.preco = 0;
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Preço: R$ {preco:F2}");
    }

    public void AlterarPreco(decimal novoPreco)
    {
        if (novoPreco >= 0)
        {
            preco = novoPreco;
            Console.WriteLine("Preço alterado com sucesso!");
        }
        else
        {
            Console.WriteLine("Erro: o preço não pode ser negativo!");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Produto p = new Produto("Celular", 1500);

        p.ExibirDetalhes();

        p.AlterarPreco(-200);

        p.AlterarPreco(1200);

        p.ExibirDetalhes();
    }
}

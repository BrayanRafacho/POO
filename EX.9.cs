public class Produto
{
    private decimal preco;

    private string nome;

    public string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }

            nome = value;
        }
    }

    public decimal Preco
    {
        get
        {
            return preco;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("O preço não pode ser negativo.");
            }

            preco = value;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Produto produto = new Produto();

        Console.Write("Digite o nome do produto: ");
        produto.Nome = Console.ReadLine();

        try
        {
            Console.Write("Digite o preço do produto: ");
            produto.Preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n--- Produto ---");
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Preço: R$ {produto.Preco:F2}");

            Console.Write("\nDigite um novo preço: ");
            produto.Preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Novo preço: R$ {produto.Preco:F2}");
        }
        catch (ArgumentException erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
        }
    }
}

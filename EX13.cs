public class Produto
{
    private string nome;
    private string codigo;
    private decimal preco;

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
                throw new ArgumentException("O nome é obrigatório.");
            }

            nome = value;
        }
    }

    public string Codigo
    {
        get
        {
            return codigo;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O código é obrigatório.");
            }

            codigo = value;
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

    public int QuantidadeEstoque { get; private set; }

    public bool EstoqueBaixo
    {
        get
        {
            return QuantidadeEstoque <= 5;
        }
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            QuantidadeEstoque += quantidade;
            Console.WriteLine("Produtos adicionados ao estoque!");
        }
        else
        {
            Console.WriteLine("A quantidade deve ser maior que zero.");
        }
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade <= 0)
        {
            Console.WriteLine("A quantidade deve ser maior que zero.");
        }
        else if (quantidade > QuantidadeEstoque)
        {
            Console.WriteLine("Não é possível remover mais produtos do que existem no estoque.");
        }
        else
        {
            QuantidadeEstoque -= quantidade;
            Console.WriteLine("Produtos removidos do estoque!");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Produto produto = new Produto();

        try
        {
            Console.Write("Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Digite o código do produto: ");
            produto.Codigo = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            produto.Preco = decimal.Parse(Console.ReadLine());

            Console.Write("\nDigite a quantidade inicial no estoque: ");
            int quantidadeInicial = int.Parse(Console.ReadLine());

            produto.AdicionarEstoque(quantidadeInicial);

            Console.WriteLine("\n--- Produto ---");
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Código: {produto.Codigo}");
            Console.WriteLine($"Preço: R$ {produto.Preco:F2}");
            Console.WriteLine($"Estoque: {produto.QuantidadeEstoque}");
            Console.WriteLine($"Estoque baixo: {produto.EstoqueBaixo}");

            Console.Write("\nQuantos produtos deseja adicionar? ");
            int adicionar = int.Parse(Console.ReadLine());

            produto.AdicionarEstoque(adicionar);

            Console.WriteLine($"Estoque atual: {produto.QuantidadeEstoque}");

            Console.Write("\nQuantos produtos deseja remover? ");
            int remover = int.Parse(Console.ReadLine());

            produto.RemoverEstoque(remover);

            Console.WriteLine($"Estoque atual: {produto.QuantidadeEstoque}");
            Console.WriteLine($"Estoque baixo: {produto.EstoqueBaixo}");
        }
        catch (ArgumentException erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
        }
    }
}

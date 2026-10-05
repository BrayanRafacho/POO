public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}

public class Program
{
    public static void Main()
    {
        Pessoa pessoa = new Pessoa();

        Console.Write("Digite o nome: ");
        pessoa.Nome = Console.ReadLine();

        Console.Write("Digite a idade: ");
        pessoa.Idade = int.Parse(Console.ReadLine());

        Console.Write("Digite o email: ");
        pessoa.Email = Console.ReadLine();

        Console.WriteLine("\n--- Dados da Pessoa ---");
        Console.WriteLine($"Nome: {pessoa.Nome}");
        Console.WriteLine($"Idade: {pessoa.Idade}");
        Console.WriteLine($"Email: {pessoa.Email}");

        Console.Write("\nDigite a nova idade: ");
        pessoa.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Dados Atualizados ---");
        Console.WriteLine($"Nome: {pessoa.Nome}");
        Console.WriteLine($"Idade: {pessoa.Idade}");
        Console.WriteLine($"Email: {pessoa.Email}");
    }
}
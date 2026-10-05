public class Aluno
{
    private string nome;
    private double nota1;
    private double nota2;

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

    public double Nota1
    {
        get
        {
            return nota1;
        }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException("A nota deve estar entre 0 e 10.");
            }

            nota1 = value;
        }
    }

    public double Nota2
    {
        get
        {
            return nota2;
        }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException("A nota deve estar entre 0 e 10.");
            }

            nota2 = value;
        }
    }

    public double Media
    {
        get
        {
            return (Nota1 + Nota2) / 2;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Aluno aluno = new Aluno();

        try
        {
            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--- Dados do Aluno ---");
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Nota 1: {aluno.Nota1}");
            Console.WriteLine($"Nota 2: {aluno.Nota2}");
            Console.WriteLine($"Média: {aluno.Media}");

            Console.Write("\nDigite uma nova nota 2: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nova média: {aluno.Media}");
        }
        catch (ArgumentException erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
        }
    }
}
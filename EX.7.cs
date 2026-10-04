public class Elevador
{
    private int andarAtual;
    private int totalAndares;

    public Elevador(int totalAndares)
    {
        this.totalAndares = totalAndares;
        andarAtual = 0;
    }

    public void Subir()
    {
        if (andarAtual < totalAndares)
        {
            andarAtual++;
        }
        else
        {
            Console.WriteLine("O elevador já está no último andar.");
        }
    }

    public void Descer()
    {
        if (andarAtual > 0)
        {
            andarAtual--;
        }
        else
        {
            Console.WriteLine("O elevador já está no térreo.");
        }
    }

    public void ExibirAndar()
    {
        Console.WriteLine($"Andar atual: {andarAtual}");
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Digite o número total de andares: ");
        int totalAndares = int.Parse(Console.ReadLine());

        Elevador e = new Elevador(totalAndares);

        Console.Write("Digite quantas vezes deseja subir: ");
        int subidas = int.Parse(Console.ReadLine());

        for (int i = 0; i < subidas; i++)
        {
            e.Subir();
        }

        e.ExibirAndar();

        Console.Write("Digite quantas vezes deseja descer: ");
        int descidas = int.Parse(Console.ReadLine());

        for (int i = 0; i < descidas; i++)
        {
            e.Descer();
        }

        e.ExibirAndar();
    }
}
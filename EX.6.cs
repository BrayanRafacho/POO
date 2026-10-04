public class Carro
{
    private string modelo;
    private int velocidadeAtual;

    public Carro(string modelo)
    {
        this.modelo = modelo;
        velocidadeAtual = 0;
    }

    public void Acelerar(int valor)
    {
        if (valor > 0)
        {
            velocidadeAtual += valor;
        }
    }

    public void Frear(int valor)
    {
        if (valor > 0)
        {
            velocidadeAtual -= valor;

            if (velocidadeAtual < 0)
            {
                velocidadeAtual = 0;
            }
        }
    }

    public void ExibirVelocidade()
    {
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Velocidade atual: {velocidadeAtual} km/h");
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Digite o modelo do carro: ");
        string modelo = Console.ReadLine();

        Carro c = new Carro(modelo);

        Console.Write("Quanto deseja acelerar? ");
        int acelerar = int.Parse(Console.ReadLine());
        c.Acelerar(acelerar);

        c.ExibirVelocidade();

        Console.Write("Quanto deseja frear? ");
        int frear = int.Parse(Console.ReadLine());
        c.Frear(frear);

        c.ExibirVelocidade();
    }
}
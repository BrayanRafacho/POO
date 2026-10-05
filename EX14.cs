using System;

public class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int NumeroDeRodas { get; set; }

    public void ExibirDados()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Número de rodas: {NumeroDeRodas}");
    }
}

public class Carro : Veiculo
{
    public int NumeroDePortas { get; set; }
}

public class Moto : Veiculo
{
    public bool PossuiBagageiro { get; set; }
}

public class Program
{
    public static void Main()
    {
        Carro carro = new Carro();

        Console.WriteLine("--- CARRO ---");

        Console.Write("Digite a marca: ");
        carro.Marca = Console.ReadLine();

        Console.Write("Digite o modelo: ");
        carro.Modelo = Console.ReadLine();

        Console.Write("Digite o número de rodas: ");
        carro.NumeroDeRodas = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de portas: ");
        carro.NumeroDePortas = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDados do carro:");
        carro.ExibirDados();
        Console.WriteLine($"Número de portas: {carro.NumeroDePortas}");


        Moto moto = new Moto();

        Console.WriteLine("\n--- MOTO ---");

        Console.Write("Digite a marca: ");
        moto.Marca = Console.ReadLine();

        Console.Write("Digite o modelo: ");
        moto.Modelo = Console.ReadLine();

        Console.Write("Digite o número de rodas: ");
        moto.NumeroDeRodas = int.Parse(Console.ReadLine());

        Console.Write("Possui bagageiro? (true/false): ");
        moto.PossuiBagageiro = bool.Parse(Console.ReadLine());

        Console.WriteLine("\nDados da moto:");
        moto.ExibirDados();
        Console.WriteLine($"Possui bagageiro: {moto.PossuiBagageiro}");
    }
}
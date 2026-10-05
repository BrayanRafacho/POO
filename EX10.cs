public class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double Area
    {
        get
        {
            return Largura * Altura;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Retangulo retangulo = new Retangulo();

        Console.Write("Digite a largura: ");
        retangulo.Largura = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura: ");
        retangulo.Altura = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nÁrea: {retangulo.Area}");

        Console.Write("\nDigite uma nova largura: ");
        retangulo.Largura = double.Parse(Console.ReadLine());

        Console.WriteLine($"Nova área: {retangulo.Area}");
    }
}
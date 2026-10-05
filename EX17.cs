using System;

public interface IVoar
{
    void Voar();
}

public interface INadar
{
    void Nadar();
}

public class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("O pato está voando.");
    }

    public void Nadar()
    {
        Console.WriteLine("O pato está nadando.");
    }
}

public class Aguia : IVoar
{
    public void Voar()
    {
        Console.WriteLine("A águia está voando.");
    }
}

public class Peixe : INadar
{
    public void Nadar()
    {
        Console.WriteLine("O peixe está nadando.");
    }
}

public class Program
{
    public static void Main()
    {
        Pato pato = new Pato();
        Aguia aguia = new Aguia();
        Peixe peixe = new Peixe();

        Console.WriteLine("--- PATO ---");

        Console.Write("O pato vai voar? (s/n): ");
        string respostaPatoVoar = Console.ReadLine().ToLower();

        if (respostaPatoVoar == "s")
        {
            pato.Voar();
        }
        else
        {
            Console.WriteLine("O pato não vai voar.");
        }

        Console.Write("O pato vai nadar? (s/n): ");
        string respostaPatoNadar = Console.ReadLine().ToLower();

        if (respostaPatoNadar == "s")
        {
            pato.Nadar();
        }
        else
        {
            Console.WriteLine("O pato não vai nadar.");
        }


        Console.WriteLine("\n--- ÁGUIA ---");

        Console.Write("A águia vai voar? (s/n): ");
        string respostaAguia = Console.ReadLine().ToLower();

        if (respostaAguia == "s")
        {
            aguia.Voar();
        }
        else
        {
            Console.WriteLine("A águia não vai voar.");
        }


        Console.WriteLine("\n--- PEIXE ---");

        Console.Write("O peixe vai nadar? (s/n): ");
        string respostaPeixe = Console.ReadLine().ToLower();

        if (respostaPeixe == "s")
        {
            peixe.Nadar();
        }
        else
        {
            Console.WriteLine("O peixe não vai nadar.");
        }
    }
}
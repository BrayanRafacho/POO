public class ContaBancaria
{
    public string Titular { get; private set; }

    public decimal Saldo { get; private set; }

    public ContaBancaria(string titular)
    {
        Titular = titular;
        Saldo = 0;
    }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser maior que zero.");
        }
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("O valor do saque deve ser maior que zero.");
        }
        else if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente!");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso!");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Digite o nome do titular: ");
        string titular = Console.ReadLine();

        ContaBancaria conta = new ContaBancaria(titular);

        Console.Write("\nDigite o valor para depositar: ");
        decimal deposito = decimal.Parse(Console.ReadLine());

        conta.Depositar(deposito);

        Console.Write("\nDigite o valor para sacar: ");
        decimal saque = decimal.Parse(Console.ReadLine());

        conta.Sacar(saque);

        Console.WriteLine("\n--- Conta Bancária ---");
        Console.WriteLine($"Titular: {conta.Titular}");
        Console.WriteLine($"Saldo: R$ {conta.Saldo:F2}");
    }
}
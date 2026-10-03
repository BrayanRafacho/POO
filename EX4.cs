public class ContaBancaria
{
    public string Titular;
    public int NumeroConta;
    public double Saldo;

    public void Depositar(double valor)
    {
        Saldo = Saldo + valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo = Saldo - valor;
            Console.WriteLine("Saque realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Conta: {NumeroConta}");
        Console.WriteLine($"Saldo: R$ {Saldo:F2}");
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria conta1 = new ContaBancaria();

        conta1.Titular = "João";
        conta1.NumeroConta = 1234;
        conta1.Saldo = 1000;

        ContaBancaria conta2 = new ContaBancaria();

        conta2.Titular = "Maria";
        conta2.NumeroConta = 5678;
        conta2.Saldo = 500;

        conta1.Depositar(500);
        conta1.Sacar(200);

        conta2.Depositar(300);
        conta2.Sacar(1000);

        conta1.ExibirSaldo();

        Console.WriteLine();

        conta2.ExibirSaldo();
    }
}
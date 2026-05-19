/*
Refatore o arquivo Calc.cs, deixe tudo dentro de função, 

Sugestão:
- Crie uma função Menu(){  } , que quando executada chama a função Opção() { }
na última linha do código chame a função Menu();
*/

/*
static void ExecutarCalculadora()
{
    double numero1;
    double numero2;
    double resultado = 0;
    string opcao;
    string continuar = "s";

    while (continuar == "s" || continuar == "S")
    {
        Console.Clear();

        ExibirMenu();

        opcao = LerOpcao();

        numero1 = LerNumero("Digite o primeiro número: ");
        numero2 = LerNumero("Digite o segundo número: ");

        resultado = Calcular(opcao, numero1, numero2);

        ExibirResultado(opcao, resultado);

        Console.WriteLine();
        continuar = LerContinuacao();
    }

}

static void ExibirMenu()
{
    Console.WriteLine("=== CALCULADORA ===");
    Console.WriteLine("+ Soma");
    Console.WriteLine("- Subtração");
    Console.WriteLine("* Multiplicação");
    Console.WriteLine("/ Divisão");
}

static string LerOpcao()
{
    Console.Write("Escolha uma opção: ");
    return Console.ReadLine()!;
}

static double LerNumero(string mensagem)
{
    Console.Write(mensagem);
    return double.Parse(Console.ReadLine()!);
}

static double Calcular(string opcao, double numero1, double numero2)
{
    if (opcao == "+")
        return numero1 + numero2;
    else if (opcao == "-")
        return numero1 - numero2;
    else if (opcao == "*")
        return numero1 * numero2;
    else if (opcao == "/")
        return numero1 / numero2;
    else
    {
        Console.WriteLine("Opção inválida.");
        return 0;
    }
}

static void ExibirResultado(string opcao, double resultado)
{
    if (opcao == "+")
        Console.WriteLine($"Resultado da soma: {resultado}");
    else if (opcao == "-")
        Console.WriteLine($"Resultado da subtração: {resultado}");
    else if (opcao == "*")
        Console.WriteLine($"Resultado da multiplicação: {resultado}");
    else if (opcao == "/")
        Console.WriteLine($"Resultado da divisão: {resultado}");
}

static string LerContinuacao()
{
    Console.Write("Deseja fazer outro cálculo? (s/n): ");
    return Console.ReadLine()!;
}
ExecutarCalculadora();
Console.Write("Fim de programa!!");
*/


/*
DEsenvolva a solução aqui em Program.cs, quando terminar cole o conteúdo 
no respectivo arquivo
*/

/*
static void ExibirMenuConversao()
{
    Console.Clear();
    Console.WriteLine("=== CONVERSOR DE TEMPERATURA ===");
    Console.WriteLine("1 - Celsius para Fahrenheit");
    Console.WriteLine("2 - Fahrenheit para Celsius");
    Console.Write("Escolha uma opção: ");
}

static string LerOpcaoConversao()
{
    return Console.ReadLine()!;
}

static double LerTemperatura()
{
    Console.Write("Digite a temperatura: ");
    return double.Parse(Console.ReadLine()!);
}

static double ConverterCelsiusParaFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}

static double ConverterFahrenheitParaCelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5 / 9;
}

static void ExibirResultadoConversao(double resultado, string unidade)
{
    Console.WriteLine();
    Console.WriteLine($"Resultado: {resultado:F2} {unidade}");
}

static void ExecutarConversor()
{
    ExibirMenuConversao();

    string opcao = LerOpcaoConversao();
    double temperatura = LerTemperatura();

    switch (opcao)
    {
        case "1":
            double resultadoFahrenheit = ConverterCelsiusParaFahrenheit(temperatura);
            ExibirResultadoConversao(resultadoFahrenheit, "°F");
            break;

        case "2":
            double resultadoCelsius = ConverterFahrenheitParaCelsius(temperatura);
            ExibirResultadoConversao(resultadoCelsius, "°C");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
ExecutarConversor();
*/



/*
static string LerNomeAluno()
{
    Console.WriteLine("Digite o nome do aluno: ");
    string nome = Console.ReadLine()!;
    return nome;
}

static double LerNota(string mensagem)
{
    Console.Write(mensagem);
    double nota = double.Parse(Console.ReadLine()!);
    return nota;
}

static double CalcularMedia(double nota1, double nota2, double nota3)
{
    return (nota1 + nota2 + nota3) / 3;
}

static string VerificarSituacao(double media)
{
    if (media >= 7)
    {
        return "Aprovado";
    }
    else if (media >= 5 && media < 7)
    {
        return "Em recuperação";
    }
    else
    {
        return "Reprovado";
    }
}

static void ExibirResultado(string nome, double media, string situacao)
{
    Console.WriteLine();
    Console.WriteLine($"Aluno(a): {nome}");
    Console.WriteLine($"Média final: {media}");
    Console.WriteLine($"Situação {situacao}");

}

static void ExecutarSistema()
{
    string nome = LerNomeAluno();

    double nota1 = LerNota("Nota 1: ");
    double nota2 = LerNota("Nota 2: ");
    double nota3 = LerNota("Nota 3: ");

    double media = CalcularMedia(nota1, nota2, nota3);

    string situacao = VerificarSituacao(media);

    ExibirResultado(nome, media, situacao);
}
ExecutarSistema();
*/



/*
static string Concatenar(string nome, string sobrenome)
{
    string nomeCompleto = nome + " " + sobrenome;
    return nomeCompleto;
}
string concatenado = Concatenar("Sâmia", "Takiuti");
Console.WriteLine(concatenado);
*/
/*
static void Concatenar()
{
    Console.Write("Digite o nome: ");
    string nome = Console.ReadLine();

    Console.Write("Digite o sobrenome: ");
    string sobrenome = Console.ReadLine();

    string nomeSobrenome = nome + " " + sobrenome;
    Console.WriteLine(nomeSobrenome);
}
*/



/*
static void ExecutarSistema()
{
    string cliente = LerNomeCliente();
    double valorCompra = LerValorCompra();
    double desconto = CalcularDesconto(valorCompra);
    double valorFinal = CalcularValorFinal(valorCompra, desconto);

    ExibirResumo(cliente, valorCompra, desconto, valorFinal);
}

static string LerNomeCliente()
{
    Console.Write("Digite o nome do cliente: ");
    string cliente = Console.ReadLine()!;
    return cliente;
}

static double LerValorCompra()
{
    Console.Write("Digite o valor da compra: ");
    double valorCompra = double.Parse(Console.ReadLine()!);
    return valorCompra;
}

static double CalcularDesconto(double valorCompra)
{
    double desconto = 0;

    if (valorCompra >= 200)
    {
        desconto = valorCompra * 0.15;
    }
    else
    {
        desconto = valorCompra * 0.05;
    }
    return desconto;
}

static double CalcularValorFinal(double valorCompra, double desconto)
{
    double valorFinal = valorCompra - desconto;
    return valorFinal;
}

static void ExibirResumo(string cliente, double valorCompra, double desconto, double valorFinal)
{
    Console.WriteLine($"Cliente: {cliente}");
    Console.WriteLine($"Valor da compra: R$ {valorCompra:F2}");
    Console.WriteLine($"Desconto: R$ {desconto:F2}");
    Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
}
ExecutarSistema();
*/



/*
static int LerNumeroTabuada()
{
    Console.Write("Digite o número da tabuada: ");
    int numero = int.Parse(Console.ReadLine()!);
    return numero;
}

static void ExibirTabuada(int numero)
{
    Console.WriteLine();
    int contador = 1;

    while (contador <= 10)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }

    Console.WriteLine();
}

static string LerContinuacao()
{
    Console.Write("Deseja consultar outra tabuada? s/n: ");
    string resposta = Console.ReadLine()!;

    return resposta;
}

static bool DesejaContinuar(string resposta)
{
    if (resposta == "s" || resposta == "S")
    {
        return true;
    }
    else
    {
        return false;
    }
}

static void ExecutarTabuada()
{
    Console.Clear();

    int numero = LerNumeroTabuada();

    ExibirTabuada(numero);

    string resposta = LerContinuacao();

    if (DesejaContinuar(resposta))
    {
        ExecutarTabuada();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Programa encerrado.");
    }
}
ExecutarTabuada();
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





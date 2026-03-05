//Console.Clear();

//Requisito 1: Nossa calculadora deve permitir a soma de dois números.
//Requisito 2: Nossa calculadora deve permitir a subtração de dois números.
//Requisito 3: Nossa calculadora deve permitir a multiplicação de dois números.
//Requisito 4: Nossa calculadora deve permitir a divisão de dois números.
//Requisito 5: Nossa calculadora deve permitir a execução de múltiplas operações.

bool deveContinuar = true; //ATRIBUINDO VALOR

//LOOP 
while (deveContinuar == true) //COMPARANDO 
{

    Console.WriteLine("================");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("================");

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("S - Sair");

    Console.WriteLine();

    Console.Write("Selecione uma operação válida: ");
    string operacaoSelecionada = Console.ReadLine()!;

    if (operacaoSelecionada == "S")
    {
        deveContinuar = false;

        continue; //IGNORA O RESTANTE E OLHA PARA A VARIÁVEL "deveContinuar" novamente.
    }


    Console.Write("Digite o primeiro número: ");
    string strPrimeiroNumero = Console.ReadLine()!;

    Console.Write("Digite o segundo número: ");
    string strSegundoNumero = Console.ReadLine()!;

    Console.WriteLine();

    Console.WriteLine($"O primeiro número digitado foi: {strPrimeiroNumero}");
    Console.WriteLine($"O segundo número digitado foi: {strSegundoNumero}");

    Console.WriteLine();

    bool primeiroNumeroVazio = string.IsNullOrEmpty(strPrimeiroNumero);
    bool segundoNumeroVazio = string.IsNullOrEmpty(strSegundoNumero);

    if (primeiroNumeroVazio || segundoNumeroVazio)
    {
        Console.WriteLine("Digite um número válido");
        Console.ReadLine();

        continue;
    }

    //INT = NÚMERO INTEIRO
    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

    decimal resultado;

    //ESTRUTURAS CONDICIONAIS

    if (operacaoSelecionada == "1")
    {
        resultado = primeiroNumero + segundoNumero;
    }

    else if (operacaoSelecionada == "2")
    {
        resultado = primeiroNumero - segundoNumero;
    }

    else if (operacaoSelecionada == "3")
    {
        resultado = primeiroNumero * segundoNumero;
    }
    else
    {
        if (segundoNumero == 0)
        {
            Console.WriteLine("Não é possível fazer uma divisão por zero. Tente novamente.");

            return; //ENTENDE QUE É PARA SAIR DO ESCOPO E IGNORAR TUDO DEPOIS DO RETURN
        }
        else
        {
            resultado = primeiroNumero / segundoNumero;
        }

    }

    Console.WriteLine($"A operação dos dois números resulta em: {resultado}");

    Console.ReadLine();

}


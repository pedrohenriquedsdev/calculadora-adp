//Console.Clear();

//Requisito 1: Nossa calculadora deve permitir a soma de dois números.
//Requisito 2: Nossa calculadora deve permitir a subtração de dois números.
//Requisito 3: Nossa calculadora deve permitir a multiplicação de dois números.
//Requisito 4: Nossa calculadora deve permitir a divisão de dois números.
//Requisito 5: Nossa calculadora deve permitir a execução de múltiplas operações.
//V2
//Requisito 6: Nossa calculadora deve dar a possibilidade de produizir a tabuada de um número informado 
//Requisito 7: Nossa calculadora deve dar a possibilidade de visualizar o histórico de operações

bool deveContinuar = true;


while (deveContinuar == true) //COMPARANDO 
{

    Console.WriteLine("================");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("================");

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("S - Sair");

    Console.WriteLine();

    Console.Write("Selecione uma operação válida: ");
    string operacaoSelecionada = Console.ReadLine()!;

    if (operacaoSelecionada == "S")
    {
        deveContinuar = false;

        continue; //IGNORA O RESTANTE E OLHA PARA A VARIÁVEL "deveContinuar" novamente.
    }

    if (operacaoSelecionada == "5")
    {
        Console.Write("Digite um número que deseja gerar a tabuada: ");
        int numeroTabuada = Convert.ToInt32(Console.ReadLine());


        //para cada
        //1. Contador/iterador...
        //2. enqunato a condição for verdadeira...
        //3. Iteração da variável contadora...
        for (int contador = 1; contador <= 10; contador++)
        {
            int resultadoTabuada = numeroTabuada * contador;
            string operacaoTabuada = numeroTabuada + " x " + contador + " = " + resultadoTabuada;

            Console.WriteLine(operacaoTabuada);

        }

        Console.ReadLine();
        continue;
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

    //DECIMAL = Números quebrados
    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

    decimal resultado;

    switch (operacaoSelecionada)
    {
        case "1":
            resultado = primeiroNumero + segundoNumero;
            break;

        case "2":
            resultado = primeiroNumero - segundoNumero;
            break;

        case "3":
            resultado = primeiroNumero * segundoNumero;
            break;

        case "4":
            if (segundoNumero == 0)
            {
                Console.WriteLine("Não é possível fazer uma divisão por zero. Tente novamente.");

                return; //ENTENDE QUE É PARA SAIR DO ESCOPO E IGNORAR TUDO DEPOIS DO RETURN
            }

            resultado = primeiroNumero / segundoNumero;
            break;

        default:
            Console.WriteLine("Selecione uma operação válida");
            Console.ReadLine();
            continue;

    }


    Console.WriteLine($"A operação dos dois números resulta em: {resultado}");

    Console.ReadLine();

}


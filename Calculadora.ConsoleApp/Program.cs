string[] historicoDeOperacoes = new string[100];
int totalDeOperacoes = 0;

bool usuarioQuerContinuar = true;

while (usuarioQuerContinuar)
{
    Console.Clear();

    //MENU DE INICIALIZAÇÃO
    Console.WriteLine("==========================================================\n");
    Console.WriteLine("BEM-VINDO! A NOVA VERSÃO DA CALCULADORA JÁ ESTÁ DISPONÍVEL.");
    Console.WriteLine("\n==========================================================");

    Console.Write("\nPressione a tecla ENTER para ABRIR o MENU DE OPERAÇÕES...");
    Console.ReadLine();
    Console.Clear();

    Console.WriteLine("==========================================================\n");
    Console.WriteLine("MENU DE OPERAÇÕES - Selecione uma das opcões abaixo");
    Console.WriteLine("\n==========================================================");

    Console.WriteLine("\n=====================");
    Console.WriteLine("1 ---> Soma");
    Console.WriteLine("2 ---> Subtração");
    Console.WriteLine("3 ---> Multiplicação");
    Console.WriteLine("4 ---> Divisão");
    Console.WriteLine("5 ---> Tabuada");
    Console.WriteLine("6 ---> Histórico de Operações");
    Console.WriteLine("S ---> Sair");
    Console.WriteLine("=====================\n");

    Console.Write("Operação selecionada: ");
    string operacaoSelecionada = Console.ReadLine()!;
    operacaoSelecionada = operacaoSelecionada.ToUpper();

    if (operacaoSelecionada == "6")
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Histórico de Operações");
        Console.WriteLine("-----------------------------------------");

        if (totalDeOperacoes == 0)
        {
            Console.WriteLine("Nenhuma operação registrada ainda.");
        }
        else
        {
            for (int i = 0; i < totalDeOperacoes; i++)
            {
                Console.WriteLine(historicoDeOperacoes[i]);
            }
        }

        Console.ReadLine();
        continue;
    }

    else if (operacaoSelecionada == "5")
    {
        Console.Clear();
        Console.WriteLine("===========================================");
        Console.Write("Insira o número que deseja conferir a tabuada: ");
        int numeroTabuada = int.Parse(Console.ReadLine()!);
        Console.WriteLine("===========================================");

        Console.WriteLine("\n=============");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numeroTabuada} x {i} = {numeroTabuada * i}");
        }
        Console.WriteLine("===============");

        Console.ReadLine();
        continue;
    }

    //TRATANDO VALORES INVÁLIDOS
    else if (operacaoSelecionada == "S")
    {
        Console.Clear();
        Console.WriteLine("==============================================================");
        Console.WriteLine($"OBBRIGADO POR USAR NOSSA CALCULADORA! Te esperamos em breve...");
        Console.WriteLine("==============================================================");

        Console.ReadLine();
        break;
    }

    //INSERINDO VALORES
    Console.Clear();
    Console.WriteLine("==========================");
    Console.WriteLine($"Operação selecionada == {operacaoSelecionada}");
    Console.WriteLine("==========================\n");

    Console.WriteLine("=====================");
    Console.Write("Insira o 1° número: ");
    double num1 = double.Parse(Console.ReadLine()!);
    Console.Write("Insira o 2° número: ");
    double num2 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("=====================");

    double resultado = 0;
    string operacaoTexto = "";

    //TRATANDO VALORES VÁLIDOS

    switch (operacaoSelecionada)
    {
        case "1":
            resultado = num1 + num2;
            operacaoTexto = $"{num1} + {num2} = {resultado}";
            break;

        case "2":
            resultado = num1 - num2;
            operacaoTexto = $"{num1} - {num2} = {resultado}";
            break;

        case "3":
            resultado = num1 * num2;
            operacaoTexto = $"{num1} x {num2} = {resultado}";
            break;

        case "4":
            if (num2 == 0)
            {
                Console.WriteLine("\n===========================================================");
                Console.WriteLine("Não é possivel DIVIDIR por ZERO. Insira um 2° valor VÁLIDO!");
                Console.WriteLine("===========================================================");
                Thread.Sleep(3500);
                continue;
            }

            resultado = num1 / num2;
            operacaoTexto = $"{num1} / {num2} = {resultado}";
            break;

        default:
            Console.WriteLine("OPERAÇÃO INVÁLIDA! Por favor, selecione uma opção válida!");
            Console.ReadLine();
            continue;
    }

    if (totalDeOperacoes < historicoDeOperacoes.Length)
    {
        historicoDeOperacoes[totalDeOperacoes] = operacaoTexto;
        totalDeOperacoes++;
    }

    Console.WriteLine("\n==================");
    Console.WriteLine($"Resultado: {resultado}");
    Console.WriteLine("==================");
    Console.ReadLine();
}






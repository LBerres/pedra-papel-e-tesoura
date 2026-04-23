using System.Security.Cryptography;

const int ESCOLHA_PEDRA = 1;
const int ESCOLHA_PAPEL = 2;
const int ESCOLHA_TESOURA = 3;

// 1. Escolha do Jogador
int escolhaJogador;

while (true) // Loop Infinito
{

    do // Vai Executar Pelo Menos Uma Vez
    {
        Console.Clear();
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Pedra, Papel, Tesoura");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("1 - Pedra");
        Console.WriteLine("2 - Papel");
        Console.WriteLine("3 - Tesoura");
        Console.WriteLine("-----------------------------");

        Console.Write("Digite Uma Opção Válida: ");
        string? strEscolhadoJogador = Console.ReadLine();

        if (strEscolhadoJogador == "1" || strEscolhadoJogador == "2" || strEscolhadoJogador == "3")
        {
            escolhaJogador = Convert.ToInt32(strEscolhadoJogador);
            break; // Sai do Loop
        }
    } while (true);

    // 2. Escolha do Computador
    int escolhaComputador = RandomNumberGenerator.GetInt32(1, 4); // Gera um Número Aleatório Entre 1 e 3 (4 é Exclusivo)

    // 3. Comparação dos Valores

    if (escolhaJogador == ESCOLHA_PEDRA)
    {
        Console.Write("Pedra x ");
        if (escolhaComputador == ESCOLHA_PAPEL)
        {
            Console.WriteLine("Papel");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Papel Envolve Pedra!");
            Console.WriteLine();
            Console.WriteLine("Computador Venceu!");
        }
        else if (escolhaComputador == ESCOLHA_TESOURA)
        {
            Console.WriteLine("Tesoura");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Pedra Quebra Tesoura!");
            Console.WriteLine();
            Console.WriteLine("Você Venceu!");
        }
        else // Empate
        {
            Console.WriteLine("Pedra");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Empate!");
        }
    }
    else if (escolhaJogador == ESCOLHA_PAPEL)
    {
        Console.Write("Papel x ");
        if (escolhaComputador == ESCOLHA_PEDRA)
        {
            Console.WriteLine("Pedra");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Papel Envolve Pedra!");
            Console.WriteLine();
            Console.WriteLine("Você Venceu!");
        }
        else if (escolhaComputador == ESCOLHA_TESOURA)
        {
            Console.WriteLine("Tesoura");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Tesoura Corta Papel!");
            Console.WriteLine();
            Console.WriteLine("Computador Venceu!");
        }
        else // Empate
        {
            Console.WriteLine("Papel");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Empate!");
        }
    }
    else if (escolhaJogador == ESCOLHA_TESOURA)
    {
        Console.Write("Tesoura x ");
        if (escolhaComputador == ESCOLHA_PEDRA)
        {
            Console.WriteLine("Pedra");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Pedra Quebra Tesoura!");
            Console.WriteLine();
            Console.WriteLine("Computador Venceu!");
        }
        else if (escolhaComputador == ESCOLHA_PAPEL)
        {
            Console.WriteLine("Papel");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Tesoura Corta Papel!");
            Console.WriteLine();
            Console.WriteLine("Você Venceu!");
        }
        else // Empate
        {
            Console.WriteLine("Tesoura");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Empate!");
        }

        Console.Write("Deseja Jogar Novamente? (S/N): ");
        string? resposta = Console.ReadLine().ToUpper();

        if (resposta != "S")
        {
            Console.WriteLine("Obrigado por Jogar!");
            break;
        }
    }
}
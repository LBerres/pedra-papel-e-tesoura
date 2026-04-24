namespace PedraPapelTesoura.ConsoleApp.Entidades;

public static class Jogo
{
    public static void CompararEscolhas(int escolhaJogador, int escolhaComputador)
    {
        const int ESCOLHA_PEDRA = 1;
        const int ESCOLHA_PAPEL = 2;
        const int ESCOLHA_TESOURA = 3;

        if (escolhaJogador == ESCOLHA_PEDRA)
        {
            Console.WriteLine("-----------------------------");
            Console.Write("Pedra x ");
            if (escolhaComputador == ESCOLHA_PAPEL)
            {
                Console.WriteLine("Papel");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Papel Envolve Pedra!");
                Console.WriteLine();
                Console.WriteLine("Computador Venceu!");
            }
            else if (escolhaComputador == ESCOLHA_TESOURA)
            {
                Console.WriteLine("Tesoura");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Pedra Quebra Tesoura!");
                Console.WriteLine();
                Console.WriteLine("Você Venceu!");
            }
            else // Empate
            {
                Console.WriteLine("Pedra");
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
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Papel Envolve Pedra!");
                Console.WriteLine();
                Console.WriteLine("Você Venceu!");
            }
            else if (escolhaComputador == ESCOLHA_TESOURA)
            {
                Console.WriteLine("Tesoura");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Tesoura Corta Papel!");
                Console.WriteLine();
                Console.WriteLine("Computador Venceu!");
            }
            else // Empate
            {
                Console.WriteLine("Papel");
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
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Pedra Quebra Tesoura!");
                Console.WriteLine();
                Console.WriteLine("Computador Venceu!");
            }
            else if (escolhaComputador == ESCOLHA_PAPEL)
            {
                Console.WriteLine("Papel");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Tesoura Corta Papel!");
                Console.WriteLine();
                Console.WriteLine("Você Venceu!");
            }
            else // Empate
            {
                Console.WriteLine("Tesoura");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Empate!");
            }
        }
    }
}

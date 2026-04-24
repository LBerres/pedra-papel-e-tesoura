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
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.Write("Pedra x ");
            if (escolhaComputador == ESCOLHA_PAPEL)
            {
                Console.WriteLine("Papel");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Foi Embrulhada pra Viagem!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Computador Venceu!");
                Console.WriteLine();
            }
            else if (escolhaComputador == ESCOLHA_TESOURA)
            {
                Console.WriteLine("Tesoura");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Amassou Sem Dó!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Você Venceu!");
                Console.WriteLine();
            }
            else // Empate
            {
                Console.WriteLine("Pedra");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Quebraram… Mas o Orgulho Ficou Intacto!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Empate!");
                Console.WriteLine();
            }
        }
        else if (escolhaJogador == ESCOLHA_PAPEL)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.Write("Papel x ");
            if (escolhaComputador == ESCOLHA_PEDRA)
            {
                Console.WriteLine("Pedra");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Dominou na Estratégia!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Você Venceu!");
                Console.WriteLine();
            }
            else if (escolhaComputador == ESCOLHA_TESOURA)
            {
                Console.WriteLine("Tesoura");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Cortado em 4K!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Computador Venceu!");
                Console.WriteLine();
            }
            else // Empate
            {
                Console.WriteLine("Papel");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Assinaram um Acordo de Paz!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Empate!");
                Console.WriteLine();
            }
        }
        else if (escolhaJogador == ESCOLHA_TESOURA)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.Write("Tesoura x ");
            if (escolhaComputador == ESCOLHA_PEDRA)
            {
                Console.WriteLine("Pedra");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Cancelada Pela Realidade!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Computador Venceu!");
                Console.WriteLine();
            }
            else if (escolhaComputador == ESCOLHA_PAPEL)
            {
                Console.WriteLine("Papel");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Deixou em Pedacinhos!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Você Venceu!");
                Console.WriteLine();
            }
            else // Empate
            {
                Console.WriteLine("Tesoura");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Ficaram se Encarando Igual Duelo no Velho Oeste!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Empate!");
                Console.WriteLine();
            }
        }
    }
}

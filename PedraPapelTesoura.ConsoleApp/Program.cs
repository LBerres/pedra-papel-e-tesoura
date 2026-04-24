using PedraPapelTesoura.ConsoleApp.Entidades;
namespace PedraPapelTesoura.ConsoleApp;

class Program
{
    // Ponto de Entrada
    static void Main(string[] args)
    {
        while (true) // Loop Infinito
        {
            int escolhaJogador = Jogador.ObterEscolhaJogador();

            int escolhaComputador = Computador.ObterEscolhaComputador();

            Jogo.CompararEscolhas(escolhaJogador, escolhaComputador);

            Console.WriteLine("-----------------------------");
            Console.Write("Deseja Jogar Novamente? (S/N): ");
            string? resposta = Console.ReadLine()?.ToUpper();

            if (resposta != "S")
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Obrigado por Jogar!");
                break;
            }
        }
    }
}
using PedraPapelTesoura.ConsoleApp.Entidades;
namespace PedraPapelTesoura.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int escolhaJogador = Jogador.ObterEscolhaJogador();

            int escolhaComputador = Computador.ObterEscolhaComputador();

            Jogo.CompararEscolhas(escolhaJogador, escolhaComputador);

            MesagemFinal.MensagemFinal();
        }
    }
}
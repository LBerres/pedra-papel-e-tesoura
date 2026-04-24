namespace PedraPapelTesoura.ConsoleApp.Entidades;

public static class Jogador
{
    public static int ObterEscolhaJogador()
    {
        while (true) // Loop Infinito
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
                return Convert.ToInt32(strEscolhadoJogador);
            }
        }
    }
}

namespace PedraPapelTesoura.ConsoleApp.Entidades;

public class MesagemFinal
{
    public static void MensagemFinal()
    {
        Console.WriteLine("-----------------------------");
        Console.Write("Deseja Jogar Novamente? (S/N): ");
        string? resposta = Console.ReadLine()?.ToUpper();

        if (resposta != "S")
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Obrigado por Jogar!");
            Console.WriteLine("Aperte ENTER para Sair...");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
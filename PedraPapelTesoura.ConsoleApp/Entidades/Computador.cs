using System.Security.Cryptography;
namespace PedraPapelTesoura.ConsoleApp.Entidades;

public static class Computador
{
    public static int ObterEscolhaComputador()
    {
        return RandomNumberGenerator.GetInt32(1, 4); // Gera um Número Aleatório Entre 1 e 3 (4 é Exclusivo)
    }
}
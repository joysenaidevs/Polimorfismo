using System;
using Polimorfismo.classe;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan jogador = new MegaMan();
            Console.WriteLine($"Jogador 1 = {jogador.Correr()}");
            
            Zero jogador1 = new Zero();
            Console.WriteLine($"Jogador 2 = {jogador1.Correr()}");
        }
    }
}

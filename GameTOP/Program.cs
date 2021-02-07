using GameTOP.Lib;
using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(
                 new Jogador2("Luiz"),
                 new Jogador("Mario")
                );
            jogo.IniciarJogo();
        }
    }
}

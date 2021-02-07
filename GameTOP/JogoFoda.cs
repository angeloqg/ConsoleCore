using System;
using GameTOP.Interface;

namespace GameTOP
{
    class JogoFoda{
        private readonly IJogador _jogador1;
        private readonly IJogador _jogador2;
        public JogoFoda(IJogador jogador1, IJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }
        public void IniciarJogo(){
            Console.WriteLine(_jogador1.Corre());
            Console.WriteLine(_jogador1.Chuta());    
            Console.WriteLine(_jogador1.Passe());    

            Console.WriteLine(_jogador2.Corre());
            Console.WriteLine(_jogador2.Chuta());    
            Console.WriteLine(_jogador2.Passe());                          
        }
    }
}
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        private readonly string _jogador;
        public Jogador2(string jogador = "Ronaldo")
        {
            _jogador = jogador;
        }

        public string Chuta()
        {
            return $"{_jogador} está pateando";
        }

        public string Corre()
        {
            return $"{_jogador} está corriendo";
        }

        public string Passe()
        {
            return $"{_jogador} está passeando";
        }
    }
}
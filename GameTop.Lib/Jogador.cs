using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador : IJogador
    {
        private readonly string _Nome;

        public Jogador(string nome)
        {
            _Nome = nome;
        }

        // Chuta
        public string Chuta()
        {
            return $"{_Nome} está Chutando";
        }

        // Corre
        public string Corre()
        {
            return $"{_Nome} está Correndo";  
        }

        // Passe
        public string Passe()
        {
            return $"{_Nome} está passando";  
        }
    }
}
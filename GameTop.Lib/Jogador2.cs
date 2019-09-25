

using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona está  Chutando \n";
        }

        public string Corre()
        {
            return "Maradona esta Correndo \n";
        }

        public string Toca()
        {
            return "Maradona esta Tocando \n";
        }
    }
}
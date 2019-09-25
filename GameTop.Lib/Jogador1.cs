
using GameTop.Interface;
namespace GameTop.Lib
{
    public class Jogador1 : iJogador

    {
        public string Chuta()
        {
            return "Ronaldo está Chutando \n";
        }

        public string Corre()
        {
            return "Ronaldo está Correndo \n";
        }

        public string Toca()
        {
            return "Ronaldo está Tocando \n";
        }
    }

}
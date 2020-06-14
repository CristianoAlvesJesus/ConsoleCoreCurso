using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "teste chuta";
        }

        public string Corre()
        {
            return "teste corre";
        }

        public string Passe()
        {
            return "teste passe";
        }
    }
}
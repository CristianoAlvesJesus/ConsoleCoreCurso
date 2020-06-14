using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Maradona estas Pateando  \n";
        }

        public string Corre()
        {
            return "Marador estas corriendo \n";
        }

        public string Passe()
        {
            return "Maradona esta pasando  \n";
        }
    }
}
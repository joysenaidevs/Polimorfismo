namespace Polimorfismo.classe
{
    public abstract class Player
    {
        private float velocidade;
        private float forcaPulo;
        public virtual string Correr(){
            return "Correr em velocidade 1x";

        }

        public string VirtualPular(){
            return "";
        }
        
       
    }
}
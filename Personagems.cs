namespace AtributosEMetodos
{
    public class Personagems
    {
        public string nome;
        public int pontoVida;

        public int Atacar(){
            int dano = 10;

            return dano;
        }

        public int Defender(){
            int defesa = 8;

            return defesa;
        }
    }
}
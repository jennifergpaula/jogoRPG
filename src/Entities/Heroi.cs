namespace JogoRPG.src.Entities
{
    public class Heroi
    {
        public Heroi(string nome, string classeFantastica)
        {
            this.nome = nome;
            this.classeFantastica = classeFantastica;
            this.nivel = 1;
            this.pontosDeVida = 50;
            this.pontosDeMagia = 100;
            this.nomeDoPet = "cachorro";

        }
        public string nome { get; set; }
        public int nivel { get; set; }
        public int pontosDeVida { get; set; }
        public int pontosDeMagia { get; set; }
        public string classeFantastica { get; set; }
        public string nomeDoPet { get; set; }
        public int ValorUltimoAtaque { get; set;}

        public override string ToString(){
            return "Meu nome é " + this.nome + "\n"
                + "Nível: " + this.nivel + "\n"
                + "Classe: " + this.classeFantastica + "\n"
                + "Ponto de vida: " + this.pontosDeVida + "\n"
                + "Ponto de Magia: " + this.pontosDeMagia + "\n";
        }

        public virtual string Atacar(){
            Random dado = new Random();
            int forcaDoAtaque = this.nivel + dado.Next(1,20);
            this.ValorUltimoAtaque = forcaDoAtaque;

            return this.nome + " ataca com a sua espada e da " + forcaDoAtaque + " de dano";
        }

        public void ReceberDano(int danoRecebido){
            this.pontosDeVida -= danoRecebido;
        }

    }
}
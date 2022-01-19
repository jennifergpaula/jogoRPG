namespace JogoRPG.src.Entities
{
    public class Mago : Heroi
    {
        public Mago(string nome, string classeFantastica) : base(nome, classeFantastica)
        {
            this.nome = nome;
            this.classeFantastica = classeFantastica;
            this.nivel = 1;
            this.pontosDeVida = 50;
            this.pontosDeMagia = 100;
            this.nomeDoPet = "gato";
        }
          public override string Atacar(){
            Random dado = new Random();
            int forcaDoAtaque = this.nivel + dado.Next(1,10);
            this.ValorUltimoAtaque = forcaDoAtaque;

            return this.nome + " ataca com a sua magia e da " + forcaDoAtaque + " de dano";
          }
        
        public string Atacar(int bonus) {
            Random dado = new Random();
            int forcaDoAtaque = this.nivel + dado.Next(1,10) + bonus;
            this.ValorUltimoAtaque = forcaDoAtaque;

            return this.nome + " ataca com seu cajado, por isso recebe um bônus e da " + forcaDoAtaque + " de dano";
        }
    }
}
using JogoRPG.src.Entities;

namespace JogoRPG
{
    internal class Inimigo : Heroi
    {
        public Inimigo(string nome, string classeFantastica) : base(nome, classeFantastica)
        {
            this.nome = nome;
            this.classeFantastica = classeFantastica;
            this.nivel = 1;
            this.pontosDeVida = 120;
            this.pontosDeMagia = 0;
            this.nomeDoPet = "humano";
        }
          public override string Atacar(){
            Random dado = new Random();
            int forcaDoAtaque = this.nivel + dado.Next(1,15);
            this.ValorUltimoAtaque = forcaDoAtaque;

            return this.nome + " ataca com foice e da " + forcaDoAtaque + " de dano";
          }
        
    }
}
using JogoRPG.src.Entities;

namespace JogoRPG
{
class Program
    {
         static void Main(string[] args)
        {
            Heroi arus = new Heroi("Arus", "Guerreiro");
            Mago wedge = new Mago("Wedge", "Mago Negro");
            Inimigo Mala = new Inimigo("Mala", "Zumbi");

           System.Console.WriteLine(arus.Atacar());
           System.Console.WriteLine(Mala.Atacar());

            if(arus.ValorUltimoAtaque == Mala.ValorUltimoAtaque){
            System.Console.WriteLine("Empate! Ambos receberam dano de " + arus.ValorUltimoAtaque);
            } else if(arus.ValorUltimoAtaque > Mala.ValorUltimoAtaque){
                Mala.ReceberDano(arus.ValorUltimoAtaque - Mala.ValorUltimoAtaque);
                System.Console.WriteLine(arus.nome + " venceu esse round");
            } else{
                arus.ReceberDano(Mala.ValorUltimoAtaque - arus.ValorUltimoAtaque);
                System.Console.WriteLine(Mala.nome + " venceu esse round");
            }


            Console.WriteLine(arus.ValorUltimoAtaque);
            Console.WriteLine(Mala.ValorUltimoAtaque);
           
        }
        
    }

}
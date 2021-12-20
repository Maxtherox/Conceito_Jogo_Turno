using System;
using Game01.Entities;


namespace Game01
{
    class Program
    {
       

        static void Main(string[] args)
        {
         Cristaos Aella = new Cristaos ("Aella de Nortumbria","Cristão",  "31");
        Vikings Ragnar = new Vikings ("Ragnar Lothbrok", "Vikinger", "28");

       // System.Console.WriteLine(Ragnar);
     //   System.Console.WriteLine(Aella);
       

        Console.WriteLine(Aella.Atacar(20));
        Console.WriteLine(Ragnar.Atacar(20));

        if( Ragnar.LastHit == Aella.LastHit){
          Console.WriteLine (" Empate, ambos os guerreiros deram o dano de: " + Ragnar.LastHit);
         } 
         else if ( Ragnar.LastHit > Aella.LastHit )
         {
         Aella.ReceberDano(Ragnar.LastHit - Aella.Health);
             Console.WriteLine(Ragnar.nome + " Venceu esse round");
        }
        else
        {
            Ragnar.ReceberDano(Aella.LastHit - Ragnar.Health);
            Console.WriteLine(Aella.nome + " Venceu esse round");
                      
        }
   
        

        }
    }
}
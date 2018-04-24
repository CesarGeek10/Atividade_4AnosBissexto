using System;

namespace AnoBissexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Olá, Esse é o Software Que Indicará os Anos Bissexto");

            int qtd=0;
            for(int i=1910; i <=2018; i++){
                if(i%4==0){
                    Console.WriteLine(i + " - Este Ano é Bissexto");
                    qtd++;

                }
            }

            Console.WriteLine(qtd + " - Anos Bissexto");
        }
    
    }
}

using System;
using System.Collections.Generic;

namespace TrabalhandoDicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string gravar;
            string digitar; 

            Dictionary<string, string> frase = new Dictionary<string, string>();

            Console.WriteLine("--------[Aprender]----------");
            while(n < 1){
                Console.WriteLine("Usuário: ");
                string esc = Console.ReadLine();

                if(esc == "Aprender"){
                    Console.WriteLine("Quando digitarem: ");
                    gravar = Console.ReadLine();
                    Console.WriteLine("Devo digitar: ");
                    digitar = Console.ReadLine();

                    frase.Add(gravar, digitar);
                }
                else{
                    gravar = esc;
                    Console.WriteLine("Programa: "+frase[gravar]);
                }          
            }
             Console.WriteLine("Fim da sessão"); 
        }
    }
}

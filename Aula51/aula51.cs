using System;

class Aula51{
    static void Main(string[] args){
        
        if(args.Length > 0){
            Console.WriteLine("Qtde de args: {0}", args.Length);
        } else {

            Console.WriteLine("Não foi passado args");
        }
    }
}
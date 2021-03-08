using System;
using System.Collections.Generic;
 class Aula59{
     static void Main(){
         

        // string[] vs = {"Carro", "Moto", "Avião", "Navio"};
        Queue<string>veiculos = new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        string v = "Barco";
        if(veiculos.Contains(v)) {
            Console.WriteLine("Tem {0}!", v);
        } else {
            Console.WriteLine("Não Tem {0}!", v);
        }
        
        // veiculos.Clear();

        // Console.WriteLine("Primeiro veiculo {0}", veiculos.Dequeue()); //retorna primeiro elemento mas retira ele da queue


        Console.WriteLine("Primeiro veiculo {0}", veiculos.Peek()); //retorna primeiro elemento
        
        foreach(string vs in veiculos){
            Console.WriteLine("Veiculo: {0}", vs);
        }
        Console.WriteLine("Tamanho da queue: {0}", veiculos.Count);
        Console.WriteLine(veiculos[2]); //impossivel 

     }
}
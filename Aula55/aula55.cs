using System;
using System.Collections.Generic;

class Aula55{
     static void Main(){
        Dictionary <int, string> veiculos = new Dictionary <int, string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Moto");
        veiculos.Add(20, "Avião");
        veiculos.Add(25, "Bike");

        // veiculos.Clear();

        veiculos.Remove(25);

        Console.WriteLine("tamanho do Dictionary: {0}", veiculos.Count);
        
        int chave = 25;
        if(veiculos.ContainsKey(chave)) {
            Console.WriteLine("A chave {0} está na coleção",chave);
        } else {
            Console.WriteLine("A chave {0} não está na coleção",chave);

        }

        veiculos[25] = "Navio";

        string valor = "Navio";
        if(veiculos.ContainsValue(valor)) {
            Console.WriteLine("O valor {0} está na coleção",valor);
        } else {
            Console.WriteLine("O valor {0} não está na coleção",valor);

        }

        foreach (KeyValuePair<int,string> v in veiculos)
        {
            Console.WriteLine(v.Key); //v.Value
        }

        //ouuu
        // Dictionary <int, string>.ValueCollection valores = veiculos.Values;

        // foreach (String v in valores)
        // {
        //     Console.WriteLine(v);
        // }
     }
}
using System;
using System.Collections.Generic;
 class Aula57{
     static void Main(){
        List<string>carros = new List<string>();
        // List<string>carros2 = new List<string>();
        string[] carros2 = new string [10];

        carros.Add("Ferrari");
        carros.Add("Golf");
        carros.Add("Clio");
        carros.Add("KIA");
        carros.Add("Golf");

        // carros2.AddRange(carros);

        if(carros.Contains("Clio")) {
            Console.WriteLine("Tem clio!");
        } else {
            Console.WriteLine("Não Tem clio!");

        }

        carros.CopyTo(carros2,2);

        carros.Insert(1, "Fusca");
        carros.Remove("Fusca");

        int pos2 = carros.LastIndexOf("Golf");

        // carros.RemoveAt(0);

        // carros.Reverse();
        carros.Sort();

        int tamanho = carros.Count;
        carros.Capacity = 15;
        int cap = carros.Capacity;


        Console.WriteLine("Total de carros: {0}", tamanho);
        Console.WriteLine("Cap de carros: {0}", cap);


        foreach(string c in carros) {
            Console.WriteLine("Carro: {0}", c);
        }
    

        string h = "Clio";
        int pos;
        pos = carros.IndexOf(h);
        Console.WriteLine(pos);
        Console.WriteLine("ultimo Golf: {0}",pos2);
    }   
}
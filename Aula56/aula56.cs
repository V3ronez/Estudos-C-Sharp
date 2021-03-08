using System;
using System.Collections.Generic;

class Aula56{
     static void Main(){
        
        LinkedList <string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Moto");

        transp.AddLast("Bike");


        LinkedListNode<string>no;
        no = transp.FindLast("Moto");
        transp.AddAfter(no, "skate");
        
        no = transp.FindLast("Moto");
        transp.AddBefore(no, "patins");

        //remove
        // transp.Clear();
        if(transp.Find("Carro") == null) {
            Console.WriteLine("não encontrado");
        } else {
            Console.WriteLine("encontrado!");
        };

        // transp.Remove("Moto");
        transp.RemoveFirst();
        transp.RemoveLast();

        foreach(string t in transp){
            Console.WriteLine("Transporte: {0}", t);
        }
    }
}
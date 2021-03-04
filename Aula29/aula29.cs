using System;

public class Jogador{

    public int energia;        //int e bool sao propriedades || variaveis;
    bool vivo;

    public string nome;

   public Jogador(string n){ //Construtor
        energia = 100;
        vivo = true;
        nome = n;
    }

    ~Jogador(){ //Destrutor
        Console.WriteLine("Jogador foi de beise");
    }
}

class Aula28
{
    static void Main()
    {
        string nome;
        Console.Write("Digite o nome do jogador 1: ");
        nome = Console.ReadLine();


        Jogador j1 = new Jogador(nome); //novo objeto da class jogador 
        Jogador j2 = new Jogador("Giga");  
       
      

    Console.WriteLine("Energia do jogador {0}: {1}",j1.nome, j1.energia);
    Console.WriteLine("Energia do jogador {0}: {1}",j2.nome, j2.energia);
    }

}
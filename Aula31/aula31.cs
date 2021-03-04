using System;

static public class Jogador
{

    static public int energia;        //int e bool sao propriedades || variaveis;
    static bool vivo;

    static public string nome;

    static public void iniciar(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }


    static public void info()
    {
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("Energia jogador: {0}", energia);
        Console.WriteLine("Estado jogador: {0}\n", vivo);
    }

}

class inimigo
{
    static public bool alert;
    public string name;

    public inimigo(string n)
    {
        alert = false;
        name = n;
    }

    public void infoInimigo()
    {
        Console.WriteLine(name);
        Console.WriteLine(alert);
        Console.WriteLine("---------------------");
    }
}

class Aula31
{
    static void Main()
    {

        Jogador.iniciar("Henrique");
        Jogador.info();

        inimigo i1 = new inimigo("Carlos Paçoca");
        inimigo i2 = new inimigo("Paçoca");
        inimigo i3 = new inimigo("coca-cola");

        inimigo.alert = true;

        i1.infoInimigo();
        i2.infoInimigo();
        i3.infoInimigo();
    }

}
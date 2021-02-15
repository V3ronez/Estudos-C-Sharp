using System;
class Aula6
{
    static void Main()
    {
        // int n1, n2, n3;

        // n1 = 10;
        // n2 = 20;
        // n3 = 30;

        // Console.WriteLine("n1={0}\nn2={1}\nn3=\t{2}", n1, n2, n3);

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto.....:{0,15}", produto);
        Console.WriteLine("Val.Compra..:{0,15:c}", valorCompra); // sifrão
        Console.WriteLine("Lucro.......:{0,15:p}", lucro); //porcentagem
        Console.WriteLine("Val.Venda...:{0,15:c}", valorVenda);
    }
}
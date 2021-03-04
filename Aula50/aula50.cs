using System;

delegate int Op(int n1, int n2);
class Mat {
    public static int soma(int n1 , int n2){
        return n1 + n2;
    }


    public static int mult(int n1, int n2) {
        return n1 * n2;
    }
    }

class Aula47
{
    static void Main()
    {
    int res;

    Op operation = new Op(Mat.soma);
    res = operation(10, 40);
    Console.WriteLine("soma: {0}", res);

    operation = new Op(Mat.mult);
    res = operation(10, 40);
    Console.WriteLine("mult: {0}", res);

    }
}
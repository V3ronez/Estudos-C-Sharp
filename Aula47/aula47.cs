using System;

class Calc
{
    public int soma(params int[]num)
    {
        int s = 0;
        for (int i = 0; i < num.Length; i++)
        {
            s += num[i];
        }
            return s;
    }

    public double soma(params double[]num)
    {
        double s = 0;
        for (int i = 0; i < num.Length; i++)
        {
            s += num[i];
        }
            return s;
    }


}
class Aula47
{
    static void Main()
    {

        Calc calc = new Calc();

        var res = calc.soma(10, 5);
        Console.WriteLine(res);
    }
}
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

    public int fat(int n){
        int res;
        if(n <= 1){
            res = 1;
        } else {
            res = n * fat(n - 1);
        }
        return res;
    }

}
class Aula48
{
    static void Main()
    {

        Calc calc = new Calc();

        var res = calc.fat(5);
        Console.WriteLine(res);
    }
}
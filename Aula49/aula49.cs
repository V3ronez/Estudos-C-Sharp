using System;


class Mat {
    public static double pi = 3.1415;

    public static int dobro(int num){
        return num * 2;
    }
}
class Aula49 {
    static void Main(){
        //  membro static nao precisa de ser instanciado;

        double vpi = Mat.pi;
        int n = 10;
        

        Console.WriteLine(Mat.dobro(n));
        Console.WriteLine(vpi);
    }
}
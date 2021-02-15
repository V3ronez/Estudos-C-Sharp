using System;
class Aulal0
{
    enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
    static void Main()
    {
        //  DiasSemana ds = DiasSemana.Domingo;
        //  DiasSemana ds = (DiasSemana)3; //cast return: quarta

        int ds = (int)DiasSemana.Sexta;

        Console.WriteLine(ds);
    }
}
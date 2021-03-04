using System;
 class aula18{
     static void Main(){
        int[,] n = new int [3,5];

        // 10 20 30 40 50
        // 60 70 80 90 100
        // 110 120 130 140 150


        n[0,0] = 10;
        n[0,1] = 20;
        n[0,2] = 30;
        n[0,3] = 40;
        n[0,4] = 50;


        n[1,1] = 60;
        n[1,2] = 70;
        

        Console.WriteLine(n[1,2]);
        
     }
}
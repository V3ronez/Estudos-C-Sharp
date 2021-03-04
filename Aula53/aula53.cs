using System;

class Area {
    public static double quadrado(double bas, double alt){
        if(bas == 0 || alt == 0){
            throw new Exception("Base ou Altura inválido");
        }
        return bas * alt;
    }
}

 class Aula53{
     static void Main(){
         double area;

         try{
             area = Area.quadrado(0, 5);
             Console.WriteLine("Area do Quad: {0}", area);
             
         } catch (Exception e) {
             Console.WriteLine("Error! {0}", e.Message); 
         } finally {
             Console.WriteLine("Fim, go home!");
         }

     }
}
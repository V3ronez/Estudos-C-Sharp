using System;

class Aula25 {
     static void Main() {
         int num = 10;  //referencia usa o endereço de memória passado como arg.
         dobrar(ref num);
         Console.WriteLine(num);
     }

     static void dobrar( ref int valor) {
         valor *= 2;
     }
}
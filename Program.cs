using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[10] {2, 5, 7, 8, 10, 21, 12, 9 , 11, 5};
            int suma = 0;
            for(int i = 0; i < 10; i++){
                suma += lista[i];
            }
            if(suma % 3 == 0)
            {
                Console.WriteLine("La suma es divisible por 3");
            }
            else
            {
                Console.WriteLine("La suma no es divisible por 3");
            }
            
            Console.WriteLine(suma);
        }
    }
}

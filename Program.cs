using System;

namespace Ejercicio_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int factor1, factor2;
            int producto;
            Console.WriteLine("Ingrese el primer factor del producto");
            factor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo factor del producto");
            factor2 = Convert.ToInt32(Console.ReadLine());
            producto = calcproducto(factor1,factor2);                        
            Console.WriteLine("El producto de los factores es {0}", producto);            
        }
            static int product = 0;
            public static int calcproducto(int num1, int num2)
                {
                for(int i = 1; i <= num2 ; i++ )
                    {
                        product +=  num1;
                    }
                return product;
                }
    }
}

using System;

namespace Temperatura_28_dias
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0, promedio=0;
            const int DIAS = 7;
            const int SEM = 4;

            int [ , ] arregloTemp = new int [SEM,DIAS]; 

            for (int i= 0; i < SEM; i++)
            {
                for (int j = 0; j < DIAS; j++)
                {
                    Console.WriteLine("Ingrese la temperatura para el dia {0} de la semana {1}", j+1, i+1);
                    arregloTemp [i,j] = Convert.ToInt32(Console.ReadLine());

                acumulador=acumulador+arregloTemp[ i , j ];

                }
                
                Console.WriteLine("-- Fin semana {0}", i+1);

            Console.WriteLine("--Fin Semana --");
            Console.WriteLine("Presione una tecla para continuar...");

            Console.ReadKey();

        }
        promedio=acumulador/(SEM*DIAS);
        
        Console.WriteLine("El promedio mes es: {0} %",promedio);
    }
}
}


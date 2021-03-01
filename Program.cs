using System;

namespace P3_MatrixDeterminant
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3,3] {{1, 3, 5}, 
                                         {2, 4, 6}, 
                                         {3, 5, 9}};
            //                           {1, 3, 5}
            //                           {2, 4, 6}

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

            int primerDiagonal = (1 * 4 * 9);
            int segundaDiagonal = (2 * 5 * 5);
            int terceraDiagonal = (3 * 3 * 6);
            int cuartaDiagonal = (5 * 4 * 3);
            int quintaDiagonal = (6 * 5 * 1);
            int sextaDiagonal = (9 * 3 * 2);

            int suma1 = (primerDiagonal + segundaDiagonal + terceraDiagonal);
            int suma2 = (cuartaDiagonal + quintaDiagonal + sextaDiagonal);

            int resultado = (suma1 - (suma2));

            Console.WriteLine(resultado);
        }
    }
}
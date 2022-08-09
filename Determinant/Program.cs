using System;
    
namespace Determinant
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i,j;
            int[,] arr1 = new int[5, 6];
            int det = 0;

            Console.Write("\n\nCalculate the determinant of a 4*4 matrix :\n");
            Console.Write("...............................................\n");
        
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write("element - [{0}],[{1}] :", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("The matrix is :\n");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)

                 Console.Write("{0} ", arr1[i, j]);
                Console.Write("\n");
            }
            for (i = 0; i < 4; i++)
                    det = det + (arr1[0, i] * (arr1[1, (i + 1) % 4] * arr1[2,(i+2)%4]* arr1[3, (i+3)%4] - arr1[1, (i + 3) % 4] * arr1[2,(i+2)%4]* arr1[3,(i+1)%4]));
                Console.Write("\nThe Determinant of the matrix is: {0}\n\n", det);
            }
        }
    }

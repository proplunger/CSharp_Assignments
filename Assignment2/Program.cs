using System;

namespace Assignment2
{
    internal class Program
    {
        static void dispalySumAverage() {
            int[] arr = {3,5,6,12,45,34,89};
            float sum = 0;
            for (int i=0;i<arr.Length;i++) {
            sum += arr[i];
            }
            Console.WriteLine($"Sum of elements of array is:{sum}");
            Console.WriteLine($"Average of elements of array is:{sum/arr.Length}");
        }

        static void matrixSum()
        {
            int[,] matrix1 = { {1,2,3},{4,5,6},{7,8,9}};
            int[,] matrix2 = { { 10, 11, 12 }, {13,14,15}, {16,17,18}};
            int[,] result = new int[3,3];


            for (int i=0;i<3; i++) {
                for (int j=0;j<3;j++) {
                    result[i,j] = matrix1[i,j] + matrix2[i,j];
                }
            }

            Console.WriteLine("The Resultant matrix is:");
            for (int i = 0; i <matrix1.GetLength(0); i++)
            {
                for (int j = 0; j <matrix2.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void findMax()
        {
            int[] ar = { 12,34,1,56,0,8,67,32,23};
            int max = ar.Max();
            Console.WriteLine("The max is: "+max);
        }

        static void columnSum() {
            int[,] arr = { { 1,2,3},{ 4,5,6},{ 7,8,9},{ 0,0,0} };
            int[] result = new int[arr.GetLength(1)];
            for (int i=0;i<arr.GetLength(1);i++) {
                int x = 0;
                for (int j =0; j<arr.GetLength(0);j++) {
                    x += arr[j,i];
                }
                result[i] = x;
            }
            for (int i=0;i<arr.GetLength(1);i++) {
                Console.Write(result[i]+" ");
            }
        }

        static void rowSum()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 0, 0, 0 } };
            int[] result = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int x = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    x += arr[i, j];
                }
                result[i] = x;
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine(result[i] + " ");
            }
        }
        static void Main()
        {
            //dispalySumAverage();
            //matrixSum();
            //findMax();
            //columnSum();
            //rowSum();
        }
    }
}
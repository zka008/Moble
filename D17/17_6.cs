//using System;
//using System.Reflection;
//namespace CodeWork
//{
//    internal class Program
//    {
//        static int[] CreateArray(int size)
//        {
//            int[] array = new int[size];
//            for(int i = 0; i < array.Length; i++)
//            {
//                array[i] = i;
//            }
//            return array;
//            //매개변수로 배열의 주소를 받지 않았음, 배열의 이름(주소)을 리턴함
//        }

//        static int[,] CreateArray(int row, int col) {
//            int index = 0;
//            int[,] arr = new int[row, col];
//            for (int i = 0; i < row; i++) 
//            {
//                for (int j = 0; j < col; j++)
//                    arr[i, j] = index++;
//            }
//            return arr;
//        }
//        static void Main(string[] args)
//        {
//            int[] arr1;
//            int[,] arr2;
//            arr1 = CreateArray(5);
//            arr2 = CreateArray(3, 3);

//            Console.WriteLine("arr1 : 1차원 배열의 출력");
//            for (int i = 0;i < arr1.Length;i++)
//            {
//                Console.Write(arr1[i] + " ");
//            }

//            Console.WriteLine("\n\narr2 : 2차원 배열의 출력");
//            for (int i = 0; i < arr2.GetLength(0); i++)
//            {
//                for (int j = 0; j < arr2.GetLength(1); j++)
//                    Console.Write(arr2[i,j] + " ");
//                Console.WriteLine();
//            }
//        }
//    }
//}
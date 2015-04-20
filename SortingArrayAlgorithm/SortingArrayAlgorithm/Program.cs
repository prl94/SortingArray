using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArrayAlgorithm
{
    class Program
    {
        /// <summary>
        /// Сортировка вставками (Insertion Sort) — это простой алгоритм сортировки.
        /// Суть его заключается в том что, на каждом шаге алгоритма мы берем один из элементов массива, 
        /// находим позицию для вставки и вставляем. 
        /// Стоит отметить что массив из 1-го элемента считается отсортированным.
        /// </summary>
        /// <param name="arr"> input array</param>
        /// <param name="length">array length </param>
        /// <returns>sorted array </returns>
        private static int[] InsertSort(int[] arr, int length)
        {
            int[] newArr = arr;
            for (int i = 1; i < length; i++)
            {
                for (int j = i; j > 0 && newArr[j - 1] > newArr[j]; j--)
                {
                    int temp = newArr[j - 1];
                    newArr[j - 1] = newArr[j];
                    newArr[j] = temp;
                }
            }
            return newArr;
        }

        /// <summary>
        /// Selection sorting
        /// effectivity n^2
        /// </summary>
        /// <param name="arr">input array</param>
        /// <param name="length">array length</param>
        /// <returns>sorted array</returns>
        private static int[] SelectionSort(int[] arr, int length)
        {
            int[] newArr = arr;
            for (int i = 0; i < length; i++)
            {
                int minIndex = i;
                for (int j = i; j < length; j++)
                {
                    if (newArr[minIndex] > newArr[j])
                    {
                        minIndex = j;
                    }
                    
                }

                int temp = newArr[i];
                newArr[i] = newArr[minIndex];
                newArr[minIndex] = newArr[i];
            }
            return newArr;
        }

        /// <summary>
        /// bubble sort
        /// </summary>
        /// <param name="arr">input array</param>
        /// <param name="length">array length</param>
        /// <returns>sorted array</returns>
        private static int[] BubbleSort(int[] arr, int length)
        {
            int[] newArr = arr;
            bool swapped = true;
            int j = 0;   

            while (swapped)
            {
                swapped = false;
                j++;
                for (int i = 0; i < length - j; i++)
                {
                    if (newArr[i] > newArr[i + 1])
                    {
                        int temp = newArr[i];
                        newArr[i] = newArr[i + 1];
                        newArr[i + 1] = temp;
                        swapped = true;
                    }
                    
                }
            }


            return newArr;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = rand.Next(1, 100000);
            }

            //InsertSort(array, array.Count());

            //SelectionSort(array, array.Count());

            //BubbleSort(array, array.Count());

            Console.WriteLine("Complete");
        }
    }
}

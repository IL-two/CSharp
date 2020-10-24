using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[100];

            //Заполенение массива
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            printArr(array);

            int p = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());

            sortMerge(array, p, r);

            printArr(array);
            Console.ReadLine();
        }


        static void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n" +
                              "---------------------------\n");
        }

        static void sortMerge(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;

                Array.Sort(arr, p, q);
                printArr(arr);
                Array.Sort(arr, q + 1, r);
                mergeSort(arr, p, q, r);
            }
        }


        static void mergeSort(int[] arr, int p, int q, int r)
        {            
            int n1 = q - p + 1;
            int n2 = r - q;

            int[] arrayL = new int[n1];
            int[] arrayR = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                arrayL[i] = arr[p + i];
            }
                
            for (int j = 0; j < n2; j++)
            {
                arrayR[j] = arr[q + 1 + j];
            }               

            int arrI, arrJ, k;
            arrI = 0;
            arrJ = 0;
            k = p;

            while (arrI < n1 && arrJ < n2)
            {
                if (arrayL[arrI] <= arrayR[arrJ])
                {
                    arr[k] = arrayR[arrJ];
                    arrI++;
                }
                else
                {
                    arr[k] = arrayR[arrJ];
                    arrJ++;
                }
                k++;
            }

            while (arrI < n1)
            {
                arr[k] = arrayL[arrI];
                arrI++;
                k++;
            }

            while (arrJ < n2)
            {
                arr[k] = arrayR[arrJ];
                arrJ++;
                k++;
            }
        }
    }
}

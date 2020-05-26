using System;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int [10] {6, 7, 4, 10, 9, 3, 1, 2, 8, 5};
            int x = 0;

            for(int i = 0; i < 10; i++){
                for(int j = 0; j < 9; j++){
                    if(j != 10){
                        if(arr[j] > arr[j+1]){
                            x = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = x;
                        }
                    } 
                    else j++;
                }
            }
            Console.Write($"Sorted Array = [ ");
            for(int i = 0; i < 10; i++){
                Console.Write($"{arr[i]}; ");
            }
            Console.WriteLine("]");
        }
    }
}

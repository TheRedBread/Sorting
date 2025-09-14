using System;

class Sorting
{

    static void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i == arr.Length-1) continue;
            Console.Write(",");
        }
        Console.Write("]\n");
    }

    static bool isSorted(int[] arr)
    {
        if (arr.Length == 0 || arr.Length == 1) return true;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] > arr[i]) return false;
        }
        return true;
    }

    static void BubbleSort(int[] arr)
    {
        int temp;
        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = 0; j < arr.Length-i-1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }

        }


    }



    static void Main(string[] args)
    {
        int[] arr = { 3, 65, 1, 87, 57, 26, 189, 34, 12, 75, 23 };
        Console.WriteLine("Array Length: " + arr.Length);
        PrintArray(arr);
        BubbleSort(arr);
        PrintArray(arr);


        Console.WriteLine("is Sorted: " + isSorted(arr));

    }




}

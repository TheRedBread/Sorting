using System;

class Sorting
{
    // Writes Array in console
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
            // selects i
            for (int j = 0; j < arr.Length-i-1; j++)
            { 
                // selects and compares to other numbers
                if (arr[j] > arr[j + 1])
                { 
                    // switches places if necesary
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }

        }
    }

    static void SelectionSort(int[] arr)
    {
        for (int step = 0; step < arr.Length - 1; step++)
        {
            int min_index = step; 
            for (int i = step + 1; i < arr.Length; i++)
            { // selects index of smallest number

                if (arr[i] < arr[min_index])
                {
                    min_index = i;
                }

            }

            // puts number of smallest index in correct position
            int temp = arr[step];
            arr[step] = arr[min_index];
            arr[min_index] = temp;

        }
    }

    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && key < arr[j])
            {
                arr[j + 1] = arr[j];
                j -= 1;
            }
            arr[j + 1] = key;

        }
    }



    // Generates a list of length of n and values from [min, max]
    static int[] RandomArray(int n, int min, int max)
    {
        int[] arr = new int[n];
        Random r = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = r.Next(min, max);
        }
        return arr;
    }


    static void Main(string[] args)
    {
        int[] arr = RandomArray(10, 0, 10);
        
        PrintArray(arr);
        InsertionSort(arr);
        PrintArray(arr);


        Console.WriteLine("is Sorted: " + isSorted(arr));

    }




}

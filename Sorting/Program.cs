using System;

class Sorting
{



    static void DisplayArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i == arr.Length-1) continue;
            Console.Write(",");
        }
        Console.Write("]");
    }



    static void Main(string[] args)
    {
        int[] arr = { 3, 65, 1, 87, 57, 26, 189, 34, 12, 75, 23 };
        Console.WriteLine("Array Length: " + arr.Length);
        DisplayArray(arr);

    }




}

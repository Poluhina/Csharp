using System;

class Program
{
    static void Main()
    {
        int[] arr1 = [2, 5, 6];
        int[] arr2 = [3, 1, 8];
        int[] result = new int[arr1.Length];

        ArraySumWhile(arr1, arr2, result);
        OutputResult(result);
        ArraySumFor(arr1, arr2, result);
    }

    static void ArraySumWhile(int[] arr1, int[] arr2, int[] sum)
    { 
        int index = 0;
        while (index < arr1.Length)
        {
            sum[index] = arr1[index] + arr2[index];
            index++;
        }
 
    }

    static void OutputResult(int[] sum)
    {
        Console.WriteLine("Результаты попарных сумм (while):");
        for (int i = 0; i < sum.Length; i++)
            Console.WriteLine(sum[i]);
    }
    
    static void ArraySumFor(int[] arr1, int[] arr2, int[] sum)
    {
        for (int i = 0; i < arr1.Length; i++)
            sum[i] = arr1[i] + arr2[i];

        
    }

    static void OutputResult1 (int[] sum )
    {
        Console.WriteLine("Результаты попарных сумм (for):");
        for (int i = 0; i < sum.Length; i++)
            Console.WriteLine(sum[i]);
    }
    
}


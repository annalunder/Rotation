using System;
public class LeftRotationOfArray
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5 };
        Console.Write("Originalarray: ");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();

        LeftRotationOfArray lr = new LeftRotationOfArray();
        lr.RigthRotate(arr);

        Console.Write("Högerrotation av arrayen med en siffra: ");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.ReadKey();
    }

    void RigthRotate(int[] arr)
    {
        int x = arr[(arr.Length - 1)];
        for (int i = (arr.Length - 1); i > 0; i--)
        {
            arr[i] = arr[i - 1];
        }

        arr[0] = x;
    }
}
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 50);
}
System.Console.WriteLine("[" + string.Join(",", array) + "]");
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int[8];
int count = 0;
FillArray(array);
PrintArray(array);
Console.WriteLine(FindChetnie(count, array));




void FillArray(int[] array)
{
    for (int i = 0; i  < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
int FindChetnie(int count, int[] array)
{
    foreach(int i in array)
        {
            if(i%2 == 0)
            {
                count++;
             }
        }
    return count;
}
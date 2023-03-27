// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[6];
int sum = 0;
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов с нечетными индексами равна {SumElementovSNechIndex(sum, array)}, индексация начинается с 0.");



void FillArray(int[] array)
{
    for (int i = 0; i  < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int SumElementovSNechIndex(int sum, int[] array)
{
    for (int index = 0; index < array.Length; index++)
        {
            int i = array[index];
            if (index %2 != 0) 
            {
                sum = sum + i;
            }
        }
    return sum;
}


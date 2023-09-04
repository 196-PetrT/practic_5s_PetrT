// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

var array = GenerateArray(6); 
PrintArray(array);
Console.Write(SumOddPosition(array)); // вывод суммы чисел нечетного индекса 


int[] GenerateArray(int length)// метод создает ранд массив 
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-10, 10);
    }
    return result;
}

void PrintArray(int[] array)// метод выводящий элементы массива
{
    foreach (int i in array) Console.Write($"{i} ");
}

int SumOddPosition(int[] array) // метод считает суммсу чисел нечетного индекса 
{
    int sumOdd = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumOdd += array[i];  
    } 
    Console.WriteLine();
    
    return sumOdd;
}
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

var array = GenerateArray(4); 
PrintArray(array);
Console.Write(CountEven(array)); // вывод количества чётных чисел в массиве


int[] GenerateArray(int length)// метод создает ранд массив трехзначных чисел
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

void PrintArray(int[] array)// метод выводящий элементы массива
{
    foreach (int i in array) Console.Write($"{i} ");
}

int CountEven(int[] array) // метод считает количество чётных чисел в массиве 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count ++;   
    } 
    Console.WriteLine();
    
    return count;
}
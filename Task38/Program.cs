// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



double[] Array = new double[5]; // по другому не смог

void GenerateArray()// метод создает ранд массив вещественных чисел
{
    
    Random rand = new Random();
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = rand.NextDouble();
        Console.Write($"{Array[i]:F2} "); // обрезаю до второй запятой и вывожу
    }

}


double DifMaxMin(double[] Array) // метод считает разницу между max и min
{
    double max = Array[0];
    double min = Array[0];

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max) max = Array[i];

        else if (Array[i] < min) min = Array[i];
    }
    return max - min;
}

GenerateArray();
Console.Write($"Разница между максимальным и минимальным элементов массива: {DifMaxMin(Array):F2}");
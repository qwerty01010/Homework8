
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    var result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 10);
        }
    }

    return result;
}

int ReadInputData() 
{ 
    if (!int.TryParse(Console.ReadLine(), out var result)) 
         Console.WriteLine("Все плохо"); 
     return result; 
} 


Console.WriteLine("Введите число строк (m)");
int m = ReadInputData();

Console.WriteLine("Введите число столбцов (n)");
int n = ReadInputData();
Console.WriteLine();

var array = CreateArrayWithRandomNumbers(m, n);
PrintArray(array);
Console.WriteLine();

int minsum = int.MaxValue;
int indexLine = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}
Console.WriteLine($"{(indexLine)} строка с наименьшей суммой элементов");
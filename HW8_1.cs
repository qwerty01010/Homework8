//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int sort = 0; sort < array.GetLength(1) - 1; sort++)
        {
            if (array[i, sort] < array[i, sort + 1]) 
            {
                int temp = 0;
                temp = array[i, sort];
                array[i, sort] = array[i, sort + 1];
                array[i, sort + 1] = temp;
            }
        }
    }
}

PrintArray(array);
Console.WriteLine();
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
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


int[,] MatrixComposition(int [,]matrix1, int [,]matrix2, int m)
{
    var matrixComposition = new int[m,m];
    for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < m; k++)
        {
            matrixComposition[i, j] = matrixComposition[i, j] + (matrix1[i, k] * matrix2[k, j]);
        }
    }
}
    

    return matrixComposition;
}


Console.WriteLine("Введите размер матрицы: ");
int m = ReadInputData();

var matrix1 = CreateArrayWithRandomNumbers(m, m);
Console.WriteLine("Первая матрица");
PrintArray(matrix1);
Console.WriteLine();

var matrix2 = CreateArrayWithRandomNumbers(m, m);
Console.WriteLine("Вторая матрица");
PrintArray(matrix2);
Console.WriteLine();

var matrix3 = MatrixComposition(matrix1, matrix2, m);
Console.WriteLine("Произведение матриц");
PrintArray(matrix3);
Console.WriteLine();
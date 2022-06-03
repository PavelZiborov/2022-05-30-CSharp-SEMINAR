/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] matrix) // метод который считает среднее арифметическое элементов каждого столбца и печатает результат
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result = result + matrix[j,i];
        }
        Console.WriteLine($"Среднее арифметическое {i+1} столбца = {Math.Round(result/matrix.GetLength(0),2)}");
    }
}

int m = GetNumber("Введите количество строк матрицы: ");
int n = GetNumber("Введите количество столбцов матрицы: ");
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
ArithmeticMean(matrix);
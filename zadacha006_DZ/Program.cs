/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
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
            matrix[i, j] = new Random().Next(10, 100);
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

void GetElementOfMatrix(int[,] matrix, string row, string column)
{
    int x = 0;
    int y = 0;
    int value = 0;
    Console.Write(row);
    x = int.Parse(Console.ReadLine());
    Console.Write(column);
    y = int.Parse(Console.ReadLine());

    if (x <= matrix.GetLength(0) && y <= matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == x - 1 && j == y - 1)
                {
                    value = matrix[i, j];
                }
            }
        }
        Console.WriteLine($"На {x} строчке в {y} столбце находится элемент {value}");
    }
    else Console.WriteLine("Такой позиции нет в массиве");
}

int m = GetNumber("Введите количество строк матрицы: ");
int n = GetNumber("Введите количество столбцов матрицы: ");
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
GetElementOfMatrix(matrix:   matrix,
                   row:      "Строка: ",
                   column:   "Столбец: ");

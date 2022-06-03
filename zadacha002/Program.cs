/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

int GetDemension(string message) // запрашивает у пользователя размерность массива
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

int[,] FillArray(int firstDemension, int secondDemention) // заполняет массив случайными числами
{
    int[,] arr = new int[firstDemension, secondDemention];
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemention; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr) // печатает матрицу в консоль
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}    ");
        }
        Console.WriteLine();
    }
}

int[,] PowMatrix(int[,] matrix) // возводит в степень элемент матрицы с четными индексами
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < newMatrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j = j + 1)
        {
            if (i % 2 == 0 && j % 2 == 0) 
            newMatrix[i, j] = matrix[i, j] * matrix[i, j];
            else
            newMatrix[i, j] = matrix[i, j];
        }
    }
    return newMatrix;
}

int firstDemension = GetDemension("Введите первый разряд матрицы: ");
int secondDemention = GetDemension("Введите второй разряд матрицы: ");
int[,] matrix = FillArray(firstDemension, secondDemention);
PrintArray(matrix);
int[,] newMatrix = PowMatrix(matrix);
Console.WriteLine();
PrintArray(newMatrix);
/*
задан двумерный массив. найти сумму элементов, расположенных на главной диагонали

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/


int GetDimension(string message) // запрашивает у пользователя размерность массива
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] FillArray(int firstDimension, int secondDimension) // заполняет массив случайными числами
{
    int[,] arr = new int[firstDimension, secondDimension];
    for (int i = 0; i < firstDimension; i++)
    {
        for (int j = 0; j < secondDimension; j++)
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

int SumOfDiagonal(int[,] matrix) // считает элементы двумерного массива расположенные на главной диагонали
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < matrix.GetLength(1); j = j + 1)
        {
            if (i == j) sum = sum + matrix[i, j];
        }
    }
    return sum;
}

int firstDimension = GetDimension("Введите количество строк: ");
int secondDimension = GetDimension("Введите количество столбцов: ");
int [,] matrix = FillArray(firstDimension,secondDimension);
PrintArray(matrix);
int sum = SumOfDiagonal(matrix);
Console.WriteLine($"Сумма элементов по главной диагонали = {sum}");


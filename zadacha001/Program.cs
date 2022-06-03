/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int GetDemension(string massage) // метод, который принимает от пользователя число
{
    Console.WriteLine(massage);
    return int.Parse(Console.ReadLine());
}

int[,] FillMatrix(int firstDemension, int seconsDemension) // метод, который заполняет двумерную матрицу по формуле Aₘₙ = m+n
{
    int[,] matrix = new int[firstDemension, seconsDemension];
    for (int i = 0; i < matrix.GetLength(0); i++) // .GetLength(0) - вызывает метод который возвращает количество строк матрицы
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // .GetLength(1) - вызывает метод который возвращает количество столбцов матрицы
        {
            matrix[i,j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix) // метод, который печатает матрицу
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}    ");
        }
        Console.WriteLine();
    }
}

int firstDemension = GetDemension("Введите размер первого разряда: ");
int seconsDemension = GetDemension("Введите размер второго разряда: ");
int [,] matrix = FillMatrix(firstDemension, seconsDemension);
PrintMatrix(matrix);
/*
Пользователь вводит числа через запятую, а программа считает сколько положительных чисел ввел Пользователь
*/


Console.WriteLine("Введите числа через запятую");
string str = Console.ReadLine();
string[] array = str.Split(","); // Split разделяет массив по запятой или то что укажите в скобках

int countOfPositive = 0;
for (int i = 0; i < array.Length; i++)
{
    if (int.TryParse(array[i], out int number) && number > 0)
    {
        countOfPositive++;
    }
}


Console.WriteLine($"количество положительных элементов = {countOfPositive}");
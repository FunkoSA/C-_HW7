/* 
## Задача 50. 
    Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

    Например, задан массив:

* 1 4 7 2
* 5 9 2 3
* 8 4 2 4

17 -> такого числа в массиве нет

*/

using System;
using static System.Console;
Clear();
Write("Веедите число для поиска его позиции в случайном массиве: ");
int elementValue = int.Parse(ReadLine());
int rows = new Random().Next(4, 11);
int columns = new Random().Next(4, 11);

int[,] matrix = GetRandomArray(rows, columns);
PrintArray(matrix);
ElementPosition(matrix, elementValue);

void ElementPosition(int[,] array, int number)
{
    string result = String.Empty;
    for (int i = 0; i < array.GetLongLength(0); i++)
    {
        for (int j = 0; j < array.GetLongLength(1); j++)
        {
            if (array[i, j] == number) result = result + "(" + i + "," + j + ") ";
        }
    }

    if (result.Length > 0) WriteLine($"Введенное Вами число {number} находится на следующих позициях в массиве {array.GetLongLength(0)}X{array.GetLongLength(1)}: {result}");
    else WriteLine($"Введенное Вами число {number} отсутствует в массиве!");
}

int[,] GetRandomArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(0, 20);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    //double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLongLength(0); i++)
    {
        for (int j = 0; j < array.GetLongLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine("");
    }
}
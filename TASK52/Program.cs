/* 
## Задача 52. 
    Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    Например, задан массив:
* 1 4 7 2
* 5 9 2 3
* 8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/

using System;
using static System.Console;
Clear();

int rows = new Random().Next(4, 11);
int columns = new Random().Next(4, 11);
WriteLine($"Сгенерирован случайный массиве {rows}X{columns}: ");

int[,] matrix = GetRandomArray(rows, columns);
PrintArray(matrix);
double [] avgMatrix = GetAVGMatrix (matrix);
WriteLine($"Среднее значение елементов столбцов [{String.Join("; ",avgMatrix)}]");



double [] GetAVGMatrix(int[,] array)
{
    double [] result = new double [array.GetLongLength(1)];
    
    for (int i = 0; i < array.GetLongLength(1); i++)
    {
        int elementSum = 0;
        for (int j = 0; j < array.GetLongLength(0); j++)
        {
            elementSum+=array[j, i];
        }
        result[i]=(double)(elementSum)/(double)(array.GetLongLength(1));
    }

    return result;
}

int[,] GetRandomArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(-100, 120);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLongLength(0); i++)
    {
        for (int j = 0; j < array.GetLongLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine("");
    }
}
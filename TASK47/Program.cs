/* 
## Задача 47: 

Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

* m = 3, n = 4.
* 0,5 7 -2 -0,2
* 1 -3,3 8 -9,9
* 8 7,8 -7,1 9 

*/

using System;
using static System.Console;
Clear();
Write("Веедите размер двумерного массива (строки и столбцы) через пробел: ");
string[] matrixSize = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(matrixSize[0]);
int columns = int.Parse(matrixSize[1]);

double[,] matrix = GetRandomArray(rows, columns);
PrintArray(matrix);



double[,] GetRandomArray(int rows, int columns)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Math.Round((new Random().NextDouble()) * (new Random().Next(-100, 100)), 3);
        }
    }
    return result;
}

void PrintArray(double[,] array)
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
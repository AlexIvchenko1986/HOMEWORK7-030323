// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintMatrixWithRandomDoubleNumbers(int[,] Numbers)
{
  for (int i = 0; i < Numbers.GetLength(0); i++)
  {
    for (int j = 0; j < Numbers.GetLength(1); j++)
    {
      Console.Write($"{Numbers[i, j]}; "); // Печать двумерного массива с i,j элементами (matrix = [3 строки, 4 столбца])
    }
    Console.WriteLine();
  }
}

void FillMatrixWithRandomDoubleNumbers(int[,] realNumbers, int minValue = -20, int maxValue = 20)
{
  Random number = new Random();
  for (int i = 0; i < realNumbers.GetLength(0); i++)
  {
    for (int j = 0; j < realNumbers.GetLength(1); j++)
    {
      realNumbers[i, j] = number.Next(minValue, maxValue);
    }
  }
}

int[,] matrix = new int[3, 4];

FillMatrixWithRandomDoubleNumbers(matrix);
Console.WriteLine("Матрица 3 x 4");
PrintMatrixWithRandomDoubleNumbers(matrix);

void SumOfColumns(int[,] columns, double sum)
{
  for (int i = 0; i < columns.GetLength(0); i++)
  {
    double sum = 0;
    for (int j = 0; j < columns.GetLength(1); j++)
    {
      sum += columns [i,j];
    }
  }
  Console.Write($"{sum / columns.GetLength(1)} ");
}

SumOfColumns(matrix);
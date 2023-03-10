// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


// void PrintMatrixWithRandomDoubleNumbers(double[,] realNumbers);
// {
//   for (int i = 0; i < realNumbers.GetLength(0); i++)
//   {
//     for (int j = 0; j < realNumbers.GetLength(1); j++)
//     {
//       Console.WriteLine($"{realNumbers[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }
// void FillMatrixWithRandomDoubleNumbers(double[,] doubleNumbers);

// double[,] matrix = new double[3, 4];

// PrintMatrixWithRandomDoubleNumbers(matrix);


void PrintMatrixWithRandomDoubleNumbers(double[,] Numbers)
{
  for (int i = 0; i < Numbers.GetLength(0); i++)
  {
    for (int j = 0; j < Numbers.GetLength(1); j++)
    {
      Console.Write($"{Numbers[i, j]/10.0}; "); // Печать двумерного массива с i,j элементами (matrix = [3 строки, 4 столбца])
    }
    Console.WriteLine();
  }
}

void FillMatrixWithRandomDoubleNumbers(double[,] realNumbers)
{
  for (int i = 0; i < realNumbers.GetLength(0); i++)
  {
    for (int j = 0; j < realNumbers.GetLength(1); j++)
    {
      realNumbers [i,j] = new Random().Next(-1000,1000);
    }
  }
}

double[,] matrix = new double[3, 4];
FillMatrixWithRandomDoubleNumbers(matrix);
PrintMatrixWithRandomDoubleNumbers(matrix);



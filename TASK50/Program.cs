// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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


FindYourNumber(matrix);

void FindYourNumber(int enterYourNumber, int find, int[,] matr)
{

  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.WriteLine("Введите число для поиска");
      int enterYourNumber = Convert.ToInt32(Console.ReadLine());
      int find = Console.ReadLine();
      if (matr[i, j] = enterYourNumber)
      {
        Console.WriteLine(matr[i, j]);
      }
      else
      {
        Console.WriteLine("Такого числа нету ");
      }

    }
  }
}

//int rows = ReadInt("Введите индекс строки: ");
//int colums = ReadInt("Введите индекс столбца: ");
// if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1)) Console.WriteLine(matrix[rows, colums]);
// else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
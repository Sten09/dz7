/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] InitMatrix(int m, int n)
{
  int[,] matrix = new int[m,n];
  Random rnd = new Random();

  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      matrix[i,j] = rnd.Next(1,20);
    }
  }
  return matrix;
}

int GetNumber(string massege)
{
  Console.WriteLine(massege);
  int number = int.Parse(Console.ReadLine());
  return number;
}

string GetElement(int i, int j, int[,] matrix)
{
  if(i > 0 && j > 0 && i <= matrix.GetLength(0) && j <= matrix.GetLength(1))
    return matrix[i - 1, j - 1].ToString();
  else 
    return $"элеманта с индексом [{i},{j}] нет";
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i,j]}  ");
  }
  Console.WriteLine();
  } 
 Console.WriteLine();
}

int[,] matrix = InitMatrix(4,4);
PrintMatrix(matrix);
int i = GetNumber("Введите первый индекс");
int j = GetNumber("Введите второй индекс");
string result = GetElement(i, j, matrix);
Console.WriteLine(result);
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int m =4;
int n = 4;
int[,] GetArray(int m,int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}
void PrintArray(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLength(1); j++)
   {
     Console.Write(matrix[i, j] + "\t");
   }
     Console.WriteLine();

 }
}
// метод для суммы
void SumRows (int[,] matrix)
{
   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1) ; j++)
        {
          sum+=matrix[i,j];
        }
        Console.Write(sum + "\t");
    }
    System.Console.WriteLine(); Console.ReadKey(true);
}
void ShowREsult (int[,]matrix)
{
  int[] sumsOfLines = new int[m];
  int minOfSums = sumsOfLines[0];
    int indexOfMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (sumsOfLines[i] < minOfSums)
        {
            minOfSums = sumsOfLines[i];
            indexOfMin = i;
        }
    }
    System.Console.WriteLine($"Строка с наименьше суммой: {indexOfMin}");  
}  
int[,] resultMatrix = GetArray(m,n);
PrintArray(resultMatrix);
System.Console.WriteLine("Result:");
SumRows  (resultMatrix);
ShowREsult(resultMatrix);

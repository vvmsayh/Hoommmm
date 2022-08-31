/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
System.Console.Write("введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
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
// метод по выводу
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
//метод по упорядовачению элементов каждой строки                      
void ReplaceArray(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        if (matrix[i,j]<matrix[i,j-1])
        {
            int temp = matrix[i,j];
            matrix[i,j] = matrix[i,j-1];
            matrix[i,j-1] = temp;
        }
    }
   }
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
Console.WriteLine("Result: ");
ReplaceArray(resultMatrix);
PrintArray(resultMatrix);
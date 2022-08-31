/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите глубину: ");
int Deep = Convert.ToInt32(Console.ReadLine());
int[,,] GetArray(int m, int n, int k)
{
    int[,,] matrix = new int[m, n, k]; //  создан массив заполненый нулями размером m  на n на z
    int[] sum = new int[n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i, j, z] = new Random().Next(10, 99);
                int t = matrix[i, j, z];
                int w = 0;
                if (w == t)
                    break;
                if (w != t)
                    t = w;
                Console.Write($"Z({z})={matrix[i, j, z]}; ");
            }
        }

    }
    return matrix;
}
int[,,] resultMatrix = GetArray(rows, columns, Deep); //void
PrintArray(resultMatrix);
void PrintArray(int[,,] inputMatrix)
{
    for (int k = 0; k < inputMatrix.GetLength(0); k++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write($"X({k}) Y({m}) ");
            for (int z = 0; z < inputMatrix.GetLength(2); z++)
            {
                Console.Write($"Z({z})={inputMatrix[k, m, z]}; ");
                System.Console.WriteLine();
            }

        }
    }
}


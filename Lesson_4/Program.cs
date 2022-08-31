/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
          int N = 3, M = 3;
            int[,] A = new int[N, M];
 
 
            int rows = 0, columns = 0, dx = 1, dy = 0, dirChanges = 0, gran = M;
 
            for (int i = 0; i < A.Length; i++)
            {
                A[columns, rows] = i + 1;
                if (--gran == 0)
                {
                    gran = M * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                columns += dx;
                rows += dy;
            }
 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
 
 
            Console.ReadKey();
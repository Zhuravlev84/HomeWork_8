/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
int rows = 2;
int colomns = 2;
int[,] firstNumbers = new int[rows, colomns];
FillMatrixRandomNumbers(firstNumbers);
WriteMatrix(firstNumbers);
int[,] secondNumbers = new int[rows, colomns];
FillMatrixRandomNumbers(secondNumbers);
WriteMatrix(secondNumbers);
int[,] sumArray = new int[rows, colomns];


for (int j = 0; j < sumArray.GetLength(1); j++)
{
    int sum = 0;
    for (int i = 0; i < sumArray.GetLength(0); i++)
    {
        for (int a = 0; a < firstNumbers.GetLength(1); a++)
        {
            int temp = 1;
            temp = firstNumbers[i, a] * secondNumbers[a, j];
            sum += temp;
        }
        sumArray[i, j] = sum;
        sum = 0;
    }
}
WriteMatrix(sumArray);



void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

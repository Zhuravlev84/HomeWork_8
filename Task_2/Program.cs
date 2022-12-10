/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка*/

int rows = 5;
int columns = 4;

int[,] arrayNumbers = new int[rows, columns];
for (int i = 0; i < arrayNumbers.GetLength(0); i++)
{
    for (int j = 0; j < arrayNumbers.GetLength(1); j++)
    {
        arrayNumbers[i, j] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < arrayNumbers.GetLength(0); i++)
{
    for (int j = 0; j < arrayNumbers.GetLength(1); j++)
    {
        Console.Write(arrayNumbers[i, j] + " ");
    }
    Console.WriteLine();
}
int sumFirstRow = SumRow(0);
int sumSecondRow = SumRow(1);
int sumThirdRow = SumRow(2);
int sumFourthRow = SumRow(3);
int sumFifthRow = SumRow(4);

int[] sumArray = { sumFirstRow, sumSecondRow, sumThirdRow, sumFourthRow, sumFifthRow };
int a = 0;
int min = sumFirstRow;
while (a < sumArray.Length)
{
    if (min > sumArray[a])
    {
        min = sumArray[a];
    }
    a++;
}
Console.WriteLine();
if (min==sumFirstRow)
{
    Console.Write("1 строка ");
    return;
}
if (min==sumSecondRow)
{
    Console.Write("2 строка ");
    return;
}
if (min==sumThirdRow)
{
    Console.Write("3 строка ");
    return;
}
if (min==sumFourthRow)
{
    Console.Write("4 строка ");
    return;
}
if (min==sumFifthRow)
{
    Console.Write("5 строка ");
}

int SumRow(int i)
{
    int sum = 0;
    for (int j = 0; j < arrayNumbers.GetLength(1); j++)
    {
        sum = sum + arrayNumbers[i, j];
    }
    return sum;
}
// Task 52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void InputMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = Math.Round(new Random().NextDouble() * (20 + 20) - 20, 2);
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}


void ReleaseMatrix(double[,] matrix)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
double summa = 0;
for(int i = 0; i < matrix.GetLength(0); i++)
{
summa += matrix[i, j];
}
Console.WriteLine($"Результат ср. ариф. {j + 1} = {summa / matrix.GetLength(0)}");
}
}


Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
ReleaseMatrix(matrix);
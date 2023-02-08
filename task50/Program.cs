// Task 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет

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


double SearchElementToMatrix(double[,] matrix, int row, int column)
{
if (matrix.GetLength(0) > row && matrix.GetLength(1) > column && row >= 0 && column >= 0)
return matrix[row, column];
return 0;
}


Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
int[] coord = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.Write("Введите позицию элемента: ");
double result = SearchElementToMatrix(matrix, coord[0] - 1, coord[1] - 1);
if (result != 0)
Console.WriteLine(result);
else
Console.WriteLine("Такой позиции в массиве нет");
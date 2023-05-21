// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        // array[i,j] = new Random().Next(1000, 100000);
        // array[i,j] = array[i,j] / 1000;
        // Console.Write(array[i,j]+ " ");
        array[i,j] = Math.Round(new Random().NextDouble(), 3) + new Random().Next(0,100);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

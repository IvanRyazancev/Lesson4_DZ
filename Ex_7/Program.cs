//Задача №7. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

Console.Write("Введите кол-во элементов массива: ");
int x = int.Parse(Console.ReadLine()!);

double[] array = new double[x];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
  array[i] = rand.Next(-990, 990)/10.0;
}

double min_number = array.Min();
double max_number = array.Max();
double differ = max_number - min_number;

Console.Write("Сформированный массив: ");
Console.WriteLine(String.Join(" | ", array));
Console.Write($"Разница между максимальным элементом {max_number} и минимальным элементом {min_number} массива: {differ}");
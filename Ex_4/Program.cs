//Задача №4. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

Console.Write("Введите число, для определения верхней границы диапазона массива: ");
int x = int.Parse(Console.ReadLine()!);

int[] array = new int[123];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, x);
    if (array[i] >= 10 && array[i] <= 99)
    {
        count++;
    }
}

Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Кол-во элементов массива, лежащих в интервале [10, 99]: {count + 1}");
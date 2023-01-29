//Задача №5. Найти сумму чисел одномерного массива стоящих на нечетной позиции.

Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] array = new int[n];
int Sum_odd = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);    
    if (i % 2 != 0)
    {
        Sum_odd = Sum_odd + array[i];
    }
}

Console.Write($"Сформированный массив: ");
Console.WriteLine(String.Join(" ", array));
Console.Write($"Сумма элементов массива, стоящих на нечетных позициях: {Sum_odd}");
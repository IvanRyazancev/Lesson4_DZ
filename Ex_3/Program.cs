//Задача №3. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] array = new int[n];

int even = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    {        
        even ++;
    }    
}

int odd = array.Length - even;

Console.Write("Сформированный массив: ");
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Кол-во четных элементов массива: {even}");
Console.Write($"Кол-во нечетных элементов массива: {odd}");
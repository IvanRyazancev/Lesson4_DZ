//Задача №2. Определить, присутствует ли в заданном массиве, некоторое число.

Console.Write("Введите число элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число для проверки наличия его в массиве: ");
int CheckNumber = int.Parse(Console.ReadLine()!);


int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{    
    array[i] = new Random().Next(0, 100);         
}

Console.Write("Сформированный массив: ");
Console.WriteLine(String.Join(" ", array));

if (array.Contains(CheckNumber))
{
    Console.WriteLine($"Введеное число {CheckNumber} присутствует в сформированном массиве.");
}
else
{
    Console.WriteLine($"Введенное число {CheckNumber} не присутствует в сформированном массиве.");
}
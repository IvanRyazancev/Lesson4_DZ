//Задача №6. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Write("Введите кол-во элементов массива: ");
int x = int.Parse(Console.ReadLine()!);

int[] array  = new int[x];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}

int[] newarray = new int[(array.Length / 2)];

for (int i = 0; i < (array.Length /2); i++)
{    
    newarray[i] = array[i] * array[array.Length - 1 - i];
}
Console.Write("Сформированный массив: ");
Console.WriteLine(String.Join(" ", array));
Console.Write("Массив из произведений элементов родительского массива: ");
Console.WriteLine(String.Join(" ", newarray));
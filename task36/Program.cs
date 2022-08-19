//  Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите колличество элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-99, 100);
}
Console.WriteLine(string.Join(", ", array));
int sumN = 0;
for (int i = 1; i < array.Length; i=i+2)
{
    sumN=sumN + array[i];
}
Console.WriteLine($"Колличество четных элементов массива: {sumN} ");
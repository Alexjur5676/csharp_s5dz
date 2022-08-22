// Задайте массив вещественных чисел. Найдите разницу
//  между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите колличество элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round(rand.NextDouble()*(10+9)-9,5); 
// }
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.NextDouble()*(100+99)-99;
}
Console.WriteLine("Массив: ");
Console.WriteLine(string.Join(", ", array));
double min = array[0];
double max = array[0];
for (int i = 1; i < array.Length; i++)
{   
    if(array[i] > max)
    {
        max=array[i];
    }
    if(array[i] < min)
    {
        min=array[i];
    }  
}
Console.WriteLine($"Максимальный элемент: {max} ");
Console.WriteLine($"Минимальный элемент: {min} ");
double dif = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементом: {dif} ");


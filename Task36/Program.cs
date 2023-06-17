void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-30, 31); 
}
void SearchSum(int[]array)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    Sum  += array[i]; 
    Console.WriteLine($"Сумма равна: {Sum}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[]array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
SearchSum (array);

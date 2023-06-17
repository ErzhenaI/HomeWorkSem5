void InputArray(double[]array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2);
}
double MinArray(double[] array)
{
    double min = array[0];
    foreach (double a in array)
        if(min > a) min = a;
    return min;
}
double MaxArray(double[] array)
{
    double max = array[0];
    foreach (double b in array)
        if(max < b) max = b;
    return max;
}
double Result(double min, double max)
{
    double result = max - min;
    return result;
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
double min = MinArray(array);                              
double max = MaxArray(array);                              
double res = Result(min, max);
Console.WriteLine($"Результат: {res}");
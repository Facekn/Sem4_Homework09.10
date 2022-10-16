void FillArray(int[] array, int min, int max)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (min,max);
    }
}
void PrintArray(int[]array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.Write("Введите минимальное число для значений массива:");
int Min = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите максимальное число для значений массива:");
int Max = int.Parse(Console.ReadLine()??"0");
int[] array = new int[123];
FillArray(array, Min, Max+1);
PrintArray(array);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if  (array[i]>=10 && array[i]<=99)                                 
        {
            int count = 1;
            sum = sum + count;
        }
     
    else
        { 
            sum = sum+0;
        }
}
Console.WriteLine();
Console.Write($"В массиве {sum} чисел диапазона от 10 до 99");
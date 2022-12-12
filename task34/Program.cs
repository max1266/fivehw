Console.Clear();
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
int count = 0;
for(int i=0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,200);
    if(array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Количество четных элементов массива: {count}");

//String(char)

// string? stroka = Console.ReadLine();

// Console.WriteLine(Convert.ToInt32(stroka[0].ToString()) * 10);

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11); //[-10, 10]

Console.WriteLine($"Результат: [{string.Join(" , ", array)}]");    


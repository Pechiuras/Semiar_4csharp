//Task 30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++) 
    array[i] = new Random().Next(0, 2);
Console.Write($"Результат: [{string.Join(" , " , array)}]");
//Task 28 Напишите программу, которая принимает на вход число и выдает произведение чисел от одного до n.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), F = 1, i = 2;
while (i <= n)
{
    F = F * i;
    i++; //i = i + 1
   
}
Console.WriteLine(F);
// Function (void)
// void f(int[] n)
// {
//    n[0] = n[0] + 5; 
// }

// int[] n = {1, 2, 3, 4, 5};
// f(n);
// Console.WriteLine(string.Join(" ", n));

//Напишите программу, которая принимает 2 числа и выводит наибольшее

int f(int a, int b)
{
    if (a > b)
       return a;
    return b;   
}


int a = 10, b = 15;
Console.WriteLine(f(a, b));
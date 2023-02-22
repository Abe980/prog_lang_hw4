// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

// Console.Write("Введите число A: ");
// double A = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите натуральное число В: ");
// int B = Convert.ToInt32(Console.ReadLine());

// double result = 1;

// for (int i = 1; i <= B; i++)
// {
//     result *= A;
// }

// Console.WriteLine($"Число А в степени В равно {result}");




// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// Console.Write("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 0) number *=(-1);
// int result = 0;
// int tm = 0;

// while (number > 0)
// {
//     tm = number%10;
//     result += tm;
//     number /= 10;
// }

// Console.WriteLine($"Сумма цифр: {result}");




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

int[] arr = new int[8];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Введите {i}-й элемент массива: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Введенный массив [{String.Join(", ", arr)}]");
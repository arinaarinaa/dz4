// Напишите цикл, который принимает на вход два числа (A и B) 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("2 цифры  - ");
double n = Convert.ToDouble(Console.ReadLine());
double z = Convert.ToDouble(Console.ReadLine());

double result = Math.Pow(n, z);
Console.WriteLine(result);


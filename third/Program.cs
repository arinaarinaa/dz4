//  Напишите программу, которая принимает на вход число 
//  и выдаёт сумму цифр в числе.

//  452 -> 11

Console.WriteLine("Число введи сюда - ");
int vvedennoe = Convert.ToInt32(Console.ReadLine());
string x = Convert.ToString(vvedennoe);
int n = x.Length;
int Sum = 0;
for(int i= 0; i<n; i++)
{
    int d = vvedennoe %10;
    vvedennoe = vvedennoe / 10;
    Sum +=d;
    Console.WriteLine(Sum);
}
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
string result = "";

if (number <= 0) 
{
    Console.WriteLine("Число должно быть больше 0");
    return;
}
while (count <= number)
{
    if (result == "") result = result + count;
    else result = result + ", " + count;
    count = count + 2;
}
Console.WriteLine(number + "-> " + result);
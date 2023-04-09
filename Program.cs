//Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine(" Введите первое число: "); 
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше первое число: " + number1);
Console.WriteLine("Ваше второе число: "+ number2);
int maxnumber = number1;

if (number1 > number2)
{
  Console.WriteLine("Максимальное число: " + maxnumber);
  Console.WriteLine("Минимальное число: " + number2);
}
else
{
  int minNumber = number1;
  Console.WriteLine("Максимальное число: " + number2);
  Console.WriteLine("Минимальное число: " + minNumber);
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваше первое число: " + number1);
Console.WriteLine("Ваше второе число: " + number2);
Console.WriteLine("Ваше третье число: " + number3);

int maxnumber = number1;

if (number1 < number2) maxnumber = number2;
if (number1 < number3) maxnumber = number3;

  Console.WriteLine("Ваше максимальное число: " + maxnumber);

// Задача 6: 
// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1)
{
  Console.WriteLine("Число является НЕЧЕТНЫМ " + number);
}
else 
{
  Console.WriteLine("Число является ЧЕТНЫМ " + number);
}

// Задача 8: 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;
bool not = true;

Console.WriteLine("Чётные числа от 1 до " + number);
while (current <= number)
{
  if (current % 2 != 1)
  {
    Console.Write(current + ", ");
    not = false;
  }
  current++;
}
  if (not)
   {
     Console.WriteLine("Нет чётных чисел!");
   }




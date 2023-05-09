/*// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Input your 1st number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your 2nd number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
if (number_1 > number_2)
{
    Console.WriteLine ("Your 1st number "+ number_1 +" is bigger, 2nd number "+ number_2 +" is smaller");
}
else
{
  Console.WriteLine ("Your 1st number "+ number_1 +" is smaller, 2nd number "+ number_2 +" is bigger"); 
}
*/

/*// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Input your 1st number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your 2nd number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your 3rd number: ");
int number_3 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
{
  if (number_1 > number_3)
  {
    Console.WriteLine("Max number is: " + number_1);
  }
else
  {
  Console.WriteLine("Max number is: " + number_3);
  }
}

else if (number_2 > number_3)
{
    Console.WriteLine("Max number is: " + number_2);
}
else
{
    Console.WriteLine("Max number is: " + number_3);
}
*/

/*//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
Console.WriteLine("Input your number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber % 2 == 0)
{
  Console.WriteLine ("Число " + userNumber + " является: ЧЁТНЫМ");
}

else
{
  Console.WriteLine ("Число " + userNumber + " является: НЕЧЁТНЫМ");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Input your number: ");
int Number_N = Convert.ToInt32(Console.ReadLine());

int startNumber = 1;

while(startNumber <= Number_N)
{
  if(startNumber % 2 ==0)
  Console.Write(startNumber + ", ");
  startNumber ++;
  }
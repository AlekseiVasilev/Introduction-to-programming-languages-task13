/*
Задача 13: Напишите программу, которая выводит третью цифру
 заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
if (numText.Length > 2)
{
    if (num > 0)
    {Console.WriteLine("третья цифра: " + numText[2]);}
    
    else{Console.WriteLine("третья цифра: " + numText[3]);}

 }
else {
  Console.WriteLine("Вы введи число меньше трехзначного");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write ("Введите номер дня недели N: ");
int N=Convert.ToInt32(Console.ReadLine());
switch (N)
{
    case 1:
    Console.WriteLine ("Понедельник, это будний день!");
    break;
    case 2:
    Console.WriteLine ("Вторник, это будний день!");
    break;
    case 3:
    Console.WriteLine ("Среда, это будний день!");
    break;
    case 4:
    Console.WriteLine ("Четверг, это будний день!");
    break;
    case 5:
    Console.WriteLine ("Пятница, это будний день!");
    break;
    case 6:
    Console.WriteLine ("Суббота! Ура, это выходной!");
    break;
    case 7:
    Console.WriteLine ("Воскресенье! Ура, это выходной!");
    break;
    default:
    Console.WriteLine ("Нет такого дня недели");
    break;
}



// ВВОДНАЯ ЗАДАЧА
// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

//Console.WriteLine("Введите целое число");
//int num = Convert.ToInt32(Console.ReadLine());
//int square = num * num;
//Console.WriteLine("Квадрат введенного числа равен: " + square);



// Console.WriteLine("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = num * num;
// Console.WriteLine("Квадрат введенного числа равен: " + result);

// int a = Convert.ToInt32(Console.ReadLine());
// int result = a*a;
// Console.WriteLine(result);


// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Write("Введите первое целое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе целое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int square = b*b;

// if (square == a)
// {
//     Console.WriteLine("Первое число является квадратом второго");
// }

// else
// Console.WriteLine("Первое число не является квадратом второго");


// 2 вариант


// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());


// int square = b*b;

// if (square == a)
// {
//     Console.WriteLine("Первое число является квадратом второго");
// }

// else
// Console.WriteLine("Первое число не является квадратом второго");





// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Введите номер дня недели: ");
// int a = Convert.ToInt32(Console.ReadLine());


// if (a == 1)
//     Console.WriteLine("Понедельник");

// else if (a == 2)
//     Console.WriteLine("Вторник");

// else if (a == 3)
//     Console.WriteLine("Среда");

// else if (a == 4)
//     Console.WriteLine("Четверг");

// else if (a == 5)
//     Console.WriteLine("Пятница");

// else if (a == 6)
//     Console.WriteLine("Суббота");

// else if (a == 7)
//     Console.WriteLine("Воскресенье");

// else 
//     Console.WriteLine("Неккоректно");


//ВАРИАНТ 2

// Console.Write("Введите номер дня недели (от 1 до 7 включительно): ");
// int a = Convert.ToInt32(Console.ReadLine());

// switch (a)
// {
//     case 1:
//     Console.WriteLine("День недели - понедельник");
//     break;

//     case 2:
//     Console.WriteLine("День недели - вторник");
//     break;

//     case 3:
//     Console.WriteLine("День недели - среда");
//     break;

//     case 4:
//     Console.WriteLine("День недели - четверг");
//     break;

//     case 5:
//     Console.WriteLine("День недели - пятница");
//     break;

//     case 6:
//     Console.WriteLine("День недели - суббота");
//     break;

//     case 7:
//     Console.WriteLine("День недели - воскресенье");
//     break;

//     default:
//     Console.WriteLine("Введен не номер дня недели");
//     break;
// }


// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = -num;

// while (count <= num)
// {
//     Console.Write(count + " ");
//     count++;

// }


// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());


// if (num >= 1000)
//     Console.WriteLine("Введено не трехзначное число");


// int result = (num % 10);
// Console.WriteLine("Последняя цифра числа: " + result);

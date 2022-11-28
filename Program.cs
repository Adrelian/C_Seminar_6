// //Задача 1. Напишите программу, которая перевернёт одномерный 
// массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// // создать массив
// int [] CreateRandomArray(int size, int minValue,int maxValue)  
// {
// int [] newArray = new int [size]; 

//     for(int i=0;i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }
// // показать массив
// void ShowArray(int [] array)
// {
//     Console.Write($"Получившийся массив -> ");

//     for(int i = 0;i < array.Length;i++ )
//     {
//         Console.Write (array[i]+" ");
//     }
//     Console.WriteLine();
// }
// // разворот массива
// int[] ReverseArray (int[] array)
// {
//     for (int i = 0, j = array.Length - 1; i < j; i++, j-- )
//     {
//         int temp = array[i]; // временная переменная для хранения элемента массива
//         array[i] = array[j]; // пренос в новый массив
//         array[j] = temp; //
//     }
//     return array;
// }
// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(a, min, max);
// ShowArray(myArray);
// ShowArray(ReverseArray(myArray));

//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

// решаем через рекурсию
// bool checkTriangleSide(int a, int b, int c)
// {
//     if ((a+b>c) && (b+c>a) && (c+a>b)) 
//     {
//         Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");
//         return true; // верный треугольник
//     }
//     else Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} НЕ существует");
//     return false; // ошибочный треугольник
// }

// // рекурсия для проверки числа, не должно быть отрицательным
// int CheckNumber ()
// {
//     int x = Convert.ToInt32(Console.ReadLine());
//     if (x <= 0) 
//     {
//         Console.WriteLine ("Ошибка ввода числа, повторит ввод"); //ошибка ввода в рекурсии
//         return CheckNumber(); // зацикливание - рекурсия
//     }
//      // рекурсия
//     else return x;
// }

// // запрос пользователя, проверка через рекурсию каждого числа
// Console.Write("Введите сторону а: ");
// int a = CheckNumber();
// Console.Write("Введите сторону b: ");
// int b = CheckNumber();
// Console.Write("Введите сторону c: ");
// int c = CheckNumber();

// checkTriangleSide(a, b, c);

//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: a и b.

//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1,
// а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]


// последовательность Фибоначи
// int[] showFibonaci(int firstNum, int secondNum, int size)
// {
//     // создание массива
//     int [] newArray = new int[size];
//     newArray[0] = firstNum; // первое число в ряду
//     newArray[1] = secondNum; // второе число

//     // создание последовательности
//     for(int i = 2; i < size; i++)
//     {
//         newArray[i] = newArray[i-1] + newArray[i-2];
//     }
//     return newArray;
// }

// // показать массив
// void ShowArray(int [] array)
// {
//     Console.Write($"Получившийся массив -> ");

//     for( int i = 0; i < array.Length; i++ )
//     {
//         Console.Write (array[i]+" ");
//     }
//     Console.WriteLine();
// }

// // запрос пользователя
// Console.WriteLine("Введите первое число ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите конец ");
// int size = Convert.ToInt32(Console.ReadLine());
// ShowArray(showFibonaci(firstNum, secondNum, size));


// 43. Написать программу преобразования десятичного числа в двоичное

//Вариант 1. Моё решение
// void decimalToBinary(int number)
// {
//     // Двоичное число, но задом наперёд
//     int boolNumber = 0; // двоичное число
//     int numberForChange = number; // создаём число для изменений, что бы введёное не
//     while (numberForChange>0)
//     {
//         int numberBool = (numberForChange % 2);
//         numberForChange = numberForChange / 2; 
//         boolNumber = boolNumber * 10 + numberBool; // прибавляем число в конец
//     }

//     // Разворот двоичного числа
//     int newBoolNumber = 0; // новое (правильное) двоичное число
//     int wronghtBoolNumber = boolNumber; // присваиваем неверному числу (для изменения) полученное число из цикла выше

//     // После каждой иттерации уменьшаем неверное число на 1 разряд
//     while (wronghtBoolNumber > 0)
//     {
//         int alongBoolNumber = wronghtBoolNumber % 10; // берём правое число
//         wronghtBoolNumber = wronghtBoolNumber / 10; // уменьшаем разряд на 1
//         newBoolNumber = newBoolNumber * 10 + alongBoolNumber; //собираем новое двоичное число ПРАВИЛЬНОЕ
//     }
//     Console.WriteLine($"{number} -> {newBoolNumber}");
// }

// Console.Write("Введите число: ");
// int decNumber = Convert.ToInt32(Console.ReadLine());
// decimalToBinary(decNumber);

// Вариант 2. Решение на семинаре. Через строки.

// string decimalToBinary(int number)
// {
//     string result = string.Empty;
//     int binaryNumber; // новое двоичное число 

//     // создание двоичного числа
//     while(number > 0)
//     {
//         binaryNumber = number % 2; // остаток от деления
//         result = Convert.ToString(binaryNumber) + result; //запись в строку остаток от деления
//         number = number / 2;
//     }
//     return result;
// }

// Console.WriteLine(decimalToBinary(1024));
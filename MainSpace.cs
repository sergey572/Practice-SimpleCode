using System.Net;
using System.Runtime.InteropServices;

namespace Practice
{
    internal class MainSpace
    {
        #region practice SimpleCode
        static void Main(string[] args)
        {


            //int number1 = Convert.ToInt32(Console.ReadLine()), number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((double)(number1 + number2) / 2);  ДЗ 1. Задание 1 . Среднее арифметическое двух чисел.



            //int number1 = Convert.ToInt32(Console.ReadLine()), number2 = Convert.ToInt32(Console.ReadLine()), number3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number1 + number2 + number3);
            //Console.WriteLine(number1 * number2 * number3);  ДЗ 1. Задание 2. Сложение/Умножение трех чисел.



            //int rub = 1, usd = 80 * rub, euro = 100 * rub;
            //Console.WriteLine(5 * usd);
            //Console.WriteLine(5 * euro);
            //Console.WriteLine(0.2 * euro);  ДЗ 1. Задание 3. Обменник.



            //bool IsInfeected = false;
            //Random rnd = new Random();
            //int number = rnd.Next(1,101);
            //if (number >= 51) 
            //    IsInfeected = true;
            //else 
            //    IsInfeected = false;
            //if (IsInfeected)
            //    Console.WriteLine("Персонаж инфицирован!");
            //else
            //    Console.WriteLine("Персонаж не инфицирован!"); 



            //int number = Convert.ToInt32(Console.ReadLine());
            //bool IsEven = (number % 2) == 1;
            //if (IsEven)
            //    Console.WriteLine($"Число {number} нечетное!");
            //else 
            //    Console.WriteLine($"Число {number} четное!");  ДЗ 2. Проверка на чётность/нечётность.



            //Console.WriteLine("Введите 2 числа: ");
            //int number1 = Convert.ToInt32(Console.ReadLine()), number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Выберите действие: \n" + "1. +\n" + "2. -\n" + "3. *\n" + "4. /");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //switch (choice)
            //{
            //    case 1: 
            //        Console.WriteLine(number1 + number2); break;
            //    case 2:
            //        Console.WriteLine(number1 - number2); break;
            //    case 3:
            //        Console.WriteLine(number1 * number2); break;
            //    case 4:
            //        Console.WriteLine(number1 / number2); break;
            //    default:
            //        Console.WriteLine("Вы выбрали отсутствующий номер действия, выберите действие повторно."); break;
            //}  ДЗ 3. Задание 1.  Калькулятор с помощью switch/case.

            //Console.WriteLine("Введите 2 числа: ");
            //int number1 = Convert.ToInt32(Console.ReadLine()), number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Выберите действие: \n" + "1. +\n" + "2. -\n" + "3. *\n" + "4. /");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //if (choice == 1)
            //    Console.WriteLine(number1 + number2);
            //if (choice == 2) 
            //    Console.WriteLine(number1 - number2);
            //if (choice == 3) 
            //    Console.WriteLine(number1 * number2);
            //if (choice == 4)
            //    Console.WriteLine(number1 / number2);
            //else
            //    Console.WriteLine("Вы выбрали отсутствующий номер действия, выберите действие повторно.");  ДЗ 3. Задание 2. Калькулятор с помощью if/else.



            //Console.WriteLine("Введите 2 числа, обозначающие диапазон поиска: ");
            //int start = Convert.ToInt32(Console.ReadLine()), end = Convert.ToInt32(Console.ReadLine()), count_ch = 0, count_nch = 0, sum_ch = 0, sum_nch = 0;
            //while (start <= end)
            //{
            //if (start % 2  == 0)
            //{
            //count_ch++;
            //sum_ch += start;
            //}
            //else
            //{
            //count_nch++;
            //sum_nch += start;
            //}
            //start++;
            //}
            //Console.WriteLine("Количество четных чисел: " + count_ch);
            //Console.WriteLine("Сумма четных чисел: " + sum_ch);
            //Console.WriteLine("Количество нечетных чисел: " + count_nch);
            //Console.WriteLine("Сумма нечетных чисел: " + sum_nch);  ДЗ 4. Количество и сумма чётных/нечётных чисел в заданном пользователем диапазоне.



            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 10; i > 0; i--)
            //{
            //    for (int j = i; j >= 1; j--)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 10; j >= i; j--)
            //        Console.Write(' ');
            //    for (int j = 1; j <= i; j++)
            //        Console.Write('#');
            //    Console.Write("\n");
            //}

            //Console.WriteLine();

            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int j = 10; j >= i; j--)
            //        Console.Write(' ');
            //    for (int j = 1; j <= i; j++)
            //        Console.Write('#');
            //    Console.Write("\n");
            //} ДЗ 5. Вложенные циклы, вывод на экран пирамид.



            //bool accessAllowed;
            //string storedPassword = "qwerty";
            //Console.WriteLine("Введите пароль: ");
            //string enteredPassword = Console.ReadLine();
            //accessAllowed = enteredPassword == storedPassword ? true : false;
            //Console.WriteLine(accessAllowed);

            //Console.WriteLine("Введите число:");
            //int inputData = Convert.ToInt32(Console.ReadLine());
            //int outputData = inputData < 0 ? 0 : inputData;
            //Console.WriteLine(outputData);



            //int[] myArray = [1, 2, 3, 4, 5];

            //int[] myArray2 = Enumerable.Range(5, 10).ToArray();
            //for (int i = 0; i < myArray2.Length; i++)
            //{
            //    Console.Write(myArray2[i]);
            //    Console.Write(" ");
            //}

            //Console.WriteLine("Введите количество элементов для создания массива: ");
            //int a = Convert.ToInt32(Console.ReadLine()), sum = 0, min = 999999999;
            //int[] myArray = new int[a];

            //Console.WriteLine("Введите поочередно элементы массива: ");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = Convert.ToInt32(Console.ReadLine());  ДЗ 6. Ввод массива с клавиатуры.
            //}



            //Console.Write("Массив чисел в обратном порядке: ");
            //for (int i = myArray.Length - 1; i > -1; i--)
            //{
            //    Console.Write(myArray[i]);
            //    Console.Write(" ");
            //}  ДЗ 7. Вывод массива в обратном порядке.

            //for (int i = 0;i < myArray.Length; i++)
            //{
            //    if (myArray[i] % 2 == 0)
            //    {
            //        sum += myArray[i];
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Число чётных чисел в массиве: " + sum);  ДЗ 8. Сумма чётных чисел в массиве.



            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray [i] < min)
            //        min = myArray[i];
            //}
            //Console.WriteLine("Минимальное число в массиве: " + min);  ДЗ 9. Поиск минимального числа в массиве.



            //int[,] myTwiceArray =
            //{
            //    {1, 2, 3 },
            //    {5, 4, 0 }
            //};

            //for (int i = 0; i < myTwiceArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myTwiceArray.GetLength(1); j++)
            //    {
            //        Console.Write(myTwiceArray[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}  Чтение двумерного массива с помощью метода GetLength().



            //Console.WriteLine("Введите высоту и ширину массива: ");
            //int height = Convert.ToInt32(Console.ReadLine()), width = Convert.ToInt32(Console.ReadLine());
            //int[,] myTwiceArray = new int[height, width];
            //Console.WriteLine("Поочередно введите значения для заполения массива: ");
            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < width; j++)
            //    {
            //        //myTwiceArray[i,j] = new Random().Next(); Заполнение двумерного массива случайными значениями.
            //        //myTwiceArray[i,j] = Convert.ToInt32(Console.ReadLine()); Заполнение двумерного массива вручную с клавиатуры.
            //    }
            //}

            //for (int i = 0;i < height; i++)
            //{
            //    for (int j = 0; j < width; j++)
            //    {
            //        Console.Write(myTwiceArray[i,j] + "\t");
            //    }
            //    Console.WriteLine();
            //} Заполнение двумерного массива случайными значениями или вручную с клавиатуры.



            //Console.WriteLine("Введите количество символов в строке: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите символ, из которого будет состоять строка: ");
            //string symbol = Console.ReadLine();

            //void PrintString (int a, string symbol)
            //{
            //    Console.WriteLine("Выходная строка: ");
            //    for (int i = 0; i < a; i++)
            //    {
            //        Console.Write(symbol);
            //    }
            //}
            //PrintString(a, symbol);  ДЗ 10. Метод для вывода строки из заданных пользователем элементов.



            //Console.WriteLine("Введите число для поиска в массиве: ");
            //int a = new Random().Next(70), find = Convert.ToInt32(Console.ReadLine());
            //int[] myArray = new int[a];
            //for (int i = 0; i < a; i++)
            //{
            //    myArray[i] = new Random().Next(30);
            //}

            //void FindElement(int find)
            //{
            //    for (int i = 0; i < a; i++)
            //    {
            //        if (myArray[i] == find)
            //        {
            //            Console.WriteLine(i);
            //            break;
            //        }
            //    }
            //}
            //FindElement(find);  ДЗ 11. Метод для поиска элемента в массиве и вывода индекса этого элемента.



            ////string str = null;
            //string str = "test";
            //Console.WriteLine(str ?? "нет данных");

            //string str = null;
            //str ??= string.Empty;
            //Console.WriteLine("Количество символов в строке: " + str.Length);



            //int[] GetArray()
            //{
            //    int[] myArray = null;
            //    return null;
            //}

            //int[] myArray = GetArray();
            //myArray ??= new int[0];
            //Console.WriteLine("Количество элементов в массиве: " + myArray.Length);  Оператор объединения с null "?==" + оператор условного null "?."



            //Console.WriteLine("Введите размер массива: ");
            //int Length = Convert.ToInt32(Console.ReadLine());
            //int[] myArray = new int[Length];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = new Random().Next(20);
            //}
            //for (int i = 0;i < myArray.Length;i++)
            //{
            //    Console.Write(myArray[i] + "\t");
            //}
            //Console.WriteLine();

            //Console.WriteLine($"Введите новый размер массива > {Length}: ");
            //int new_Length = Convert.ToInt32(Console.ReadLine());
            //int[] newArray = new int[new_Length];

            //void ChangeLength(ref int[] array)
            //{
            //    for (int i = 0; i < myArray.Length && i < new_Length; i++)
            //    {
            //        newArray[i] = myArray[i];
            //    }
            //    for (int i = myArray.Length; i < newArray.Length; i++)
            //    {
            //        newArray[i] = new Random().Next(20);
            //    }
            //    myArray = null;
            //    for (int i = 0; i < newArray.Length; i++)
            //    {
            //        Console.Write(newArray[i] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //ChangeLength(ref myArray);  ДЗ 12. Изменение размерности массива.



            //Console.WriteLine("Введите размер массива: ");
            //int Length = Convert.ToInt32(Console.ReadLine());
            //int[] myArray = new int[Length];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = new Random().Next(20);
            //}
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write(myArray[i] + "\t");
            //}
            //Console.WriteLine();

            //void Insert(ref int[] array, int value, int index)
            //{
            //    int[] newArray = new int[array.Length + 1];
            //    newArray[index] = value;
            //    for (int i = 0; i < index; i++)
            //    {
            //        newArray[i] = array[i];
            //    }
            //    for (int i = index; i < array.Length; i++)
            //    {
            //        newArray[i+ 1] = array[i];
            //    }
            //    array = newArray;
            //}
            //void AddToFirst(ref int[] array, int value)
            //{
            //    Insert(ref array, value, 0);

            //}
            //void AddToLast(ref int[] array, int value)
            //{
            //    Insert(ref array, value, array.Length);
            //}

            ////Insert(ref myArray, 453523, 5);
            //AddToFirst(ref myArray, 55);
            //AddToLast(ref myArray, 23423);
            //Console.WriteLine("Массив после добавления элемента: ");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write(myArray[i] + "\t");
            //}
            //Console.WriteLine();  ДЗ 13. Добавление элемента в массив.



            //Console.WriteLine("Введите размер массива: ");
            //int Length = Convert.ToInt32(Console.ReadLine());
            //int[] myArray = new int[Length];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = new Random().Next(20);
            //}
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write(myArray[i] + "\t");
            //}
            //Console.WriteLine();

            //void DeleteAt(ref int[] array, int index)
            //{
            //    int[] newArray = new int[array.Length - 1];
            //    for (int i = 0;i < index; i++)
            //    {
            //        newArray[i] = array[i];
            //    }
            //    for (int i = index + 1; i < array.Length; i++)
            //    {
            //        newArray[i - 1] = array[i];
            //    }
            //    array = newArray;
            //}

            //void DeleteFirst(ref int[] array)
            //{
            //    DeleteAt(ref array, 0);
            //}

            //void DeleteLast(ref int[] array)
            //{
            //    DeleteAt(ref array, array.Length-1);
            //}

            //DeleteAt(ref myArray, 2);
            //DeleteLast(ref myArray);
            //DeleteFirst(ref myArray);
            //Console.WriteLine("Массив после изменения: ");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write(myArray[i] + "\t");
            //}
            //Console.WriteLine();  ДЗ 13. Удаление элемента из массива.



            //Console.WriteLine("Введите длину массива: ");
            //int arrayLength = Convert.ToInt32(Console.ReadLine()), arraySum = 0;
            //int[] array = new int[arrayLength];
            //void ArrayUp (in int[] array, int current = 0)
            //{
            //    if (current == arrayLength)
            //        {
            //            return;
            //        }
            //    array[current] = new Random().Next(20);
            //    current++;
            //    ArrayUp (in array, current);
            //}

            //void ArrayPrint (in int[] array, int current = 0)
            //{ 
            //    if (current == arrayLength)
            //            return;

            //    Console.Write(array[current] + "\t");
            //    current++;
            //    ArrayPrint(in array,current);
            //}  ДЗ 14. Заполнение и Вывод массива с помощью рекурсии.



            //void ArraySum(in int[] array, int current = 0)
            //{
            //    if (current == arrayLength)
            //        return;
            //    arraySum += array[current];
            //    current++;
            //    ArraySum(in array, current);
            //}  ДЗ 15. Вычисление суммы элементов массива с помощью рекурсии.

            //ArrayUp(in array);
            //ArrayPrint(in array);
            //ArraySum(in array);
            //Console.WriteLine();
            //Console.WriteLine("Сумма элементов массива: " + arraySum); ДЗ 15. Вычисление суммы элементов массива с помощью рекурсии.



            //Console.WriteLine("Введите число: ");
            //int number = Convert.ToInt32(Console.ReadLine()), summ = 0;
            //void SumNumber (int number)
            //{
            //    if (number < 10)
            //    {
            //        summ += number;
            //        return;
            //    }
            //    summ += number % 10;
            //    number /= 10;
            //    SumNumber (number);
            //}
            //SumNumber(number);
            //Console.WriteLine(summ);  ДЗ 16. Вычисление суммы цифр числа, введенного с клавиатуры.



            //Point point1 = new Point(1, 10, 3);
            //point1.colour = Colour.Green;

            //Point point2 = new Point(2, 32, 18);
            //point2.colour = Colour.Blue;

            //point1.Print();
            //point2.Print();



            //var student1 = new Student("Levshun", "Serjey", "Dmitrievich", new DateTime(2005, 4, 1));
            //student1.Print();



            //Console.WriteLine("====== Car_1 ======");
            //var car = new Car();
            //car.PrintSpeed();
            //car.DriveForward();
            //car.PrintSpeed();
            //car.Stop();
            //car.PrintSpeed();
            //car.DriveBackward();
            //car.PrintSpeed();
            //car.Stop();
            //car.PrintSpeed();  Работа с класом Car из файла Car.cs



            //Gun gun = new Gun(isLoaded: true);
            //gun.Shoot();



            //MyClass1 myClass = new MyClass1();
            //MyClass1 myClass1 = new MyClass1();
            //MyClass1 myClass2 = new MyClass1();
            //Console.WriteLine(MyClass1.Counter);  Работа с классом MyClass1 из файла MyClass1.cs
        }
        #endregion
    }
}

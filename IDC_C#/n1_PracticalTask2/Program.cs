// Amirov Kirill
using System;

namespace n1_PracticalTask2 {
    internal class Program {
        static void Main(string[] args) {
            int taskNumber = 0;

            Console.Write("Enter task number: ");
            taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (taskNumber) {
                case 1:              
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    task5();
                    break;
                case 6:
                    task6();
                    break;
                case 7:
                    task7();
                    break;
                case 8:
                    task8();
                    break;
                case 9:
                    task9();
                    break;
                case 10:
                    task10();
                    break;
                default:
                    Console.WriteLine("The wrong task is chosen");
                    break;
            }
        }
        // Пользователь вводит два числа. Найдите сумму и произведение данных чисел.
        static void task1() {
            int number1 = 0;
            int number2 = 0;

            Console.Write("Enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of the numbers is " + (number1 + number2));
            Console.WriteLine("Multiplication of the numbers is " + (number1 * number2));
        }
        // Пользователь вводит число. Выведите на экран квадрат этого числа, куб этого числа.
        static void task2() {
            int number = 0;

            Console.Write("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The square of the number is " + Math.Pow(number, 2));
            Console.WriteLine("The cube of the number is " + Math.Pow(number, 3));
        }
        // Пользователь вводит три числа. Увеличьте первое число в два раза, второе числа уменьшите на 3, третье число возведите в квадрат и затем найдите сумму новых трех чисел.
        static void task3() {
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;

            Console.Write("Enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            number1 = number1 * 2;
            number2 = number2 - 3;
            number3 = (int)Math.Pow(number3, 2);
            Console.WriteLine("Sum of the final numbers is " + (number1 + number2 + number3));
        }
        // Пользователь вводит три числа. Найдите среднее арифметическое этих чисел, а также разность удвоенной суммы первого и третьего чисел и утроенного второго числа.
        static void task4() {
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;

            Console.Write("Enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The arithmetic mean of the numbers is " + ((number1 + number2 + number3) / 3));
            Console.WriteLine("The difference between the doubled sum of the first and third numbers and the tripled second number is " + ((number1 + number3) * 2 - number2 * 3));
        }
        // Пользователь вводит сторону квадрата. Найдите периметр и площадь квадрата.
        static void task5() {
            int side = 0; // a side of the square

            Console.Write("Enter the side of the square: ");
            side = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The perimeter of the square: " + (side * 4));
            Console.WriteLine("The area of the square: " + Math.Pow(side, 2));
        }
        // Пользователь вводит цены 1 кг конфет и 1 кг печенья. Найдите стоимость: а) одной покупки из 300 г конфет и 400 г печенья; б) трех покупок, каждая из 2 кг печенья и 1 кг 800 г конфет.
        static void task6() {
            int price1 = 0; // price of 1 kg of candies
            int price2 = 0; // price of 1 kg of cookies

            Console.Write("Enter the price of 1 kg of candies: ");
            price1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of 1 kg of cookies: ");
            price2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The cost of a purchase of 300 grams of candies and 400 grams of cookies: " + ((price1 * 0.3) + (price2 * 0.4)));
            Console.WriteLine("The cost of three purchases of 2 kg of cookies and 1.8 kg of candies: " + (3 * ((price2 * 2) + (price1 * 1.8))));
        }
        // Пользователь вводит время в минутах и расстояние в километрах. Найдите скорость в м/c.
        static void task7() {
            int time = 0; // time in minutes
            int distance = 0; // distance in kilometers

            Console.Write("Enter time(min): ");
            time = Convert.ToInt32(Console.ReadLine());
            // protection against zero time entry
            if (time == 0) {                                               
                Console.WriteLine("Time cannot be equal to zero");  
                return;
            }
            Console.Write("Enter distance(km): ");
            distance = Convert.ToInt32(Console.ReadLine());

            time = time * 60; // convert time from minutes to seconds
            distance = distance * 1000; // convert distance from kilometers to meters
            Console.WriteLine("The speed(m/s): " + (distance / time));
        }
        // Даны катеты прямоугольного треугольника. Найдите площадь, периметр и гипотенузу треугольника.
        static void task8() {
            int leg1 = 0; // the base of a right triangle
            int leg2 = 0; // the height of a right triangle
            Console.Write("Enter the first leg: ");
            leg1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second leg: ");
            leg2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The area of the right triangle: " + (leg1 * leg2 / 2));
            Console.WriteLine("The perimeter of the right triangle: " + (leg1 + leg2 + Math.Sqrt(Math.Pow(leg1, 2) + Math.Pow(leg2, 2))));
            Console.WriteLine("The hypotenuse of the right triangle: " + (Math.Sqrt(Math.Pow(leg1, 2) + Math.Pow(leg2, 2))));
        }
        // Дано значение температуры в градусах Цельсия. Вывести температуру  в градусах Фаренгейта.
        static void task9() {
            int C = 0; // temperature in degrees Celsius

            Console.Write("Enter temperature in Celsius: ");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The temperature in Fahrenheit: " + ((C * 9 / 5) + 32));
        }
        // Известно, что x кг конфет стоит a рублей. Определите, сколько стоит y кг этих конфет, а также сколько кг конфет можно купить на k рублей. Все значения вводит пользователь.
        static void task10() {
            double x = 0; // the weight in kg of candies at the 'a' price
            double a = 0; // the price in rub of candies for 'x' kilograms
            double y = 0; // the arbitrary weight in kg of candies for a purchase
            double k = 0; // the arbitrary price in rub of candies for a purchase

            Console.Write("Enter the main weight(kg): ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the main price(rub): ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the arbitrary weight(kg): ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the arbitrary price(rub): ");
            k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The price of candies for the arbitrary weight is " + (y / x * a));
            Console.WriteLine("The weight of candies for the arbitrary price is " + (k / a * x));
        }
    }
}
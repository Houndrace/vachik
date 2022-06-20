using System;
using System.Collections.Generic;
using System.Linq;
namespace n4_PracticalTask5 {
    internal class Program {
        static void Main(string[] args) {
            int taskNumber = 0;

            Console.Write("Enter task number: ");
            try {
                taskNumber = Convert.ToInt32(Console.ReadLine());
            } catch (Exception e) {
                Console.WriteLine("Next time, enter a number");
                Console.WriteLine(e);
                return;
            }
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
                default:
                    Console.WriteLine("The wrong task is chosen");
                    break;
            }
        }
        // Разработать программный модуль, в котором пользователь должен ввести четное число.
        // В случае ввода нечетного числа на экран должно выводиться сообщение об ошибке, после чего действия должны повторяться до ввода правильного значения.
        static void task1() {
            int number = 0;

            while (true) {
                Console.Write("Enter the even number: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 != 0) {
                    Console.WriteLine("The number is odd. Error, try it again");
                } else {
                    Console.WriteLine("The number is even. Good job");
                    break;
                }
            }
        }
        // Разработать программный модуль, который позволяет вводить число по цифрам. После каждой цифры, пользователь должен нажать Enter.
        // Если пользователь не ввел цифру, то вывести результат (число) 
        static void task2() {
            List<int> number = new List<int> { };
            int digit = 0;

            Console.Write("Enter a number character by character: ");
            for (int i = 0; true; i++) {
                try {
                    digit = Convert.ToInt32(Console.ReadLine());
                    if (digit > 9 | digit < 0) {
                        Console.WriteLine("Error");
                        return;
                    }
                    number.Add(digit);
                } catch {
                    break;
                }
            }

            Console.Write("The number is ");
            foreach (int i in number) { 
                Console.Write(i);
            }
        }
        // Дано натуральное число. Определить, сколько раз в нем встречается максимальная цифра (например, для числа 132 233 ответ равен 3, для числа 46 336 - 2, для числа 12 345 - 1).
        // Задачу решить двумя способами:
        // а) с двумя операторами цикла;
        // б) с одним оператором цикла.
        static void task3() {
            int number = 717531;
            int numberTemp = number;
            int count = 0; // the quantity of the maximum digit in the number
            int max = 0; // the maximum digit in the number
            char letter;

            Console.Write("Enter the letter of the task (a/b): ");
            letter = Convert.ToChar(Console.ReadLine());
            switch (letter) {
                case 'a':
                    for (; numberTemp != 0; numberTemp /= 10) {
                        if (max < numberTemp % 10) {
                            max = numberTemp % 10;
                        }
                    }
                    numberTemp = number;
                    for (; numberTemp != 0; numberTemp /= 10) {
                        if (max == numberTemp % 10) {
                            count++;
                        }
                    }
                    Console.WriteLine("The quantity of the maximum digit in the number is {0}", count);
                    break;
                case 'b':
                    int[] arrNumber = Array.ConvertAll(number.ToString().ToArray(), x => (int)x - 48);
                    max = arrNumber.Max();
                    for (int i = 0; i < arrNumber.Length; i++) {
                        if (max == arrNumber[i]) {
                            count++;
                        }
                    }
                    Console.WriteLine("The quantity of the maximum digit in the number is {0}", count);
                    break;
            }
        }
    }
}


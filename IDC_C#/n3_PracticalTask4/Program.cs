using System;

namespace n3_PracticalTask4 {
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
                case 4:
                    task4();
                    break;
                case 5:
                    task5();
                    break;
                case 6:
                    task6();
                    break;
                default:
                    Console.WriteLine("The wrong task is chosen");
                    break;
            }
        }
        // Дано число a и b. Определить количество цифр b в числе a. Решите задачу двумя вариантами:
        // a) используя только тип данных int
        // б) используя тип данных string
        static void task1() {
            int a = 123252;
            int b = 2;
            string aStr = Convert.ToString(a);
            string bStr = Convert.ToString(b);
            int count = 0;  // a number of the 'b' digit in the 'a' number
            char letter;

            Console.Write("Enter the letter of the task (a/b): ");
            letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("The 'a' number is {0}", a);
            switch (letter) {
                case 'a':
                    while (a != 0) {
                        if (a % 10 == b) {
                            count++;
                        }
                        a /= 10;
                    }
                    break;
                case 'b':
                    for (int i = 0; i < aStr.Length; i++) {
                        if (aStr[i] == bStr[0]) {
                            count++;
                        }
                    }
                    break;
            }
            Console.WriteLine("The number of the {0} numbers in the 'a' number is {1}", b, count);
        }
        // Определить, верно ли, что при делении неотрицательного целого числа а на положительное число b получается остаток, равный одному из двух заданных чисел с или d.
        static void task2() {
            uint a = 4;
            double b = 3;
            int c = 3;
            int d = 1;

            Console.WriteLine("a: {0}\nb: {1}\nc: {2}\nd: {3}", a, b, c, d);
            if (a % b == c || a % b == d) {
                Console.WriteLine("That's true");
            } else {
                Console.WriteLine("That's wrong");
            }
        }
        // Определить, является ли запись заданного пятизначного натурального числа симметричной.
        static void task3() {
            int num = 21312;
            int firstHalf = 0;
            int secondHalf = 0; // reverse second half

            Console.WriteLine("The num is {0}", num);
            firstHalf = num / 1000;
            secondHalf = (num % 10 * 10) + (num / 10 % 10);
            if (firstHalf == secondHalf) {
                Console.WriteLine("That's a symmetrical number");
            } else { 
                Console.WriteLine("That's not a symmetrical number");
            }
        }
        // Определить, является ли заданное шестизначное число счастливым. (Счастливым называют такое шестизначное число, в котором сумма его первых трех цифр равна сумме его последних трех цифр.)
        // a) используя только тип данных int
        // б) используя тип данных string           
        static void task4() {
            int num = 281506;
            int numTemp = num;
            string numStr = Convert.ToString(num);
            int firstHalf = 0;
            int secondHalf = 0;
            char letter;

            Console.Write("Enter the letter of the task (a/b): ");
            letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("The num is {0}", num);
            switch (letter) {
                case 'a':
                    for (int i = 0; i < 6; i++) {
                        if (i < 3) {
                            secondHalf += numTemp % 10;
                        } else {
                            firstHalf += numTemp % 10;
                        }
                        numTemp /= 10;
                    }
                    break;
                case 'b':
                    for (int i = 0; i < 6; i++) {
                        if (i < 3) {
                            firstHalf += Convert.ToInt32(numStr[i]);
                        } else {
                            secondHalf += Convert.ToInt32(numStr[i]);
                        }
                    }
                    break;
            }
            if (firstHalf == secondHalf) {
               Console.WriteLine("This is a lucky ticket");
            } else {
                Console.WriteLine("This isn't a lucky ticket");
            }
        }
        // Даны вещественные положительные числа а, Ь, с. Если существует треугольник со сторонами а, Ь, с, то определить, является ли он прямоугольным.
        static void task5() {
            double a = 3;
            double b = 4;
            double c = 5;

            Console.WriteLine("a: {0}\nb: {1}\nc: {2}", a, b, c);
            if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)) {
                Console.WriteLine("The triangle is right");
            } else {
                Console.WriteLine("The triangle isn't right");
            }
        }
        // Известны год, номер месяца и день рождения человека,
        // а также год, номер месяца и день сегодняшнего дня.Определить
        // возраст человека (число полных лет)
        static void task6() {
            int yearsOld = 0; // how old the person is
            // today's date
            int day = 27;
            int month = 5;
            int year = 2022;
            // date of birth
            int bDay = 4;
            int bMonth = 12;
            int bYear = 2003;

            Console.WriteLine("Today is {0}.{1}.{2}", day, month, year);
            Console.WriteLine("Birthday is {0}.{1}.{2}", bDay, bMonth, bYear);
            yearsOld = year - bYear;
            if ((month - bMonth) < 0 | (day - bDay) < 0) {
                yearsOld--;
            }
            Console.WriteLine("The person is {0} years old", yearsOld);
        }
    }
}
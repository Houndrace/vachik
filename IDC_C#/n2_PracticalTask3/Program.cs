using System;

namespace n2_PracticalTask3 {
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

        static void task1() {
            string str = "";

            Console.Write("Enter the string: ");
            str = Console.ReadLine();

            if (isDigit(str)) {
                Console.WriteLine("The string is a number");
            } else {
                Console.WriteLine("The string is a text");
            }
        }

        static void task2() {
            string str1 = "";
            string str2 = "";

            Console.Write("Enter the first string: ");
            str1 = Console.ReadLine();
            Console.Write("Enter the second string: ");
            str2 = Console.ReadLine();

            if (isDigit(str1) && isDigit(str2)) {
                Console.WriteLine(Convert.ToDouble(str1) + Convert.ToDouble(str2));
            } else {
                Console.WriteLine(String.Concat(str1, str2));
            }

        }

        static void task3() {
            string str = "";
            string filler = "";
            int N = 0; // A number of characters

            try {
                Console.Write("Enter a number of characters: ");
                N = Convert.ToInt32(Console.ReadLine());
            } catch {
                Console.WriteLine("Next time, enter a number here");
                return;
            }
            Console.Write("Enter a character-filler: ");
            filler = Console.ReadLine();

            for (int i = 0; i < N; i++) {
                str = String.Concat(str, filler);
            }
            Console.WriteLine(str);
        }
        static bool isDigit(string str) {
            bool isNumber = true;

            try {
                double.Parse(str);
            } catch {
                isNumber = false;
            }
            if (isNumber) {
                return true;
            } else {
                return false;
            }
        }
    }
}
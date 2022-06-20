// Amirov 2var
// Заданы две строки. Построить новую строку, состоящую из символов, которые входят как в одну, так и в другую строку.
using System;
using System.Text;
using System.Collections.Generic;

namespace n5_Practicaltask6 {
    // В заданной строке поменять местами первый и последний символ строки.
    /*internal class task1 {
        static void Main(string[] args) {
            string str = "Hello";
            char firstChar = str[0];
            char lastChar = str[str.Length - 1];

            Console.WriteLine(str);
            str = str.Remove(str.Length - 1);
            str = lastChar + str.Substring(1) + firstChar;
            Console.WriteLine(str);
        }
    }*/

    // В заданной строке посчитать количество слов. Разделителем слов считается один или несколько пробелов.
    /*internal class task2 {
        static void Main(string[] args) {
            string str = "Hello  Hello   Hello Hello       Hello";
            int count = 1; // quantity of words

            Console.WriteLine("The string of words: {0}", str);
            for (int i = 0; i < str.Length; i++) {
                if (i == str.Length - 1) {
                    continue;
                }
                if (str[i] == ' ' && str[i + 1] != ' ') {
                    count++;
                }
            }
            Console.WriteLine("The quantity of words: {0}", count);
        }
    }*/

    internal class Program {
        static void Main(string[] args) {
            string str1 = "Hello";
            string str2 = "Dude";
            List<char> letters = new List<char>();

            Console.WriteLine("The original first string: {0}\nThe original second string: {1}", str1, str2);

            for (int i = 0; i < str1.Length; i++) {
                if (!letters.Exists(letters => letters == str1[i])) {
                    letters.Add(str1[i]);
                }
            }
            for (int i = 0; i < str2.Length; i++) {
                if (!letters.Exists(letters => letters == str2[i])) {
                    letters.Add(str2[i]);
                }
            }
            Console.Write("Result: ");
            foreach (char i in letters) {
                Console.Write(i);
            }
        }
    }
}
#include <iostream>

using namespace std;

void task1();
void task2();
void task3();
void task4();
void task5();

int main()
{
    task4();
}
// 1. Введите строку типа char. Определите к чему относится каждый символ - число или буква (знак). Результат выводите для каждого символа
void task1() {
    char str[255] = "1wqerw3/rq!wrw4q";
    int len = strlen(str);

    for (int i = 0; i < len; i++) {
        if (isdigit(str[i])) {
            cout << str[i] << " is a number" << endl;
        }
        else if (isalpha(str[i])) {
            cout << str[i] << " is a letter" << endl;
        }
        else {
            cout << str[i] << " is a character" << endl;
        }
    }
}
// 2. Введите строку типа char. Определите является ли строка числом (может быть дробным) и выведите результат на экран
void task2() {
    char str[255] = "1322217f856.131f13";
    int len = strlen(str);
    bool isNum = true;

    for (int i = 0; i < len; i++) {
        if (isalpha(str[i])) {
            isNum = false;
            break;
        }
    }
    if (isNum) {
        cout << "is a number";
    }
    else {
        cout << "is a string";
    }
}
// 3. Введите две строки типа char.Если обе строки являются числами, то выполните их арифметическое сложение, иначе соедините их в новую строку(переменную) и выведите результат на экран
void task3() {
    char str1[255] = "3.433";
    char str2[255] = "333";
    char str3[255] = "";
    int len1 = strlen(str1);
    int len2 = strlen(str2);
    bool isNum1 = true;
    bool isNum2 = true;
    double stringSum = 0;
    // Checking these strings wheter it's a string or a number
    for (int i = 0; i < len1; i++) {
        if (isalpha(str1[i])) {
            isNum1 = false;
            break;
        }
    }
    for (int i = 0; i < len2; i++) {
        if (isalpha(str2[i])) {
            isNum2 = false;
            break;
        }
    }
    // Taking the appropriate(соответствующего) action
    if ((!isNum1) && (!isNum2)) {                       // If both strings aren't numbers
        strcat_s(str1, str2);
        strcat_s(str3, str1);
        cout << str3;
    } else if (isNum1 && isNum2) {                      // If both strings are numbers
        stringSum = atof(str1) + atof(str2);
        cout << stringSum;
    } else {
        cout << "it's a string and a number";
    }
}
// 4. Две переменные вводит пользователь через пробел в тип данных char(одна строка и переменная).Необходимо разложить строку на составные части 
// и если обе строки являются числами, то выполните их арифметическое  сложение, иначе выведите сообщение "Error"
void task4() {
    char str1[255] = "12.3 3321";
    char str2[255] = "";
    char str3[255] = "";
    int len = strlen(str1);
    bool isNum = true;

    for (int i = 0; i < len; i++) {
        if (isalpha(str1[i])) {
            isNum = false;
            break;
        }
    }

    if (isNum) {
        int space = 0;
        // Looking for a space in "str1"
        while (str1[space] != ' ') {
            space++;
        }
        // Assign the numbers before the space to "str2"
        for (int i = 0; i < space; i++) {
            str2[i] = str1[i];
        }
        for (int i = 0; i < len; i++) {
            if (space < len) {
                space++;                    // Indexes of the characters after space
                str3[i] = str1[space];
            }
        }
        cout << atof(str2) + atof(str3);
    } else {
        cout << "Error";
    }
}
// 5. Дана строка состоящая из слов(лексем) разделенных пробелом.Определите сколько чисел в этой строке, запишите их в массив.Выведите их на экран и найдите сумму элементов
void task5() {
    char str1[255] = "fasdf 13f23 asdf 321 fasdfas 123";
    char* token = NULL; 
    char* next_token = NULL;
    char separation[] = " ";
    int len = strlen(str1);
    int tokenLength;
    bool isNum = true;
    int count = 0;
    double array[255] = { 0.0 };
    double sum = 0; // Sum of the elements of array
    // Establish string and get the first token:
    token = strtok_s(str1, separation, &next_token);
    // While there are tokens in "str1"
    while (token != NULL) {
        tokenLength = strlen(token);                    // Determine the length of the token
        // Determine if the token contains a letter
        for (int i = 0; i < tokenLength; i++) {
            if (isalpha(token[i])) {
                isNum = false;
                break;
            }
            else {
                isNum = true;
            }
        }
        // If the token doesn't contain a letter
        if (isNum) {
            array[count] = atof(token);                 // Enter the number of our token in an array 
            count++;                                    // Count numbers of our token numbers
        }
        token = strtok_s(NULL, separation, &next_token);// Establish the next token
    }

    for (int i = 0; i < count; i++) {
        cout << array[i] << endl;
        sum += array[i];
    }
    cout << sum;
}
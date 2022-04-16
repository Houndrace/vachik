//Амиров
//153. Написать программу, которая методом прямого выбора сортирует по убыванию введеныый с клавиатуры одномерный массив.
//154. Написать программу, которая методом обмена ("пузырька") сортирует по убыванию введенный с клавиатуры одномерный массив.

#include <iostream>
#include <Windows.h>

using namespace std;

void t153();
void t154();

int main()
{
    setlocale(LC_ALL, "russian");

    int taskChecker;
    char ynCheker;

    while (true) {
        cout << "Сортировка массива (153/154) -> ";
        cin >> taskChecker;
        switch (taskChecker)
        {
        case 153:
            t153();
            break;
        case 154:
            t154();
            break;
        default:
            break;
        }
        cout << "Продолжить (Y / N) - ";
        cin >> ynCheker;
        if (ynCheker == 'N') {
            break;
        }
        system("cls");
    }
}

void t153() {
    int array[10];
    int min;
    int temp;

    cout << "Ввод данных." << endl;
    cout << "Введите массив: " << endl;
    //Вводим массив
    for (int i = 0; i < 10; i++) {
        cout << "array[" << i << "] = ";
        cin >> array[i];
    }
    //Сортировка массива
    for (int i = 0; i < 10; i++) {
        min = i;                            //Присваеваем минимальный индекс для начала перебора элементов
        //Поиск индекса минимального элемента
        for (int j = i + 1; j < 10; j++) {
            if (array[min] > array[j]) {
                min = j;                    //Записываем индекс минимального элемента            
            }
        }
        //Меняем местами минимальный и i-й элемент
        temp = array[i];                    //Сохраняем i-й элемент                             
        array[i] = array[min];              //Записываем в i-й элемент минимальный              
        array[min] = temp;                  //Записываем в минимальный элемент i-й элемент      
    }
    //Выводим массив
    cout << "Конечный результат: " << endl;
    for (int i = 0; i < 10; i++) {
        cout << "array[" << i << "] = " << array[i] << endl;
    }
}

void t154() {
    int array[10];
    int temp;

    cout << "Ввод данных." << endl;
    cout << "Введите массив: " << endl;
    //Вводим массив
    for (int i = 0; i < 10; i++) {
        cout << "array[" << i << "] = ";
        cin >> array[i];
    }
    //Ссортируем массив
    for (int i = 0; i < 10; i++) {
        for (int j = 0; j < 9; j++) {
            if (array[j] > array[j + 1]) {      //Если элемент больше, чем следующий за ним 
                temp = array[j];                //то обменяем j-й 
                array[j] = array[j + 1];        //и j + 1-й элементы
                array[j + 1] = temp;            //через временную перемунную
            }
        }
    }
    //Выводим конечный массив
    for (int i = 0; i < 10; i++) {
        cout << "array[" << i << "] = " << array[i] << endl;
    }
}
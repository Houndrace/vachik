//Amirov

#include <iostream>
#include <windows.h>
#include <cmath>

using namespace std;

void task133();
void task107();

int main()
{
	setlocale(LC_ALL, "russian");

	int chooser = 0;
	//choose a task to start
	cout << "Выберите задачу, введя ее номер (107, 133) - ";
	cin >> chooser;

	switch (chooser) {
	case 107:
		task107();
		break;
	case 133:
		task133();
		break;
	default:
		break;
	}
}

void task107() {
	int numberQuantity;
	int sum = 0;

	cout << "Вычисление суммы положительных чисел.\n";
	cout << "Введите количество суммируемых чисел -> ";
	cin >> numberQuantity;
	//searching for the sum of the first numbers
	for (int i = 1; i <= numberQuantity; i++) {
		sum += i;
	}
	cout << "Сумма первых " << numberQuantity << " положительных чисел равна " << sum;
}

void task133() {
	float count = 0;
	int number;
	int sum = 0;
	float arethmetic = 0;

	cout << "Вычисление среднего арифметической последовательности положительных чисел.\n";
	cout << "Вводите после стрелки числа. Для завершения ввода введите ноль.\n";

	//calculating arethmetic mean of a sequence of positive numbers
	do {
		cout << "-> ";
		cin >> number;
		if (number > 0) {
			sum += number;
			count++;
		}
	} while (!!number);

	arethmetic = sum / count;
	cout << "Введено чисел: " << count << endl;
	cout << "Сумма чисел: " << sum << endl;
	cout << "Среднее арифметическое: " << round(arethmetic * 100) / 100;
}
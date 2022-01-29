//Амиров

#include <iostream>
#include <windows.h>
#include <cmath>

using namespace std;

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	setlocale(LC_ALL, "");

	int monthDay;
	int monthNumber;
	int yearNumber;
	int centryNumber;
	int numberOfWeek = 0;

	cout << "Enter the data: " << endl;
	cout << "Day of the month - ";
	cin >> monthDay;
	cout << "Number of the month - ";
	cin >> monthNumber;
	cout << "Number of the year - ";
	cin >> yearNumber;

	if ((monthNumber == 1) || (monthNumber == 2)) {
		yearNumber--;
	}
	monthNumber -= 2;
	if (monthNumber < 1) {
		monthNumber += 12;
	}
	centryNumber = yearNumber / 100;

	numberOfWeek = (monthDay + (13 * monthNumber - 1) / 5 + yearNumber + yearNumber / 4 + centryNumber / 4 - 2 * centryNumber + 777) % 7;

	switch (numberOfWeek) {
	case 0:
		cout << "Sunday";
		break;
	case 1:
		cout << "Monday";
		break;
	case 2:
		cout << "Tuesday";
		break;
	case 3:
		cout << "Wednesday";
		break;
	case 4:
		cout << "Thursday";
		break;
	case 5:
		cout << "Friday";
		break;
	case 6:
		cout << "Saturday";
		break;
	}

	int quantity;
	int summary = 0;

	cout << "Количество суммируемых чисел = ";
	cin >> quantity;

	for (int i = 1; i <= quantity; i++) {
		summary += i;
	}
	cout << summary;
}
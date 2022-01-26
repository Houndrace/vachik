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

	float alpha;
	float t;
	int v0;
	float x;
	float y;
	int R;
	int H;
	int P;
	const double pi = 3.14;
	const double g = 9.8;

	cout << "Data input." << endl;
	cout << "Enter initial speed - ";
	cin >> v0;
	cout << "Enter alpha angle in degrees - ";
	cin >> alpha;
	cout << "Enter distance to the target - ";
	cin >> R;
	cout << "Enter height below the target - ";
	cin >> H;
	cout << "Enter height of the target - ";
	cin >> P;

	x = R; 
	t = x / (v0 * cos(alpha * pi / 180)); //calculating time by the formula
	y = v0 * t * sin(alpha * pi / 180) - g * pow(t, 2) / 2; //how high is the hit
	//hit check
	if ((y > H) && (y < (P + H))) {
		cout << "There is hit";
	} else {
		cout << "There is no hit";
	}
}

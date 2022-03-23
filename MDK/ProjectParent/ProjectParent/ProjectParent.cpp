
// Amirov. Var 2
#include <iostream>
#include <windows.h>

bool isNumber(char []);
char attachArguments(char [], char[], char [], char []);

int main() {
	char pathToParentExe[MAX_PATH];
	char pathToChildExe[MAX_PATH];
	char argument1[50];
	char argument2[50];
	char argument3[50];
	int selector;
	// get the location of the project's .exe file
	GetCurrentDirectoryA(MAX_PATH, pathToParentExe);
	strcpy_s(pathToChildExe, pathToParentExe);
	// choose the task
	std::cout << "choose the task(1, 2, 3)" << std::endl;
	std::cout << "Task - ";
	std::cin >> selector;
	std::cout << "Enter the argument(s) - " << std::endl;
	switch (selector) {
	case 1:
		strcat_s(pathToChildExe, "\\Child1.exe ");
		std::cin >> argument1 >> argument2 >> argument3;
		attachArguments(pathToChildExe, argument1, argument2, argument3);
		break;
	case 2:
		strcat_s(pathToChildExe, "\\Child2.exe ");
		std::cin >> argument1;
		strcat_s(pathToChildExe, argument1);
		break;
	case 3:
		strcat_s(pathToChildExe, "\\Child3.exe ");
		std::cin >> argument1;
		strcat_s(pathToChildExe, argument1);
		break;
	default:
		return 0;
	}

	if (!isNumber(argument1) | !isNumber(argument2) | !isNumber(argument3)) {
		std::cout << "The argument entered isn't a number" << std::endl;
		system("pause");
		return 0;
	}
	system(pathToChildExe);
	system("pause");
}

bool isNumber(char str[]) {
	int length = strlen(str);
	int countDot = 0;

	for (int i = 0; i < length; i++) {
		if (!isdigit(str[i])) {
			if (str[i] == '.') {
				countDot++;
				if (countDot > 1) {
					return false;
				}
			} else {
				return false;
			}
		}
	}
	return true;
}

char attachArguments(char str[], char arg1[], char arg2[], char arg3[]) {
	strcat_s(str, MAX_PATH, arg1);
	strcat_s(str, MAX_PATH, " ");
	strcat_s(str, MAX_PATH, arg2);
	strcat_s(str, MAX_PATH, " ");
	strcat_s(str, MAX_PATH, arg3);

	return str[MAX_PATH];
}
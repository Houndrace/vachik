// Amirov. Var 2
#include <iostream>
#include <windows.h>

int main() {
	char pathToParentExe[MAX_PATH];
	char pathToChildExe[MAX_PATH];
	int selector;
	// get the location of the project's .exe file
	GetCurrentDirectoryA(MAX_PATH, pathToParentExe);
	strcpy_s(pathToChildExe, pathToParentExe);
	// choose the task
	std::cout << "choose the task(1, 2, 3)" << std::endl;
	std::cout << "Task - ";
	std::cin >> selector;
	switch (selector) {
	case 1:
		strcat_s(pathToChildExe, "\\Child1.exe 1, 10, 2");
		break;
	case 2:
		strcat_s(pathToChildExe, "\\Child2.exe 16");
		break;
	case 3:
		strcat_s(pathToChildExe, "\\Child3.exe 123321");
		break;
	default:
		return 0;
	}

	system(pathToChildExe);
	system("pause");
}

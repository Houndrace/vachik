// Amirov 2-09PS-1
// 2. Создайте две программы, которые:
//		1)  Запускается и выводит произвольное сообщение.Закрывается после нажатия любой клавиши
//		2) Запускаетсся и выводит сообщение "wait", до тех пор, пока первая программа работает.После завершения работы первой программы необходимо вывести слово "work"
#include <iostream>
#include <windows.h>

using namespace std;
DWORD WINAPI Wait(LPVOID);
bool isWait;

int main() {
	char lpPathToChild[255];
	STARTUPINFOA si;
	PROCESS_INFORMATION pi;
	HANDLE hMutex;
	HANDLE hWaitThread;
	DWORD IDWaitThread;
	GetCurrentDirectoryA(255, lpPathToChild);
	strcat_s(lpPathToChild, "\\Debug\\Child.exe");

	ZeroMemory(&si, sizeof(STARTUPINFO));
	si.cb = sizeof(STARTUPINFO);
	if (!CreateProcessA(lpPathToChild, NULL, NULL, NULL, FALSE, CREATE_NEW_CONSOLE, NULL, NULL, &si, &pi)) {
		cout << "Error code2: " << GetLastError() << endl;
		return -1;
	}
	Sleep(100);
	hMutex = OpenMutexA(SYNCHRONIZE, FALSE, "DemoMutex");
	if (hMutex == NULL) {
		cout << "Error code1: " << GetLastError() << endl;
		return -1;
	}

	hWaitThread = CreateThread(NULL, NULL, Wait, NULL, NULL, &IDWaitThread);
	isWait = true;

	WaitForSingleObject(hMutex, INFINITE);
	isWait = false;
	cout << "work" << endl;
	ReleaseMutex(hMutex);

	CloseHandle(hMutex);
	CloseHandle(pi.hThread);
	CloseHandle(pi.hProcess);
}

DWORD WINAPI Wait(LPVOID) {
	while (isWait) {
		cout << "wait" << endl;
		Sleep(1000);
	}
	return 0;
}
//	The child code is given below 
//	#include <iostream>
//	#include <windows.h>
//	
//	using namespace std;
//	
//	int main() {
//		HANDLE hMutex = CreateMutexA(NULL, FALSE, "DemoMutex");
//	
//		if (hMutex == NULL) {
//			cout << "Error code3: " << GetLastError() << endl;
//			return -1;
//		}
//	
//		WaitForSingleObject(hMutex, INFINITE);
//		cout << "Hi!" << endl;
//		system("pause");
//		ReleaseMutex(hMutex);
//	
//		CloseHandle(hMutex);
//	}
ѕример 1
//реализаци€ синхронизации через переменные
//дл€ каждого потока имеетс€ переменна€ "flag", котора€ сигнализирует
//работает ли поток
#include <iostream>
#include <windows.h>

using namespace std;

HANDLE hThread1;
HANDLE hThread2;
bool workThread1 = false;
bool workThread2 = false;
bool isActiveThread1 = true;
bool isActiveThread2 = true;
int delayThread = 50;
int count1;

DWORD WINAPI Thread1(LPVOID) {
	while (isActiveThread1) {
		if (workThread2) {
			Sleep(1);
		} else {
			workThread1 = true;
			cout << "+";
			count1++;
			workThread1 = false;
			Sleep(delayThread);
		}
	}
	return 0;
}

DWORD WINAPI Thread2(LPVOID) {
	while (isActiveThread2) {
		if (workThread1) {
			Sleep(1);
		} else {
			workThread2 = true;
			cout << "-";
			count1--;
			workThread2 = false;
			Sleep(delayThread);
		}
	}
	return 0;
}

DWORD WINAPI ThreadStop(LPVOID) {
	char tmp[10];
	cin >> tmp;
	isActiveThread1 = false;
	isActiveThread2 = false;
	CloseHandle(hThread1);
	CloseHandle(hThread2);
	system("cls");
	cout << count1;
	return 0;
}

int main() {
	workThread1 = true;
	workThread2 = false;
	count1 = 0;
	cout << "Input any text to exit\n";
	DWORD idThreadStop;
	HANDLE hThreadStop = CreateThread(NULL, 0, ThreadStop, (void*)NULL, 0, &idThreadStop);
	if (hThreadStop == NULL) return -1;
	Sleep(10);
	DWORD idThread1;
	hThread1 = CreateThread(NULL, 0, Thread1, (void*)NULL, 0, &idThread1);
	DWORD idThread2;
	hThread2 = CreateThread(NULL, 0, Thread2, (void*)NULL, 0, &idThread2);
	WaitForSingleObject(hThreadStop, INFINITE);
}

// ѕример 2
//реализаци€ синхронизации через переменные
//flag - мен€ет свое состо€ние 1->0 и 0->1
#include <iostream>
#include <windows.h>

using namespace std;
bool isActiveThread1 = true;
bool isActiveThread2 = true;
bool volatile flag = true;
int count;

DWORD WINAPI Thread1(LPVOID) {
	while (isActiveThread1) {
		if (flag) {
			cout << "+";
			::count++;
			flag = !flag;
		}
	}
	return 0;
}

DWORD WINAPI Thread2(LPVOID) {
	while (isActiveThread2) {
		if (!flag) {
			cout << "-";
			::count--;
			flag = !flag;
		}
	}
	return 0;
}

HANDLE hThread1;
HANDLE hThread2;
DWORD WINAPI ThreadStop(LPVOID) {
	char tmp[10];
	cin >> tmp;
	isActiveThread1 = false;
	isActiveThread2 = false;
	CloseHandle(hThread1);
	CloseHandle(hThread2);
	system("cls");
	cout << ::count;
	return 0;
}

int main() {
	::count = 0;
	DWORD idThreadStop;
	HANDLE hThreadStop = CreateThread(NULL, 0, ThreadStop, (void*)NULL, 0, &idThreadStop);
	if (hThreadStop == NULL)
		return -1;
	flag = true;
	Sleep(10);
	DWORD idThread1;
	hThread1 = CreateThread(NULL, 0, Thread1, (void*)NULL, 0, &idThread1);
	DWORD idThread2;
	hThread2 = CreateThread(NULL, 0, Thread2, (void*)NULL, 0, &idThread2);
	WaitForSingleObject(hThreadStop, INFINITE);
}
#include <iostream>
#include <windows.h>

using namespace std;

DWORD WINAPI FillArray(LPVOID);
DWORD WINAPI OutputArray(LPVOID);

int main() {
	HANDLE hThread;
	DWORD IDThread;
	int length = 0;

	cout << "Enter the size of array -> ";
	cin >> length;

	int* array1 = new int[length+1];
	array1[0] = length;

	hThread = CreateThread(NULL, 0, FillArray, (void*)array1, 0, &IDThread);
	if (hThread == NULL) {
		return GetLastError();
	}
	WaitForSingleObject(hThread, INFINITE);
	CloseHandle(hThread);

	hThread = CreateThread(NULL, 0, OutputArray, (void*)array1, 0, &IDThread);
	if (hThread == NULL) {
		return GetLastError();
	}
	WaitForSingleObject(hThread, INFINITE);
	CloseHandle(hThread);

}

DWORD WINAPI FillArray(LPVOID array) {
	int* pArray = (int*)array;
	int length = pArray[0];
	srand((unsigned)time(NULL));

	for (int i = 1; i <= length; i++) {
		pArray[i] = rand();
	}
	return 0;
}

DWORD WINAPI OutputArray(LPVOID array) {
	int* pArray = (int*)array;
	int length = pArray[0];

	for (int i = 1; i <= length; i++) {
		cout << "[" << i << "] = " << pArray[i] << "\n";
	}
	return 0;
}
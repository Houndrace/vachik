#include <iostream>
#include <windows.h>

using namespace std;

int main() {
	HANDLE hMutex = CreateMutexA(NULL, FALSE, "DemoMutex");
	
	if (hMutex == NULL) {
		cout << "Error code3: " << GetLastError() << endl;
		return -1;
	}

	WaitForSingleObject(hMutex, INFINITE);
	cout << "Hi!" << endl;
	system("pause");
	ReleaseMutex(hMutex);

	CloseHandle(hMutex);
}
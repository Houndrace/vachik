#include <windows.h>
#include <iostream>

using namespace std;

int main() {
	int i, j;
	HANDLE hMutex = OpenMutexA(SYNCHRONIZE, FALSE, "DemoMutex");

	if (hMutex == NULL) {
		cout << "Error code: " << GetLastError() << endl;
		return -1;
	}

	for (j = 10; j < 20; ++j) {
		WaitForSingleObject(hMutex, INFINITE);
		for (i = 0; i < 10; ++i) {
			cout << j << ' ' << flush;
			Sleep(5);
		}
		cout << endl;
		ReleaseMutex(hMutex);
	}
	CloseHandle(hMutex);
}
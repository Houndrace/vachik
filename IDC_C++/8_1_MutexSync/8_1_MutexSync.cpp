#include <iostream>
#include <windows.h>

using namespace std;

int main() {
	char lpPathToChild[255];
	STARTUPINFOA si;
	PROCESS_INFORMATION pi;
	HANDLE hMutex = CreateMutexA(NULL, FALSE, "DemoMutex");

	GetCurrentDirectoryA(255, lpPathToChild);
	strcat_s(lpPathToChild, "\\Debug\\8_1_Child.exe");

	ZeroMemory(&si, sizeof(STARTUPINFO));
	si.cb = sizeof(STARTUPINFO);

	if (hMutex == NULL) {
		cout << "Error code: " << GetLastError() << endl;
		return -1;
	}

	if (!CreateProcessA(lpPathToChild, NULL, NULL, NULL, FALSE, NULL, NULL, NULL, &si, &pi)) {
		cout << "Error code: " << GetLastError() << endl;
		return -1;
	}
	
	for (int j = 0; j < 10; ++j) {
		WaitForSingleObject(hMutex, INFINITE);
		for (int i = 0; i < 10; ++i) {
			cout << j << ' ' << flush;
			Sleep(10);
		}
		cout << endl;
		ReleaseMutex(hMutex);
	}
	
	CloseHandle(hMutex);

	WaitForSingleObject(pi.hProcess, INFINITE);

	CloseHandle(pi.hThread);
	CloseHandle(pi.hProcess);
}
// The Child code is given below
//int main() {
//	int i, j;
//	HANDLE hMutex = OpenMutexA(SYNCHRONIZE, FALSE, "DemoMutex");
//
//	if (hMutex == NULL) {
//		cout << "Error code: " << GetLastError << endl;
//		return -1;
//	}
//
//	for (j = 10; j < 20; ++j) {
//		WaitForSingleObject(hMutex, INFINITE);
//		for (i = 0; i < 10; ++i) {
//			cout << j << ' ' << flush;
//			Sleep(5);
//		}
//		cout << endl;
//		ReleaseMutex(hMutex);
//	}
//	CloseHandle(hMutex);
//}
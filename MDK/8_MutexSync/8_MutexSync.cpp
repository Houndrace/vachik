// Amirov 2-09PS-1
// 3. —оздайте программу, котора€ не позвол€ет запускать свой второй экземпл€р. —инхранизацию выполните через MUTEX
#include <iostream>
#include <windows.h>

using namespace std;

int main() {
	HANDLE hMutex = OpenMutexA(SYNCHRONIZE, FALSE, "DemoMutex");

	if (hMutex == NULL) {
		CreateMutexA(NULL, FALSE, "DemoMutex");
	} else {
		cout << "The program is launched" << endl;
		system("pause");
		return 0;
	}

	WaitForSingleObject(hMutex, INFINITE);
	while (true) {
		cout << "working..." << endl;
		Sleep(1000);
	}
	ReleaseMutex(hMutex);
	CloseHandle(hMutex);
}
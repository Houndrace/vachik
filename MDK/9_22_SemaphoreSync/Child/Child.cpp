#include <iostream>
#include <windows.h>

using namespace std;

int main() {
    HANDLE hSemaphore = CreateSemaphoreA(NULL, 0, 100, "FillArray");

    if (hSemaphore == NULL)
        return GetLastError();

    for (int i = 0; i < 100; i++) {
        cout << i << endl;
        ReleaseSemaphore(hSemaphore, 1, NULL);
        Sleep(10);
    }

    CloseHandle(hSemaphore);
}

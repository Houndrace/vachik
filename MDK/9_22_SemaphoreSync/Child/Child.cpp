#include <iostream>
#include <windows.h>

using namespace std;

int main() {
    HANDLE hSemaphore = OpenSemaphoreA(SEMAPHORE_MODIFY_STATE, NULL, "FillArray");


    if (hSemaphore == NULL) {
        cout << "error code4: " << GetLastError();
        return -1;
    }
        

    for (int i = 0; i <= 100; i++) {
        cout << i << endl;
        Sleep(50);
    }
    ReleaseSemaphore(hSemaphore, 1, NULL);
    CloseHandle(hSemaphore);
    system("pause");
}

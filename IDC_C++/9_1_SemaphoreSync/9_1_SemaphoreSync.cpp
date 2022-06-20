// Amirov 2-09PS-1
// Создайте одну программу, в которой будет использовано несколько потоков. Потоки выполняют следующие действия:
//  1) Заполняет массив числами от 0 до 100, с определенной задержкой
//  2) Выводит массив группами по 10 чисел, после их заполнения первым потоком.
// Потоки необходимо синхронизовать через счетный семафор
#include <iostream>
#include <windows.h>

using namespace std;

volatile int arr[100];
DWORD WINAPI FillArray(LPVOID);

int main() {
    DWORD IDFillArray;
    HANDLE hSemaphore = CreateSemaphoreA(NULL, 0, 100, "FillArray");
    HANDLE hFillArray = CreateThread(NULL, NULL, FillArray, NULL, NULL, &IDFillArray);

    if (hFillArray == NULL || hSemaphore == NULL)
        return GetLastError();

    cout << "The array: " << endl;
    for (int i = 0; i < 100; i++) {
        WaitForSingleObject(hSemaphore, INFINITE);
        cout << "arr[" << i << "] = " << arr[i] << endl;
        Sleep(11);
    }

    CloseHandle(hFillArray);
    CloseHandle(hSemaphore);
}

DWORD WINAPI FillArray(LPVOID) {
    HANDLE hSemaphore = OpenSemaphoreA(SEMAPHORE_MODIFY_STATE, NULL, "FillArray");

    if (hSemaphore == NULL)
        return GetLastError();

    for (int i = 0; i <= 100; i++) {
        if (i != 100)
            arr[i] = i + 1;

        if (!(i % 10) && (i != 0))
            ReleaseSemaphore(hSemaphore, 10, NULL);
        Sleep(200);
    }

    CloseHandle(hSemaphore);
    return 0;
}
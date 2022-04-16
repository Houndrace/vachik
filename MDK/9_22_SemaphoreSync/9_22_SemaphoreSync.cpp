// Amirov 2-09PS-1
// Создайте две программы, со следующим функционалом:
//  1) Запускается и выводит числа от 0 до 100
//  2) Запускаетсся и выводит сообщение "wait", до тех пор, пока первая программа работает.После завершения работы первой программы необходимо вывести слово "work"
// Потоки необходимо синхронизовать через счетный семафор
#include <iostream>
#include <windows.h>

using namespace std;

DWORD WINAPI FillArray(LPVOID);
bool isWait;

int main() {  
    DWORD IDFillArray;
    HANDLE hFillArray;
    STARTUPINFOA si;
    PROCESS_INFORMATION pi;
    char lpChildPath[255] = "";

    GetCurrentDirectoryA(255, lpChildPath);
    strcat_s(lpChildPath, "\\x64\\Debug\\Child.exe");
    ZeroMemory(&si, sizeof(STARTUPINFO));
    si.cb = sizeof(STARTUPINFO);

    if (!CreateProcessA(lpChildPath, NULL, NULL, NULL, FALSE, CREATE_NEW_CONSOLE, NULL, NULL, &si, &pi)) {
        cout << "error code 1: " << GetLastError();
        return -1;
    }

    hFillArray = CreateThread(NULL, NULL, FillArray, NULL, NULL, &IDFillArray);
    if (hFillArray == NULL) {
        cout << "error code 2: " << GetLastError();
        return -1;
    }
    isWait = true;
    WaitForSingleObject(hFillArray, INFINITE);

    CloseHandle(hFillArray);
    CloseHandle(pi.hThread);
    CloseHandle(pi.hProcess); 
}

DWORD WINAPI FillArray(LPVOID) {
    HANDLE hSemaphore = OpenSemaphoreA(SEMAPHORE_MODIFY_STATE, NULL, "FillArray");

    if (hSemaphore == NULL) {
        cout << "error code 3: " << GetLastError();
        return -1;
    }

    while (isWait) {
        WaitForSingleObject(hSemaphore, INFINITE);
        cout << "wait" << endl;
    }

    CloseHandle(hSemaphore);
    return 0;
}
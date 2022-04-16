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
    HANDLE hSemaphore = CreateSemaphoreA(NULL, 0, 1, "FillArray");
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
    if ((hFillArray == NULL) || (hSemaphore == NULL)) {
        cout << "error code 2,3: " << GetLastError();
        return -1;
    }

    isWait = true;
    WaitForSingleObject(hSemaphore, INFINITE);
    isWait = false;
    cout << "work" << endl;

    CloseHandle(hFillArray);
    CloseHandle(hSemaphore);
    CloseHandle(pi.hThread);
    CloseHandle(pi.hProcess); 
}

DWORD WINAPI FillArray(LPVOID) {
    while (isWait) {
        cout << "wait" << endl;
        Sleep(40);
    }
    return 0;
}
// The child is given below
//#include <iostream>
//#include <windows.h>
//
//using namespace std;
//
//int main() {
//    HANDLE hSemaphore = OpenSemaphoreA(SEMAPHORE_MODIFY_STATE, NULL, "FillArray");
//
//
//    if (hSemaphore == NULL) {
//        cout << "error code4: " << GetLastError();
//        return -1;
//    }
//
//
//    for (int i = 0; i <= 100; i++) {
//        cout << i << endl;
//        Sleep(50);
//    }
//    ReleaseSemaphore(hSemaphore, 1, NULL);
//    CloseHandle(hSemaphore);
//    system("pause");
//}
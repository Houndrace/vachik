#include <iostream>
#include <windows.h>

using namespace std;

int main(int argc, char* argv[]) {
    STARTUPINFO si;
    PROCESS_INFORMATION pi;
    char lpApp[] = "D:\\GitHub\\vachik\\MDK\\Win32APITask1\\Debug\\Win32APITask1.exe 1";
    int argument = 0;

    ZeroMemory(&si, sizeof(STARTUPINFO));
    si.cb = sizeof(STARTUPINFO);

    if (!CreateProcessA(NULL, lpApp, NULL, NULL, FALSE, 0, NULL, NULL, &si, &pi)) {
        cout << "The new process isn't created." << "Check a name of the process." << endl;
    } else {
        cout << "123";
    }

    Sleep(200);
    CloseHandle(pi.hThread);
    CloseHandle(pi.hProcess);
}

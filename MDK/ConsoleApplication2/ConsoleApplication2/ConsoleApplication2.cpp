#include <iostream>
#include <Windows.h>

using namespace std;

int main(int argc, char* argv[]) {

    STARTUPINFOA si;
    PROCESS_INFORMATION pi;

    ZeroMemory(&si, sizeof(si));
    si.cb = sizeof(si);
    ZeroMemory(&pi, sizeof(pi));

    char lpApp[255] = "D:\\GitHub\\vachik\\MDK\\ConsoleApplication2\\Debug\\ConsoleApplication2.exe ";
    char numberChar[255] = "";
    int number = 1;

    if (argc == 2) {
        number = atoi(argv[1]);
    }

    std::cout << "Number clone is: " << number << std::endl;
    number++;
    _itoa_s(number, numberChar, 10);

    strcat_s(lpApp, numberChar);

    if (!CreateProcessA(NULL, lpApp, NULL, NULL, FALSE, 0, NULL, NULL, &si, &pi)) {
        std::cout << "Error. -1" << endl;
        return -1;
    }

    Sleep(1000);
    CloseHandle(pi.hThread);
    CloseHandle(pi.hProcess);
    ExitProcess(0);
}


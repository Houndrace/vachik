#include <iostream>
#include <windows.h>

using namespace std;
// 3. Запускает саму себя в том же окне, и увеличивает входной параметр на единицу. Данную информацию выводить в первой строке, в формате «клон: (число)»
int main(int argc, char* argv[]) {
    STARTUPINFOA si;
    PROCESS_INFORMATION pi;
    char pathToExe[MAX_PATH];  
    char lpApp[MAX_PATH] = "";
    int argument = 1;
    char buf[MAX_PATH] = "";
    
    strcpy_s(lpApp, pathToExe);
    GetCurrentDirectoryA(MAX_PATH, pathToExe);
    strcpy_s(pathToExe, "\\Debug\\ConsoleApplication1.exe ");

    ZeroMemory(&si, sizeof(STARTUPINFO));
    si.cb = sizeof(STARTUPINFO);

    if (argc == 2) {
        argument = atoi(argv[1]);
    }
    Sleep(100);
    system("cls");

    cout << "clone: " << argument << endl;
    argument++;
    _itoa_s(argument, buf, 10);

    strcat_s(lpApp, buf);

    if (!CreateProcessA(NULL, lpApp, NULL, NULL, FALSE, 0, NULL, NULL, &si, &pi)) {
        cout << "The new process isn't created. " << "Check a name of the process." << endl;
        return 0;
    } 

    CloseHandle(pi.hThread);
    CloseHandle(pi.hProcess);
}

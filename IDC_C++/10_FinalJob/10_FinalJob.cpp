// Amirov 2-09PS-1 5 VARIANT
// Реализовать задачу согласно своему варианту. Задачу решить: процедурным подходом
#include <iostream>
#include <windows.h>

using namespace std;

DWORD WINAPI Work(LPVOID);
DWORD WINAPI SumElements(LPVOID);
int arrSize = 0;
int k = 0;


int main() {
    DWORD IDWork;
    DWORD IDSumElements;

    cout << "Enter the size of array: ";
    cin >> arrSize;
    char* originalArr = new char[arrSize];
    char* finalArr = new char[arrSize];

    HANDLE hSemaphore = CreateSemaphoreA(NULL, 0, arrSize, "WorkMain");
    if (hSemaphore == NULL) {
        cout << "Create hSemaphore: " << GetLastError();
        return -1;
    }

    cout << "Enter the array elements: " << endl;
    for (int i = 0; i < arrSize; i++) {
        cout << "array[" << i << "] = ";
        cin >> originalArr[i];
        finalArr[i] = originalArr[i];
    }

    cout << "Enter the 'k' number: ";
    cin >> k;

    HANDLE hWork = CreateThread(NULL, NULL, Work, (void*)finalArr, NULL, &IDWork);
    HANDLE hSumElements = CreateThread(NULL, NULL, SumElements, (void*)finalArr, NULL, &IDSumElements);
    if (hWork == NULL || hSumElements == NULL) {
        cout << "Create hWork or hSumElements: " << GetLastError();
        return -23;
    }
    cout << flush;
    cout << "Final array:" << endl;
    Sleep(50);

    HANDLE hSemaphore2 = OpenSemaphoreA(SEMAPHORE_MODIFY_STATE, 0, "SumMain");
    if (hSemaphore2 == NULL) {
        cout << "Open hSemaphore2: " << GetLastError();
        return -6;
    }

    
    for (int i = 0; i < arrSize; i++) {
        if (i == k) {
            ReleaseSemaphore(hSemaphore2, 1, NULL);
        }
        WaitForSingleObject(hSemaphore, INFINITE);
        cout << "array[" << i << "] = " << finalArr[i] << endl;
    }

    CloseHandle(hSemaphore);
    CloseHandle(hSemaphore2);
    CloseHandle(hWork);
    CloseHandle(hSumElements);
    delete[] finalArr;
    delete[] originalArr;
    return 0;
}

DWORD WINAPI Work(LPVOID array) {
    int interval = 0;
    char* finalArr = (char*)array;
    HANDLE hSemaphore = OpenSemaphoreA(SEMAPHORE_MODIFY_STATE, 0, "WorkMain");
    if (hSemaphore == NULL) {
        cout << "Open hSemaphore: " << GetLastError();
        return -5;
    }

    cout << "Enter an interval in seconds: ";
    cin >> interval;
    for (int i = 0; i < arrSize; i++) {
        int minI = i;
        for (int j = i + 1; j < arrSize; j++) {
            if ((int)finalArr[j] < (int)finalArr[minI])
                minI = j;
        }
        int temp = finalArr[i];
        finalArr[i] = finalArr[minI];
        finalArr[minI] = temp;

        ReleaseSemaphore(hSemaphore, 1, NULL);
        Sleep(interval * 1000);
    }
    CloseHandle(hSemaphore);
    return 0;
}

DWORD WINAPI SumElements(LPVOID array) {
    int sum = 0;
    char* finalArr = (char*)array;

    HANDLE hSemaphore2 = CreateSemaphoreA(NULL, 0, 1, "SumMain");
    if (hSemaphore2 == NULL) {
        cout << "Create hSemaphore2: " << GetLastError();
        return -4;
    }
    
    WaitForSingleObject(hSemaphore2, INFINITE);
    for (int i = 0; i < k; i++) {  
        sum += finalArr[i];
    }
    cout << "The sum of first 'k' elements(character codes): " << sum << endl;
    CloseHandle(hSemaphore2);
    return 0;
}
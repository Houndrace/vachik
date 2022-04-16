// Amirov 2-09PS-1
// Производственная линия (поток) создает деталь А раз в две секунды, и останавливается на обслуживание через 45 секунд. на 15 секунд После обслуживания первая деталь выпускается через четыре секунды.
// Определите количество деталей произведенных через 2 часа. Математические расчеты использовать запрещено. В ответе необходимо выводить на экран:
// общее время, время работы линии после обслуживания и количество деталей.
// При проверке решения разрешено уменьшить время задержки. Во время работы программы необходимо выводить следующую информацию: текущие секунды от старта, отметка о создании детали, статус линии
#include <iostream>
#include <windows.h>

using namespace std;

DWORD WINAPI MakeDetail(LPVOID);
DWORD WINAPI TakeABreak(LPVOID);
DWORD WINAPI StopThreads(LPVOID);
int curState = 0;
int timer = 1;
int countDetails = 0;

int main() {
	DWORD IDMakeDetail;
	DWORD IDTakeABreak;
	DWORD IDThreadStop;

	HANDLE hMakeDetailThread = CreateThread(NULL, 0, MakeDetail, (void*)NULL, 0, &IDMakeDetail);
	HANDLE hTakeABreakThread = CreateThread(NULL, 0, TakeABreak, (void*)NULL, 0, &IDTakeABreak);
	HANDLE hThreadStopThread = CreateThread(NULL, 0, StopThreads, (void*)NULL, 0, &IDThreadStop);

	WaitForSingleObject(hThreadStopThread, INFINITE);

	CloseHandle(hMakeDetailThread);
	CloseHandle(hTakeABreakThread);
	cout << "Quantity of details: " << countDetails << endl;
	return 0;
}

DWORD WINAPI MakeDetail(LPVOID) {
	int workTime = 0;
	int wholeCycle = 0;
	while (true) {
		if (curState == 0) {
			Sleep(1000);
			cout << timer << " sec - working..." << endl;
			workTime++;
			timer++;
			wholeCycle++;
			if (wholeCycle == 45) {
				curState = 2;
				workTime = 0;
				wholeCycle = 0;
			} else if (workTime == 2) {
				curState = 1;
				workTime = 0;
			}

			if (curState == 1) {
				countDetails++;
				cout << "detail is done " << countDetails << endl;
				if (wholeCycle == 45) {
					curState = 2;
				} else {
					curState = 0;
				}
			}
		}
	}
	return 0;
}

DWORD WINAPI TakeABreak(LPVOID) {
	int sleepTime = 15;
	while (true) {
		if (curState == 2) {
			for (int i = 1; i <= sleepTime; i++) {
				Sleep(1000);
				cout << timer << " sec - work is stopped " << endl;
				timer++;
			}
			for (int i = 0; i < 2; i++) {
				Sleep(1000);
				cout << timer << " sec - preparing..." << endl;
				timer++;
			}
			curState = 0;
		}
	}
	return 0;
}

DWORD WINAPI StopThreads(LPVOID) {
	while (true) {
		if (timer >= 7200) {
			break;
		}
	}
	return 0;
}
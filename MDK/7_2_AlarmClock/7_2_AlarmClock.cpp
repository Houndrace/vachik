// Amirov 2-09PS-1
// Создайте приложение будильник. Необходимо реализовать: условный таймер-часы, срабатывание сигнала в указанный момент времени, многократный повторный сигнал будильника, через определенный промежуток.
// После срабатывания будильника, пользователь может нажать на любую клавишу, что приведет к сбросу его статуса, но программа должна продолжать работу. На экран необходимо выводить:
// текущее время,
// время срабатывания будильника,
// текущий статус будильника – состояние : сработал или не сработал,
// количество повторов, после наступления времени.
#include <iostream>
#include <windows.h>

using namespace std;

DWORD WINAPI Clock(LPVOID);
DWORD WINAPI Alarm(LPVOID);
DWORD WINAPI ResetAlarm(LPVOID);

int wholeTime = 1;
bool isAlarmOn = false;
int alarmTime = 60;

int main() {
	DWORD IDClock;
	DWORD IDResetAlarm;
	DWORD IDAlarm;

	HANDLE hClockThread = CreateThread(NULL, 0, Clock, (void*)NULL, 0, &IDClock);
	HANDLE hAlarmThread = CreateThread(NULL, 0, Alarm, (void*)NULL, 0, &IDAlarm);
	HANDLE hResetAlarmThread = CreateThread(NULL, 0, ResetAlarm, (void*)NULL, 0, &IDResetAlarm);

	WaitForSingleObject(hResetAlarmThread, INFINITE);
	CloseHandle(hClockThread);
	CloseHandle(hAlarmThread);
	CloseHandle(hResetAlarmThread);
	return 0;
}
// Часы не реализовывал
DWORD WINAPI Clock(LPVOID) {
	int minute = 0;
	int sec = 1;
	while (true) {
		if (minute < 10 && sec < 10) {
			cout << '0' << minute << ":" << '0' << sec << endl;
		} else if (sec < 10) {
			cout << minute << ":" << '0' << sec << endl;
		} else if (minute < 10) {
			cout << '0' << minute << ":" << sec << endl;
		} else {
			cout << minute << ":" << sec << endl;
		}
		sec++;
		wholeTime++;
		if (sec % 60 == 0) {
			minute++;
			sec = 0;
		}
		Sleep(1000);
	}
	return 0;
}

DWORD WINAPI Alarm(LPVOID) {
	while (true) {
		if (wholeTime == alarmTime) {
			isAlarmOn = true;
			Sleep(1100);
		}
		if (isAlarmOn) {
			cout << "Alarm time - " << alarmTime / 60 << " min : " << alarmTime % 60 << " sec" << endl;
			cout << "Alarm - on" << endl;
			Sleep(4000);
		}
	}
}

DWORD WINAPI ResetAlarm(LPVOID) {
	char tmp[10];
	while (true) {
		if (isAlarmOn) {
			cin >> tmp;
			isAlarmOn = false;
			cout << "Next alarm is in 30 sec" << endl;
			alarmTime = wholeTime - 1;
			alarmTime += 30;
			}
		}
	return 0;
}
//������
//153. �������� ���������, ������� ������� ������� ������ ��������� �� �������� ��������� � ���������� ���������� ������.
//154. �������� ���������, ������� ������� ������ ("��������") ��������� �� �������� ��������� � ���������� ���������� ������.

#include <iostream>
#include <Windows.h>

using namespace std;

void t153();
void t154();

int main()
{
    setlocale(LC_ALL, "russian");

    int taskChecker;
    char ynCheker;

    while (true) {
        cout << "���������� ������� (153/154) -> ";
        cin >> taskChecker;
        switch (taskChecker)
        {
        case 153:
            t153();
            break;
        case 154:
            t154();
            break;
        default:
            break;
        }
        cout << "���������� (Y / N) - ";
        cin >> ynCheker;
        if (ynCheker == 'N') {
            break;
        }
        system("cls");
    }
}

void t153() {
    int array[10];
    int min;
    int temp;

    cout << "���� ������." << endl;
    cout << "������� ������: " << endl;
    //������ ������
    for (int i = 0; i < 10; i++) {
        cout << "array[" << i << "] = ";
        cin >> array[i];
    }
    //���������� �������
    for (int i = 0; i < 10; i++) {
        min = i;                            //����������� ����������� ������ ��� ������ �������� ���������
        //����� ������� ������������ ��������
        for (int j = i + 1; j < 10; j++) {
            if (array[min] > array[j]) {
                min = j;                    //���������� ������ ������������ ��������            
            }
        }
        //������ ������� ����������� � i-� �������
        temp = array[i];                    //��������� i-� �������                             
        array[i] = array[min];              //���������� � i-� ������� �����������              
        array[min] = temp;                  //���������� � ����������� ������� i-� �������      
    }
    //������� ������
    cout << "�������� ���������: " << endl;
    for (int i = 0; i < 10; i++) {
        cout << "array[" << i << "] = " << array[i] << endl;
    }
}

void t154() {
    int array[10];
    int temp;

    cout << "���� ������." << endl;
    cout << "������� ������: " << endl;
    //������ ������
    for (int i = 0; i < 10; i++) {
        cout << "array[" << i << "] = ";
        cin >> array[i];
    }
    //���������� ������
    for (int i = 0; i < 10; i++) {
        for (int j = 0; j < 9; j++) {
            if (array[j] > array[j + 1]) {      //���� ������� ������, ��� ��������� �� ��� 
                temp = array[j];                //�� �������� j-� 
                array[j] = array[j + 1];        //� j + 1-� ��������
                array[j + 1] = temp;            //����� ��������� ����������
            }
        }
    }
    //������� �������� ������
    for (int i = 0; i < 10; i++) {
        cout << "array[" << i << "] = " << array[i] << endl;
    }
}
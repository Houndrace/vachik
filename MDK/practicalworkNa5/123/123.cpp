#include <iostream>

using namespace std;
int main()
{
    char input[255] = "asdfghasdfghdsahhgf";
    double length = strlen(input);
    double arr[255] = {0.00};

    for (int i = 0; i < length; i++) {
        for (int j = i + 1; j < length; j++) {
            if ((input[i] == input[j]) && (input[i] != '0')) {
                arr[i]++;
                input[j] = '0';
            }
        }
    }

    for (int i = 0; i < length; i++) {
        if (arr[i] != 0) {
            arr[i]++;
        }
    }

    for (int i = 0; i < length; i++) {
        if (arr[i] != 0) {
            arr[i] = arr[i] / length * 100;
        }
    }
    for (int i = 0; i < length; i++) {
        if (input[i] != '0') {
            cout << input[i] << " - " << arr[i] << " %" << endl;
        }
    }
}
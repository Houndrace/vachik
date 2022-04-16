#include <iostream> 

using namespace std;
// Replacing a sign "*" with its serial number in an char array
int main()
{
    char str[255] = "";
    char output[1023] = "";
    cin >> str;
    for (int i = 0; i < strlen(str); i++) {
        if (str[i] == '*') {
            char temp[255] = " ";
            if (i >= 10 && i < 100)
            {
                temp[0] = '0' + i / 10;
                temp[1] = '0' + i % 10;
            }
            else if (i >= 100 && i < 256) {
                temp[0] = '0' + i / 100;
                temp[1] = '0' + i / 10 % 10;
                temp[2] = '0' + i % 10;
            }
            else {
                temp[0] = '0' + i;
            }
            strcat_s(output, temp);

        }
        else {
            char temp[2] = " ";
            temp[0] = str[i];
            strcat_s(output, temp);
        }

    }
    cout << output;
    return 0;
}
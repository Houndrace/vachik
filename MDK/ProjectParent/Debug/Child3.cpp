// Task for 5
#include <iostream>
#include <math.h>

int main(int argc, char * argv[]) {
    int num = atoi (argv[1]);
    int numTemp = num;          // Use this for temporary calculations with the number
    int lastDigits = 0;       // Last digits for comparison
    int firstDigits = num;      // First digits for comparison
    int digitsQuantity = 0;
    int halfQuantity = 0;
    // Find a quantity of digits of our number
    while (numTemp != 0) {
        numTemp /= 10;
        digitsQuantity++;
    }
    numTemp = num;
    halfQuantity = digitsQuantity / 2; // It is half of the quantity of digits needed to find the first and second parts of our number

    firstDigits /= pow(10, halfQuantity);
    // The decrement is necessary for the correct calculation of last digits when the quantity of digits is even
    if (digitsQuantity % 2 == 0) {
        halfQuantity--;
    }

    for (int i = halfQuantity; i > -1; i--) {
        lastDigits += numTemp % 10 * pow(10, i);
        numTemp /= 10;
    }

    if (firstDigits == lastDigits) {
        std::cout << "it's an palindrome number" << std::endl;
    } else {
        std::cout << "it isn't an palindrome number" << std::endl;
    }
}

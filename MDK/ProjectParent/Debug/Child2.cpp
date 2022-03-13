// Task for 4
#include <iostream>
#include <math.h>

int main(int argc, char * argv[]) {
    int n = atoi(argv[1]);

    for (int i = 1; pow(i, 2) <= n; i++) {
        std::cout << i << std::endl;
    }
}

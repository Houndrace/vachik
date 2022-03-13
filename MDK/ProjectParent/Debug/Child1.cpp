// Task for 3
#include <iostream>

int countDivider(int);

int main(int argc, char * argv[]) {
	int A = atoi(argv[1]);
	int B = atoi(argv[2]);
	int K = atoi(argv[3]);

	for (int i = A; i < B; i++) {
		if (countDivider(i) == K) {
			std::cout << i << std::endl;
		}
	}
}

int countDivider(int num) {
	int count = 0;	// degree of a number
	int result = 1;

	for (int i = 2; num > 1; i++) {
		// count a number of degrees
		while (num % i == 0) {
			num /= i;
			count++;
		}
		result *= (count + 1);	// use the theorem of finding divisors
		count = 0;
	}
	return result;
}
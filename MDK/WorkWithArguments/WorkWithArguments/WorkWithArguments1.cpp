#include <iostream>

int main(int argc, char *argv[])
{
	int n = atoi(argv[1]);	// Convert a char character to an integer
	// Output n times variable n
	for (int i = 0; i < n; i++) {
		std::cout << n << std::endl;
	}
}

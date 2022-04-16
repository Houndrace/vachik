#include <iostream>

int main(int argc, char *argv[])
{
	int count = 0;

	for (int i = 1; i < argc; i++) {
		if (isdigit(*argv[i])) {
			count++;
		}
	}
	
	std::cout << "Amount of numbers is " << count;
}

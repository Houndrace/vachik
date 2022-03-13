#include <iostream>

int main(int argc, char *argv[])
{
	int nOfTimes = atoi(argv[2]);

	for (int i = 0; i < nOfTimes; i++) {
		std::cout << argv[1] << std::endl;
	}
}

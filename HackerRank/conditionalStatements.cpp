#include <iostream>

int main()
{
	int x = 0;

	std::cin >> x;

	if (x > 9)
	{
		std::cout << "Greater than 9";
	}
	else if (x > 8)
	{
		std::cout << "nine";
	}
	else if (x > 7)
	{
		std::cout << "eight";
	}
	else if (x > 6)
	{
		std::cout << "seven";
	}
	else if (x > 5)
	{
		std::cout << "six";
	}
	else if (x > 4)
	{
		std::cout << "five";
	}
	else if (x > 3)
	{
		std::cout << "four";
	}
	else if (x > 2)
	{
		std::cout << "three";
	}
	else if (x > 1)
	{
		std::cout << "two";
	}
	else if (x > 0)
	{
		std::cout << "one";
	}
}
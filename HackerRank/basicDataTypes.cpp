#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <cstdio>

int main()
{
	int a = 0;
	long b = 0;
	char c = 0;
	float d = 0;
	double e = 0;

	scanf("%i %li %c %f %lf", &a, &b, &c, &d, &e);
	printf("%i\n%li\n%c\n%.03f\n%.09lf\n", a, b, c, d, e);
}
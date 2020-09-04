/* 
Prime Factorization - Have the user enter a number and find all Prime Factors (if there are any) and display them.
*/

// Created by ugurinal

#include <iostream>
#include <stdlib.h>
#include <math.h>

using std::cin;
using std::cout;
using std::endl;

bool isPrime(int x);
bool isDivisor(int num, int prime);

int main()
{
    int input = 0;
    cin >> input;

    for (int i = 2; i < input; i++)
    {
        if (isPrime(i) && isDivisor(input, i))
        {
            cout << i << endl;
        }
    }

    return 0;
}

bool isPrime(int x)
{
    for (int i = 2; i < x; i++)
    {
        if (x % i == 0)
            return false;
    }

    return true;
}

bool isDivisor(int num, int prime)
{
    if (num % prime == 0)
        return true;
    else
        return false;
}
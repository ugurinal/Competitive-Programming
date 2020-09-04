/* 
Factorial Finder
The factorial of a positive integer n is defined as the product of the sequence , 
n-1, n-2, ...1 and the factorial of 0 is defined as being 1.
Solve this using both loops and recursion.
*/

// Created by ugurinal

#include <iostream>
#include <stdlib.h>
#include <math.h>

using std::cin;
using std::cout;
using std::endl;

int factIte(int num);
int factRec(int num);

int main()
{
    int x = 0;

    cout << "Enter a positive integer to calculate factorial." << endl;
    cin >> x;
    cout << factIte(x) << endl;
    cout << factRec(x) << endl;
}

int factIte(int num)
{
    int sum = 1;

    for (int i = 1; i <= num; i++)
    {
        sum *= i;
    }

    return sum;
}

int factRec(int num)
{
    if (num == 1 || num == 0)
    {
        return 1;
    }

    return num * factRec(num - 1);
}
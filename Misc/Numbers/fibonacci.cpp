/* 
Fibonacci Sequence - Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.
*/

// Created by ugurinal

#include <iostream>
#include <stdlib.h>
#include <math.h>

using std::cin;
using std::cout;
using std::endl;

int fibRecursively(int num);
int fibIteratively(int num);

int main()
{
    int n = 0;

    cin >> n;

    int result = fibIteratively(n);
    //int result = fibRecursively(n);

    cout << result << endl;

    return 0;
}

int fibRecursively(int num)
{
    if (num = 0)
    {
        return 0;
    }
    else if (num == 1)
    {
        return 1;
    }

    return fibRecursively(num - 1) + fibRecursively(num - 2);
}

int fibIteratively(int num)
{

    if (num == 1 || num == 2)
    {
        return 1;
    }

    int a = 0;
    int b = 1;
    int c = 0;

    for (int i = 2; i < num; i++)
    {
        c = a + b;
        a = b;
        b = c;
    }

    return c;
}
/*
Next Prime Number - Have the program find prime numbers until the user chooses to stop asking for the next one.
*/

// Created by ugurinal

#include <iostream>
#include <stdlib.h>
#include <math.h>

using std::cin;
using std::cout;
using std::endl;

int findPrime(int x);

int main()
{
    cout << "Enter y/n to find next prime number" << endl;

    char choice = 0;
    int prime = 1;

    do
    {

        prime = findPrime(prime);
        cout << prime << endl;
        cin >> choice;

    } while (choice == 'y' || choice == 'Y');

    return 0;
}

int findPrime(int x)
{

    x++;

    int i = 2;
    while (i < x)
    {

        if (x % i == 0)
        {
            x++;
            i = 2;
            continue;
        }
        else
        {
            i++;
        }
    }

    return x;
}
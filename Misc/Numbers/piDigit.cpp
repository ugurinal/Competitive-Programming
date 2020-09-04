/* 
Find PI to the Nth Digit  
Enter a number and have the program generate PI up to that many decimal places. Keep a limit to how far the program will go.
*/

/*
This program uses Bailey–Borwein–Plouffe formula to calculate the PI num.
*/

// Created by ugurinal

#include <iostream>
#include <stdlib.h>
#include <math.h>

using std::cin;
using std::cout;
using std::endl;

int main()
{

    int k = 0;
    double PI = 0;

    cout << "Enter (n) the number to how many decimal to calculate. n <=30" << endl;

    do
    {
        cin >> k;
    } while (k > 30 || k < 0);

    for (int i = 0; i <= k; i++)
    {
        PI += 1.0 / pow(16, i) * ((4.0 / (8.0 * i + 1)) - (2.0 / (8.0 * i + 4)) - (1.0 / (8.0 * i + 5)) - (1.0 / (8.0 * i + 6)));
    }

    k++; //add one to account for the number before the decimal place
    cout.precision(k);
    cout << PI << endl;

    return 0;
}
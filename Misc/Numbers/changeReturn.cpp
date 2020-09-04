/* 
Change Return Program
The user enters a cost and then the amount of money given. 
The program will figure out the change and the number of quarters, dimes, nickels, pennies needed for the change.
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
    double cost = 0;
    double money = 0;

    cout << "Enter the cost : ";
    cin >> cost;
    cout << "Enter the amount of the money : ";
    cin >> money;

    double change = money - cost;

    int _1tl = 0;
    int _50krs = 0;
    int _25krs = 0;
    int _10krs = 0;
    int _5krs = 0;
    int _1krs = 0;

    _1tl = change / 1.0;
    _50krs = (change - _1tl * 1) / .5;
    _25krs = (change - (_1tl * 1 + _50krs * .5)) / .25;
    _10krs = (change - (_1tl * 1 + _50krs * .5 + _25krs * .25)) / .1;
    _5krs = (change - (_1tl * 1 + _50krs * .5 + _25krs * .25 + _10krs * .1)) / .05;
    _1krs = (change - (_1tl * 1 + _50krs * .5 + _25krs * .25 + _10krs * .1 + _5krs * .05)) / .01;

    cout << "1 TL = " << _1tl << endl;
    cout << "50 Krs = " << _50krs << endl;
    cout << "25 Krs = " << _25krs << endl;
    cout << "10 Krs = " << _10krs << endl;
    cout << "5 Krs = " << _5krs << endl;
    cout << "1 Krs = " << _1krs << endl;
}
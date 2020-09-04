/* 
Find e value to the Nth Digit  
Enter a number and have the program generate e up to that many decimal places. Keep a limit to how far the program will go.
*/

// Created by ugurinal

#include <iostream>
#include <stdlib.h>
#include <math.h>

using std::cin;
using std::cout;
using std::endl;

unsigned int factorial(int num);

int main()
{

    int n = 0;
    double e = 2.7182818284590452353602874713526624977572470936999595749669676277240766303535475945713821785251664274;

    cout << "Enter (n) the number to how many decimal to calculate. 0 <= n <= 30" << endl;

    do
    {
        cin >> n;
    } while (n > 30 || n < 0);

    n++;
    cout.precision(n);
    cout << e << endl;

    return 0;
}

/* 
Binary to Decimal and Back Converter
Develop a converter to convert a decimal number to binary or a binary number to its decimal equivalent.
*/

// Created by ugurinal

#include <iostream>
#include <stdlib.h>
#include <math.h>

using std::cin;
using std::cout;
using std::endl;
using std::stoi;

int main()
{
    int choice = 0;
    
    while (true)
    {
        cout << "1- Binary to decimal\n2- Decimal to binary\n3- To exit" << endl;

        cin >> choice;

        char *binary = new char[16];
        int decimal = 0;

        if (choice == 1)
        {
            cout << "Enter the binary number (16 bits at most) : ";
            for (int i = 0; i < 16; i++)
            {
                cin >> binary[i];
            }

            int j = 0;

            for (int i = 15; i >= 0; i--)
            {
                decimal += (binary[i] - 48) * pow(2, j); // 0-9 equals to 48-57 in ASCII
                j++;
            }

            cout << decimal << endl;
        }
        else if (choice == 2)
        {
            cout << "Enter the decimal number (n <= 65535): ";
            cin >> decimal;
            int temp = decimal;
            int i = 0;

            while (temp > 0)
            {
                binary[i] = (temp % 2) + 48; // 0-9 equals to 48-57 in ASCII
                temp /= 2;
                i++;
            }

            for (int i = 0; i < 16; i++)
            {
                cout << binary[i];
            }
            cout << endl;
        }
        else
        {
            break;
        }
    }
}
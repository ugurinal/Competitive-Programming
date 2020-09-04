/* 
Find Cost of Tile to Cover W x H Floor 
Calculate the total cost of tile it would take to cover a floor plan of width and height, using a cost entered by the user.
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
    int width = 0;
    int height = 0;
    double cost = 0;

    cout << "Enter widht and height respectively : ";
    cin >> width >> height;
    cout << "Enter cost of a tile : ";
    cin >> cost;

    double total = (width * height) * cost;

    cout << "Total cost for tiling " << width << "x" << height << " floor "
         << "is " << total << "$" << endl;

    return 0;
}
#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main()
{

    size_t size;

    cin >> size;
    int myArray[size];

    int x = 0;
    for (int i = 0; i < size; i++)
    {
        cin >> x;
        myArray[i] = x;
    }
    for (int i = size - 1; i >= 0; i--)
    {
        cout << myArray[i] << " ";
    }
    return 0;
}

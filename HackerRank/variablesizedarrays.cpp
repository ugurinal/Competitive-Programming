#include <iostream>

using namespace std;

int main()
{
    int size = 0;
    int queries = 0;
    int counter = 0;

    cin >> size >> queries;

    int **myArray = new int *[size];

    while (counter < size)
    {
        int arraySize = 0;
        cin >> arraySize;

        int *firstArray = new int[arraySize];
        int data = 0;

        for (int i = 0; i < arraySize; i++)
        {
            cin >> data;
            firstArray[i] = data;
        }

        myArray[counter] = firstArray;
        counter++;
    }

    for (int i = 0; i < queries; i++)
    {
        int j = 0, k = 0;

        cin >> j >> k;

        cout << myArray[j][k] << endl;
    }

    delete[] myArray;

    return 0;
}
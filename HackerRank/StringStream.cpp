#include <sstream>
#include <vector>
#include <iostream>
using namespace std;

vector<int> parseInts(string str) {
	vector<int> vec;

	stringstream ss(str);
	int num;
	char c;

	while (ss >> num) {
		vec.push_back(num);
		ss >> c;
	}

	/*while (ss >> num) {	Second solution
		vec.push_back(num);

		if (ss.peek() == ',') {
			ss.ignore();
		}
	}*/

	return vec;
}

int main() {
	string str;
	cin >> str;
	vector<int> integers = parseInts(str);
	for (int i = 0; i < integers.size(); i++) {
		cout << integers[i] << "\n";
	}

	return 0;
}
#include<iostream>

using namespace std;
using namespace Csharp;
int main() {

	int a, b;
	while (cin >> a >> b) {
		Calculate^ c = gcnew Calculate(a, b);

		cout << "a + b = " << c->add() << endl;
		cout << "a - b = " << c->sub() << endl;
		cout << "a * b = " << c->mul() << endl;

		if (b == 0) {

			cout << "can't divide zero, end process" << endl;
			break;
		}
		else {

			cout << "a / b = " << c->div() << endl;
		}
		cout << endl;

	}
	return 0;
}
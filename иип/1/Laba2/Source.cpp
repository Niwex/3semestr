#include "Many.h"
int main() {

	
	int array[10]{ 1,2,3,4,5,6,7,8,9,10 };
	int array1[10]{2,3,4,5,6,7,8,9,10,11 };
	int size = 10;
	Many a(array,size);
	Many b(array1, size);
	Many c;
	int n;

	while (1)
	{
		std::cout << "1-Difference \n 2-Intersection \n 3-Combination \n 4-Addelement \n 5-Print \n 6-Deletelement \n";
		std::cin >> n;
		if (n == 1) {
			c = b.Difference(a, b); c.Print();
		}
		if (n == 2) {
			c = b.Intersection(a, b); c.Print();
		}
		if (n == 3) {
			c = b.Ñombination(a, b); c.Print();
		}
		if (n == 4) {
			std::cin >> n;
			b.Addelement(n); b.Print();
		}
		if (n == 5) {
			b.Print();
		}
		if (n == 6) {
			std::cin >> n;
			b.Deletelement(n);
		}






	}







	system("pause");

	return 0;
}



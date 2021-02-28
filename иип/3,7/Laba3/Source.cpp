#include<iostream>
#include"Vector.h"
#include<list>
#include<string>
using namespace std;
int main()
{
	
	Vector<int> vec(10);
	Vector<double> vectr(10);
	Vector<float> vectasdasdr(10);
	vec.print();
	cout << endl;
	vec = vec + 100;
	vec.print();
		system("pause");
	
}



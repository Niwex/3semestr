#include<iostream>
#include "Shape.h"




int main()
{
	int ar[2][3];
	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			ar[i][j] = j;
		}
	}
	int arr[2][4];
	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			arr[i][j] = j-1;
		}
	}
	Triangle a(ar);
	Tetragon b(arr);


	a.print();
	a.move("Left", 10);
	a.print();
	if (a.isinclude(b)) std::cout << "true";
	else std::cout << "false";
	



	system("pause");
	return 0;
	
}
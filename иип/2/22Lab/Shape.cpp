#include "Shape.h"
#include <iostream>
#include<string>
void Shape::Print(int n) const
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < 2; j++)
		{
			std::cout << Point[j][i] << " ";
		}
		std::cout << std::endl;
	}
}



Shape::Shape()
{
	
}

Shape::~Shape()
{
	delete[] Point;
}










void Shape::Move(int n,int size, int key)
{
	switch (n)
	{
	case 1:  //left
		for (int i = 0; i < size; i++)
		{
			Point[0][i] -= key;
		}
		break;
	case 2:		//Right
		for (int i = 0; i < size; i++)
		{
			Point[0][i] += key;
		}
		break;
	case 3:			//Up
		for (int i = 0; i < size; i++)
		{
			Point[1][i] += key;
		}
		break;
	case 4:			//Down
		for (int i = 0; i < size; i++)
		{
			Point[1][i] -= key;
		}
		break;
	}
}



Tetragon::Tetragon(int array[2][4])
{
	
	Point = new int*[2];
	for (int i = 0; i < 2; i++)
	{
		Point[i] = new int[4];
	}
	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			Point[i][j] = array[i][j];
		}
	}

}

void Tetragon::print()
{
	Print(4);
}

void Tetragon::move(string Dir, int Number)
{
	int n = Number;
	if (Dir == "Left") Move(1, 4, n);
	if (Dir == "Right") Move(2, 4, n);
	if (Dir == "Up") Move(3, 4, n);
	if (Dir == "Down") Move(4, 4, n);
}

Tetragon::Tetragon(const Tetragon & other)
{
	this->Point = new int *[2];
	for (int i = 0; i < 2; i++)
	{
		this->Point[i] = new int[4];
	}
	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			this->Point[i][j] = other.Point[i][j];
		}
	}
	
}

int Tetragon::getpoint(int i, int j)
{
	if (i > 2) return 0;
	if (j > 4) return 0;
	return Point[i][j];
}

bool Tetragon::isinclude(Triangle a)
{
	int max_x = -999, max_y = -999;
	int min_x = 999, min_y = 999;
	for (int i = 0; i < 4; i++)
	{
		
	
		if (a.getpoint(0, i) > max_x) max_x = a.getpoint(0, i);
		if (a.getpoint(0, i) < min_x) min_x = a.getpoint(0, i);
		if (a.getpoint(1, i) > max_y) max_y = a.getpoint(1, i);
		if (a.getpoint(1, i) < min_y) min_y = a.getpoint(1, i);
	}
	for (int i = 0; i < 3; i++)
	{
		if (max_x < this->Point[0][i]) { return false; }
		if (max_x > this->Point[0][i]) { return false; }
		if (max_y < this->Point[1][i]) { return false; }
		if (max_y > this->Point[1][i]) { return false; }
	}
	return true;
	
}


















int Triangle::getpoint(int i, int j)
{
	
		if (i > 2) return 0;
		if (j > 4) return 0;
		return Point[i][j];
	


}

Triangle::Triangle(int array[2][3])
{
	
	Point = new int*[2];
	for (int i = 0; i < 2; i++)
	{
		Point[i] = new int[3];
	}
	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			Point[i][j] = array[i][j];
		}
	}
}

Triangle::Triangle(const Triangle & other)
{
	
		this->Point = new int *[2];
		for (int i = 0; i < 2; i++)
		{
			this->Point[i] = new int[3];
		}
		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				this->Point[i][j] = other.Point[i][j];
			}
		}

	}

void Triangle::print()
{
	Print(3);
}

void Triangle::move(string Dir, int Number)
{
	int n = Number;
	std::string key = Dir;
		if (key == "Left") Move(1, 3, n);
		if (key == "Right") Move(2, 3, n);
		if (key == "Up") Move(3, 3, n);
		if (key == "Down") Move(4, 3, n);

}

bool Triangle::isinclude(Tetragon a)
{
	int max_x = -999, max_y = -999;
	int min_x = 999, min_y = 999;
	for (int i = 0; i < 4; i++)
	{
	
		if (a.getpoint(0, i) > max_x) max_x = a.getpoint(0, i);
		if (a.getpoint(0, i) < min_x) min_x = a.getpoint(0, i);
		if (a.getpoint(1, i) > max_y) max_y = a.getpoint(1, i);
		if (a.getpoint(1, i) < min_y) min_y = a.getpoint(1, i);
	}
	for (int i = 0; i < 3; i++)
	{
		if (max_x < this->Point[0][i]) { return 0; }
		if (max_x > this->Point[0][i]) { return 0; }
		if (max_y < this->Point[1][i]) { return 0; }
		if (max_y > this->Point[1][i]) { return 0; }
	}
}






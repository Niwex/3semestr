#pragma once
#include<string>
using namespace std;
class Triangle;
class Tetragon;


class Shape
{
public:
	Shape();
	~Shape();
	
protected:
	
	void Move(int n, int size,int key);
	int**Point;
	void Print(int n)const;
};

class Tetragon :public Shape
{
	
public:
	int getpoint(int i, int j);
	Tetragon(int array[2][4]);
	void print();
	void move(string Dir,int Nubmer);
	Tetragon(const Tetragon & other);
	bool isinclude(Triangle a);
};

class Triangle :public Shape
{
	
public:
	int getpoint(int i, int j);
	Triangle(int array[2][3]);
	Triangle(const Triangle &other);
	void print();
	void move(string Dir, int Number);
	bool isinclude(Tetragon a);
	

};


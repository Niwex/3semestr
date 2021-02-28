#include "Many.h"

Many::Many()
{
	this->data = 0;
	this->size = 0;
}

Many::Many(const Many & other)
{
	this->size = other.size;
	this->data = new int[other.size];
	for (int i = 0; i < other.size; i++)
	{
		this->data[i] = other.data[i];
	}
}

Many::Many(int data)	
{
	this->data = new int[1];
	this->data[0] = data;
}

Many::Many(int *data, int size)
{
	this->size = size;
	this->data = new int[size];
	for (int i = 0; i < size; i++)
	{
		this->data[i] = data[i];
	}

}

Many::~Many()
{
	delete[] data;
}

void Many::Addelement(int data)
{
	this->data = (int*)realloc(this->data, (++size) * sizeof(int));
	this->data[size - 1] = data;
	size++;
	 this->data = (int*)realloc(this->data, size * sizeof(int));
	 size--;
	 this->data[size] = data;
	 size++;
}
void Many::Print()const 
{
	for (int i = 0; i < size; i++)
	{
		cout << data[i] << " ";
	}
	cout << endl;
}

void Many::Deletelement(int data)
{
	int dataI = -1;
	for (int i = 0; i < size; i++)
	{
		if (this->data[i] == data)
		{
			dataI = i;
			break;
		}
	}
	if (dataI == -1)cout << "Element not detected" << endl;
	else
	{
		for (int i = dataI; i < size; i++)
		{
			swap(this->data[i], this->data[i + 1]);
		}
	}
	size--;
	this->data = (int*)realloc(this->data, size * sizeof(int));

}

Many Many::Ñombination(Many data1, Many data2)
{
	Many temp;
	temp.size = data1.size + data2.size;
	temp.data = new int[temp.size];
	for (int i = 0; i < data1.size; i++)
	{
		temp.data[i] = data1.data[i];
	}
	for (int i = 0; i < data2.size; i++)
	{
		temp.data[data1.size + i] = data2.data[i];
	}
	return temp;
}

Many Many::Intersection(Many data1, Many data2)
{
	Many temp(1);
	int x = 0;
	temp.size = data1.size + data2.size;
	temp.data = new int[temp.size];
	for (int i = 0; i < data1.size; i++)
	{
		for (int j = 0; j < data2.size; j++)
		{
			if (data1.data[i] == data2.data[j])
			{
				temp.data[x] = data2.data[j];
				x++;
			}
		}
	}
	temp.size = x;
	temp.data = (int*)realloc(temp.data, x * sizeof(int));
	return temp;
}

Many Many::Difference(Many data1, Many data2)
{
	Many temp(1);
	bool TF = true;
	int x = 0;
	temp.size = data1.size + data2.size;
	temp.data = new int[temp.size];
	for (int i = 0; i < data1.size; i++)
	{
		for (int j = 0; j < data2.size; j++)
		{
			if (data1.data[i] == data2.data[j])
			{
				TF = false;
			}
		}
		if (TF) { temp.data[x] = data1.data[i]; x++; }
		else
		{
			TF = true;
		}
	}
	temp.size = x;
	temp.data = (int*)realloc(temp.data, x * sizeof(int));
	return temp;
}

Many & Many::operator=(const Many & other)
{
	if (this != &other) {
		this->size = other.size;
		if (this->data != nullptr)
		{
			delete[] this->data;
		}
		this->data = new int[other.size];
		for (int i = 0; i < other.size; i++)
		{
			this->data[i] = other.data[i];
		}
	}
	return *this;
}

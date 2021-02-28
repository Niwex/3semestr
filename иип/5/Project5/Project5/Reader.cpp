#include "Reader.h"
#include <iostream>

Reader::Reader(std::string name)
{
	file.open(name, std::ifstream::in);
	if (!file) std::cout << "error\n";
}

void Reader::read_from_file(std::ifstream file)
{
	if (file.is_open())
	{
		string temp;
		char c = 0;
		while (file.get(c))
		{
			if (c == '.')
			{
				temp.push_back(c);
				stack_text.push(temp);
				temp.clear();
			}
			else
			{
				temp.push_back(c);
			}
		}
	}
}

void Reader::read()
{
	char c = 0;
	string temp;
	while (file.get(c))
	{
		if (c == '.')
		{
			temp.push_back(c);
			stack_text.push(temp);
			temp.clear();
		}
		else
		{
			temp.push_back(c);
		}
	}


}

void Reader::changesource(string new_name)
{
	file.open(new_name, std::ifstream::in);
	if (!file) std::cout << "error\n";
}

void Reader::show()
{
	for (size_t i = stack_text.size(); i > 0; i--)
	{
		std::cout << stack_text.top();
		stack_text.pop();
	}
}
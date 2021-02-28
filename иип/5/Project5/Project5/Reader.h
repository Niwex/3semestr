#pragma once
#include <string>
#include <stack>
#include <fstream>

using std::string;

class Reader
{
private:
	std::stack<string> stack_text;
	std::ifstream file;
public:
	Reader(std::string name);
	Reader() = default;
	void read_from_file(std::ifstream file);
	void read();
	void changesource(string new_name);
	void show();
	~Reader() { file.close(); }
};

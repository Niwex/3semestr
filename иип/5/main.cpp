#include <iostream>
#include "Reader.h"

int main()
{
	Reader reader("text.txt");

	reader.read();
	reader.show();

	return 0;
}
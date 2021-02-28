#include "Year.h"
#include <iostream>
#include <string>

int main()
{
	setlocale(0, "");
	Year Date;
	
	try
	{
		Date.change_year(10);
		Date.change_era(1);
		Date.change_date(25, 1);

	}

	catch (const std::exception & ex)
	{
		std::cerr << ex.what();
		return 1;
	}
	
	Date.check();
	system("pause");
	return 0;
}
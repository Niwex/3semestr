#include <iostream>
#include "Exception.h"
#include <math.h>
#include "Year.h"

using namespace std;
		
	Year::Year(int new_year, int new_era)
	{
		if (new_year > 2000 || new_year < 0) throw Exception("Mistake year");
		else year = new_year;

		if (new_era > 2 || new_era < 0) throw  Exception("Mistake era");
		else era = new_era;
	}

	void Year::change_year(int new_year)
	{
		if (new_year > 2000 || new_year < 0) throw Exception("Mistake year");
		else year = new_year;
	}

	void Year::change_era(int new_era)
	{
		if (new_era > 2 || new_era < 0) throw  Exception("Mistake era");
		else era = new_era;
	}


	void Year::change_date(int new_year, int new_era)
	{
		if (new_year > 2000 || new_year < 0) throw Exception("Mistake year");
		else year = new_year;

		if (new_era > 2 || new_era < 0) throw  Exception("Mistake era");
		else era = new_era;
	}

	void Year::check() {
		if (year % 4 == 0) {
			cout << " Year " << year << " is visokosn" << endl;

		}
		else {
			cout << " Year  " << year <<  " era "<< era  << " is not visokosn" << endl;
		}
	}
	void Year::show() {
		cout << year << "year " << era << " era " << endl;
	}



#include <iostream>
#include <stdlib.h>
#include <cmath>
#include <vector>

/*using namespace std;

float fv(vector<float> xi) {
	return (xi[0] - 6) * (xi[0] - 6) + (xi[1] + 5) * (xi[1] + 5) + (xi[2] - 1) * (xi[2] - 1) + (xi[3] + 5) * (xi[3] + 5);
}

vector<float>  dfv(vector<float> xi) {
	float d = 0.001;
	vector<float> df(xi.size());
	vector<float> copy_xi(xi);
	for (int i = 0; i < xi.size(); i++)
	{
		copy_xi[i] = copy_xi[i] + d;
		df[i] = (fv(copy_xi) - fv(xi)) / d;
		copy_xi[i] = copy_xi[i] - d;
	}
	return df;
}

bool vec(vector<float> df, float eps) {
	float rem = 0;
	for (int i = 0; i < df.size(); i++)
	{
		rem = rem + df[i] * df[i];
	}

	if (sqrt(rem) > eps)
	{
		return true;
	}
	else
	{
		return false;
	}
}
*/
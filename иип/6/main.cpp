#include "SortNode.h"
#include <iostream>

int main()
{
	SortNode sort_node;
	int i = 5;
	int temp;
	while (i)
	{
		i--;
		std::cin >> temp;
		sort_node.push(temp);
	}

	sort_node.sort();
	sort_node.show();
	return 0;
}
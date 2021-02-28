#include "SortNode.h"
#include <iostream>



SortNode::SortNode()
{
}

SortNode::SortNode(queue<int> input)
{
	queue_train = input;
}

void SortNode::push(int input)
{
	queue_train.push(input);
}


void SortNode::sort()
{
	for (size_t i = queue_train.size(); i > 0; i--)
	{
		if (queue_train.front() == 0)
			queue_left.push(queue_train.front());
		else if (queue_train.front() == 1)
			queue_right.push(queue_train.front());

		queue_train.pop();
	}
}

void SortNode::show()
{
	queue<int> temp;
	temp = queue_left;
	std::cout << "First queue: ";
	for (size_t i = temp.size(); i > 0; i--)
	{
		std::cout << temp.front() << "-";
		temp.pop();
	}

	std::cout << std::endl;

	temp = queue_right;
	std::cout << "Second queue: ";
	for (size_t i = temp.size(); i > 0; i--)
	{
		std::cout << temp.front() << "-";
		temp.pop();
	}

	std::cout << std::endl;
}


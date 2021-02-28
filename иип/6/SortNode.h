#pragma once
#include <queue>
#include <vector>

using std::queue;

class SortNode
{
private:
	queue<int> queue_train;
	queue<int> queue_right;
	queue<int> queue_left;
public:
	SortNode() = default;
	SortNode(std::vector<int> input);
	SortNode(queue<int> input);
	void push(int input);
	void push(queue<int> input);
	void sort();
	void show();
	~SortNode() = default;
};


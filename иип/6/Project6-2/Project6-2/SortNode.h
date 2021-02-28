#pragma once
#include <queue>
#include <vector>

using std::queue;
class inerfaceNodd {

public:
	void virtual push(int input) = 0;
	void virtual show() = 0;
	void virtual sort() = 0;

};

class SortNode : public inerfaceNodd
{
private:
	queue<int> queue_train;
	queue<int> queue_right;
	queue<int> queue_left;
public:
	SortNode();
	SortNode(queue<int> input);
	void push(int input) override;
	void sort() override;
	

};

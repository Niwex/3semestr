#include<list>
#include<iostream>

template <typename T> class Vector
{
public:
	Vector();
	Vector(T x);
	void push_back(T x);
	void push_front(T x);
	void clear();
	int size(); 
	 bool operator ==(const Vector<T> &other);
	 bool operator !=(const Vector<T> &other);
	 bool operator >(const Vector<T> &other);
	 bool operator <(const Vector<T> &other);
	 Vector<T> operator + (T const  & val)
	 {
		 Vec.push_back(val);
		 return *this;
	}
	 

	void print() const;
private:
	std::list<T> Vec;
};

template<class T>
Vector<T>::Vector()
{


}



template<class T>
Vector<T>::Vector(T x)
{
	Vec.push_back(x);
}


template<class T>
void Vector<T>::push_back(T x)
{
	Vec.push_back(x);
}

template<class T>
void Vector<T>::push_front(T x)
{
	Vec.push_front(x);
	

}

template<class T>
void Vector<T>::clear()
{
	Vec.clear();

	
}

template<class T>
 int Vector<T>::size()
{
	return Vec.size();
}







template<class T>
 bool Vector<T>::operator==(const Vector<T> & other)
{
	 if (Vec.size() == other.Vec.size())
	 {
		 auto it1 = other.Vec.begin();
		 for (auto it = Vec.begin();  it != Vec.end(); ++it)
		 {
			 
			 if ((*it1) != (*it)) { return false; }
			 it1++;
			
		 }
		
	}
	else
	{
		return false;
	}
	 return true;
}

 template<class T>
 bool Vector<T>::operator!=(const Vector<T>& other)
 {
	 if (Vec.size() != other.Vec.size())
	 {
		 return true;

	 }
	 else
	 {
		 auto it1 = other.Vec.begin();
		 for (auto it = Vec.begin(); it != Vec.end(); ++it)
		 {

			 if ((*it1) == (*it)) { return false; }
			 it1++;
		 }
	 }
	 return true;
 }

 template<class T>
 bool Vector<T>::operator>(const Vector<T>& other)
 {
	 if (Vec.size() > other.Vec.size())
	 {
		 return true;

	 }
	 else
	 {
			 auto it1 = other.Vec.begin();
			 for (auto it = Vec.begin(); it != Vec.end(); ++it)
			 {

				 if ((*it1) > (*it)) { return false; }
				 it1++;
			 }
		
	 }
	 return true;
	
 }

 template<class T>
 bool Vector<T>::operator<(const Vector<T>& other)
 {
	 if (Vec.size() < other.Vec.size())
	 {
		 return true;

	 }
	 else
	 {
		 auto it1 = other.Vec.begin();
		 for (auto it = Vec.begin(); it != Vec.end(); ++it)
		 {

			 if ((*it1) < (*it)) { return false; }
			 it1++;

		 }

	 }
	 return true;
 }





 
















 




 







 


template<class T>
void Vector<T>::print() const
{
	for (auto it = Vec.begin(); it != Vec.end(); ++it)
	{
		std::cout << (*it) << " ";
	}
}


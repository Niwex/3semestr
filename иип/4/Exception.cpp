#include "Exception.h"

Exception::Exception(string error)
{
	s_error = std::move(error);
}

const char* Exception::what() const
{
	return s_error.c_str();
}
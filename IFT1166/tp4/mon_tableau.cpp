//Author François Corneau-Tremblay
#include "mon_tableau.hpp"

#include <iostream>

using std::cout;

template<typename T>
mon_tableau<T>::mon_tableau(int _upper_bound) : u_bound(_upper_bound), l_bound(0), count(_upper_bound)
{
	real_array = new T[count];
}

template<typename T>
mon_tableau<T>::mon_tableau(int _lower_bound, int _upper_bound) : u_bound(_upper_bound), l_bound(_lower_bound),
															count(_upper_bound - _lower_bound)
{
	real_array = new T[count];
}

template<typename T>
mon_tableau<T>::mon_tableau(const std::initializer_list<T>& init_list)
{
	//Create an array the size of the initializer_list
	real_array = new T[init_list.size()];
	
	count = init_list.size();
	u_bound = init_list.size();
	l_bound = 0;
	
	//Copy data from init list to real_array
	for(int i = 0; i < init_list.size(); ++i)
		real_array[i] = *(init_list.begin() + i);
}

//Make sure we clean up after ourselves
template<typename T>
mon_tableau<T>::~mon_tableau()
{
	delete real_array;
}

template<typename T>
T& mon_tableau<T>::operator[](int idx)
{
	//Transpose the signed index to the unsigned underlying model
	int real_index = idx + std::abs(l_bound);
	
	//If the index we get is still negative or we've reached the upperbound
	//we have an out_of_range scenario on our hands so throw a new exception
	if(real_index < 0 || real_index >= u_bound)
		throw std::out_of_range("Index is out of range : " + std::to_string(real_index));
	
	return real_array[real_index];
}

//According to overloading specs we need to define a const and non-const operator[]
template<typename T>
const T& mon_tableau<T>::operator[](int idx) const
{
	int real_index = idx + std::abs(l_bound);
	
	if(real_index < 0 || real_index >= u_bound)
		throw std::out_of_range("Index is out of range : " + std::to_string(real_index));
	
	return real_array[real_index];
}

template<typename T>
bool mon_tableau<T>::operator==(const mon_tableau<T>& rhs) const
{
	//If the bounds don't match the arrays are definitely not equal
	if(u_bound != rhs.u_bound && l_bound != rhs.l_bound)
		return false;
	
	for(int i = l_bound; i < u_bound; ++i)
		if(operator[](i) != rhs[i]) //If one value doesn't match, the arrays are not equal
			return false;
		
	return true;
}

//Define the not equal operator from the is equal one
template<typename T>
bool mon_tableau<T>::operator!=(const mon_tableau<T>& rhs) const
{
	return !(operator==(rhs));
}


int main(int argc, char** argv)
{
	mon_tableau<int> tab1(5);
	mon_tableau<int> tab2(-5, 7);
	mon_tableau<int> tab3(5);
	mon_tableau<int> tab4 { 1, 2, 3, 4 };
	
	for(int i = 0; i < 5; ++i)
	{
		tab1[i] = 0;
		tab3[i] = 0;
	}

	cout << std::boolalpha;
	
	cout << "Testing tab size\n";
	
	cout << tab1.size() << '\n';
	cout << tab2.size() << '\n';
	
	cout << "Testing tab accessor with positive and negative indexes\n";
	cout << tab1[3] << '\n';
	cout << tab2[-4] << '\n';
	
	cout << "Testing out_of_range exception\n";
	try {
		cout << tab1[-100];
	}
	catch(const std::out_of_range& e) {
		cout << e.what();
	}
	
	cout << "\nTesting is equal operator\n";
	cout << (tab1 == tab3) << '\n';
	
	cout << "Testing is different operator\n";
	cout << (tab1 != tab2) << '\n';
	
	cout << "Testing index-based for loop\n";
	for(int i = tab1.lower_bound(); i < tab1.upper_bound(); ++i)
		cout << tab1[i];

	cout << "\nTesting range-based for loop\n";
	for(auto i : tab4)
		cout << i;
	
	return 0;
}

/*	Compiled with : g++ mon_tableau.cpp -o mon_tableau

Output :
$ ./mon_tableau.exe
	Testing tab size
	5
	12
	Testing tab accessor with positive and negative indexes
	0
	0
	Testing out_of_range exception
	Index is out of range : -100
	Testing is equal operator
	true
	Testing is different operator
	true
	Testing index-based for loop
	00000
	Testing range-based for loop
	1234



*/
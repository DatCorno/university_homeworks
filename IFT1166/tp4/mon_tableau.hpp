//Author : François Corneau-Tremblay
#ifndef MONTABLEAU_HPP
#define MONTABLEAU_HPP

#include <cmath>
#include <initializer_list>


/*
	The question was a bit weird, since when passing one argument we define the upper bound
	But when passing the argument we define the lower bound first then we define the upper bound
	Ultimately it doesn't change anything, but if the two arguments were to switch place, this class
	Could have been easily implemented with no run-time overhead
*/
template<typename T>
class mon_tableau {
	public :
		mon_tableau(int);
		mon_tableau(int, int);
		//Intializer list constructor to mimic normal static arrays
		mon_tableau(const std::initializer_list<T>&);		
		~mon_tableau();
		
		//Iterator support according to c++ specification because, why not
		
		class iterator {
			public :
				iterator(T* _ptr) : ptr(_ptr){}
				
				//Iterator increment
				iterator operator++() 
				{ 
					++ptr;
					return *this;
				}
				
				bool operator!=(const iterator& other)
				{
					return ptr != other.ptr;
				}
				
				const T& operator*()
				{
					return *ptr;
				}
				
			private :
				T* ptr;
		};
		
		inline std::size_t size() const
		{
			return count;
		}
		
		inline int upper_bound() const
		{
			return u_bound;
		}
		
		inline int lower_bound() const
		{
			return l_bound;
		}
		
		//Const and non-const accessor according to c++ specification
		T& operator[](int idx);
		const T& operator[](int idx) const;
		
		bool operator==(const mon_tableau<T>&) const;
		bool operator!=(const mon_tableau<T>&) const;
		
		//Define a begin and end function which returns an iterator that can be iterated over
		//The iterator is really not necessary but I like using range-based for loops
		iterator begin()
		{
			return iterator(real_array);
		}
		
		iterator end()
		{
			return iterator(real_array + count);
		}
		
	private :
		int u_bound;
		int l_bound;
		
		std::size_t count;
		
		T* real_array;
};
#endif
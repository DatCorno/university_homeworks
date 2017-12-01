#ifndef RECTANGLE_HPP
#define RECTANGLE_HPP

#include <iostream>

class rectangle {
	public :
		constexpr rectangle(double, double);
	
		void setDimension(double, double);
	
		constexpr double getLong() const;
		constexpr double getLarg() const;
		constexpr double surface() const;
		constexpr double perimeter() const;
	
	/*
		friend rectangle operator+(const rectangle&);
		friend rectangle operator*(const rectangle&);
		friend bool operator==(const rectangle&);
		friend bool operator!=(const rectangle&);
		friend std::ostream& operator<<(std::ostream&);
		friend std::istream& operator>>(std::istream&);
		
		friend rectangle& operator++();
		friend rectangle operator++();
	*/
	private :
	
		double longueur;
		double largeur;
};
#endif 
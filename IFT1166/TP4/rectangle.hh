//François Corneau-Tremblay
#ifndef RECTANGLE_HPP
#define RECTANGLE_HPP

#include <iostream>

class rectangle {
	public :
		constexpr rectangle(double, double);
		constexpr rectangle();
	
		void setDimension(double, double);
	
		constexpr double getLong() const;
		constexpr double getLarg() const;
		constexpr double surface() const;
		constexpr double perimeter() const;
	
		rectangle& operator+=(const rectangle& rhs)
		{
			longueur += rhs.longueur;
			largeur += rhs.largeur;
			
			return *this;
		}

		rectangle operator*=(const rectangle& rhs)
		{
			longueur *= rhs.longueur;
			largeur *= rhs.largeur;

			return *this;
		}
	
		bool operator==(const rectangle& rhs)
		{
			return longueur == rhs.longueur && rhs.largeur == largeur;
		}
		
		bool operator!=(const rectangle& rhs)
		{
			return !(*this == rhs);
		}
		
		friend std::ostream& operator<<(std::ostream& out, const rectangle& rhs)
		{
			out << "Longueur : " << rhs.longueur << ", largeur : " << rhs.largeur << '\n';
			
			return out;
		}
		
		friend std::istream& operator>>(std::istream& in, rectangle& rhs)
		{
			in >> rhs.longueur >> rhs.largeur;
			return in;
		}
		
		rectangle& operator++()
		{
			longueur += 1.0;
			largeur += 1.0;
			
			return *this;
		}
		
		rectangle operator++(int)
		{
			rectangle tmp(*this);
			operator++();
			return tmp;
		}
	
	private :
	
		double longueur;
		double largeur;
};
#endif 
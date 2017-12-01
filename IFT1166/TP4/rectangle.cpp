#include "rectangle.hh"
#include <array>

constexpr rectangle::rectangle(double _lo, double _la) : longueur(_lo), largeur(_la)
{}

void rectangle::setDimension(double _lo, double _la)
{
	longueur = _lo;
	largeur = _la;
}

constexpr double rectangle::getLong() const
{
	return longueur;
}

constexpr double rectangle::getLarg() const
{
	return largeur;
}

constexpr double rectangle::surface() const
{
	return longueur * largeur;
}

constexpr double rectangle::perimeter() const
{
	return 2 * longueur + 2 * largeur;
}

int main(int argc, char** argv)
{
	constexpr rectangle rect(1, 4);
	
	constexpr static const int width = (int)rect.getLong();
	
	std::array<int, width> rect_array;
	
	std::cout << width;
}
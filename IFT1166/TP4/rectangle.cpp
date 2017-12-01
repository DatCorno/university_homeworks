//François Corneau-Tremblay
#include "rectangle.hh"

using std::cout;
using std::cin;

constexpr rectangle::rectangle(double _lo, double _la) : longueur(_lo), largeur(_la)
{}

constexpr rectangle::rectangle() : longueur(0.0), largeur(0.0)
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

const rectangle operator+(const rectangle& lhs, const rectangle& rhs)
{
	rectangle result(lhs);
	result += rhs;
	
	return result;
}

const rectangle operator*(const rectangle& lhs, const rectangle& rhs)
{
	rectangle result(lhs);
	result *= rhs;
	
	return result;
}

int main(int argc, char** argv)
{
	rectangle rect1(1, 1);
	rectangle rect2(2, 2);
	rectangle rect3(2, 2);
	rectangle rect4(4, 4);
	rectangle rect5;
	rectangle rect6;
	rectangle rect7;
	rectangle rect8(12, 12);
	
	//Output "true" instead of 1 and "false" instead of 0
	cout << std::boolalpha;
	
	//Test operator+ on rect7;
	cout << "operator +\n";
	cout << rect1 << rect2;
	rect7 = rect1 + rect2;
	cout << "result : " << rect7 << "\n"; 
	
	//Test operator* on rect7
	cout << "operator *\n";
	cout << rect1 << rect2;
	rect7 = rect1 * rect2;
	cout << "result : " << rect7 << "\n";
	
	//Test operator ==
	cout << "operator ==\n";
	cout << rect2 << rect3;
	cout << "result : " << (rect2 == rect3) << "\n\n";
	
	//Test operator !=
	cout << "operator !=\n";
	cout << rect1 << rect3;
	cout << "result : " << (rect1 != rect3) << "\n\n";
	
	//Test operator >>
	cout << "operator >>\n";
	cout << rect4;
	cout << "Entrez la longueur puis la largeur\n";
	cin >> rect4;
	cout << "result : " << rect4 << '\n';
	
	//Test & operator++
	cout << "prefix ++\n";
	cout << rect5;
	cout << "result : " << ++rect5 << "\n\n";
	
	//Test operator++
	cout << "postfix ++\n";
	cout << rect6;
	cout << "result postfix : " << rect6++;
	cout << "result after postfix : " << rect6 << "\n\n";
	
	//Test functions
	cout << rect8;
	cout << "Longueur : " << rect8.getLong() << '\n';
	cout << "Largeur : " << rect8.getLarg() << '\n';
	cout << "Surface : " << rect8.surface() << '\n';
	cout << "Périmètre : " << rect8.perimeter() << '\n';
	rect8.setDimension(20, 20);
	cout << "setDimension() \n";
	cout << rect8;

	return 0;
}

/* 	Compilaton passed with "g++ rectangle.cpp -o rect"
	Program output :
	
	$ ./rect.exe
	operator +
	Longueur : 1, largeur : 1
	Longueur : 2, largeur : 2
	result : Longueur : 3, largeur : 3

	operator *
	Longueur : 1, largeur : 1
	Longueur : 2, largeur : 2
	result : Longueur : 2, largeur : 2

	operator ==
	Longueur : 2, largeur : 2
	Longueur : 2, largeur : 2
	result : true

	operator !=
	Longueur : 1, largeur : 1
	Longueur : 2, largeur : 2
	result : true

	operator >>
	Longueur : 4, largeur : 4
	Entrez la longueur puis la largeur
	12
	122.0
	result : Longueur : 12, largeur : 122

	prefix ++
	Longueur : 0, largeur : 0
	result : Longueur : 1, largeur : 1


	postfix ++
	Longueur : 0, largeur : 0
	result postfix : Longueur : 0, largeur : 0
	result after postfix : Longueur : 1, largeur : 1


	Longueur : 12, largeur : 12
	Longueur : 12
	Largeur : 12
	Surface : 144
	Périmètre : 48
	setDimension()
	Longueur : 20, largeur : 20
*/
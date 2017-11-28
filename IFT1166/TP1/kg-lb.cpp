//Auteur : François Corneau-Tremblay

#include <iomanip>
#include <iostream>

using std::cout;
using std::cin;
using std::endl;
using std::setprecision;


int main(int argc, char** argv)
{
	float weight_kilogram = 0.0f;
	float weight_lbs = 0.0f;
	
	cout << "Veuillez entrez votre poids en kilogrammes : " << endl;
	cin >> weight_kilogram;
	
	weight_lbs = weight_kilogram * 2.2;
	
	cout << std::fixed;
	cout << setprecision(2);
	cout << "Votre poids de " << weight_kilogram << " kg vaut " << weight_lbs << " lbs." << endl;
	
	return 0;
}

//Résultat d'exécution
/*
Veuillez entrez votre poids en kilogrammes : 
202.30
Votre poids de 202.30 kg vaut 445.06 lbs.

*/
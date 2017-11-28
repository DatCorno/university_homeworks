// Exemple d’un programme qui lit des éléments d’un menu et leurs prix
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main() {
	string element1;
	double prix1;
	string element2;
	double prix2;
	char ch;
	ifstream inFile;
	inFile.open("prixALire.txt");
	if (!inFile) {
		cout << "Impossible d’ouvrir le fichier. Fin du programme!" << endl;
		return 1;
	}

	getline(inFile, element1);
	inFile >> prix1;
	inFile.get(ch);
	cout << element1 << ": " << prix1 << ch;
	getline(inFile, element2);
	inFile >> prix2;
	inFile.get(ch);
	cout << element2 << ": " << prix2 << ch;
	return 0;
}

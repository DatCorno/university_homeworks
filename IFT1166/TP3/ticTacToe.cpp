//Auteur : François Corneau-Tremblay
#include "ticTacToe.h"

using std::cout;

int main(int argc, char** argv)
{
	ticTacToe jeu;
	
	jeu.jouer();

	return 0;
}

/* Compilation - g++ ticTacToe.cpp -o ticTacToe 
	Compile passed
	
	Output samples :
		$ ./ticTacToe.exe
		Au tour du joueur X
		 x : 1
		 y : 1


		 X

		Au tour du joueur O
		 x : 0
		 y : 0

		O
		 X

		Au tour du joueur X
		 x : 0
		 y : 1

		O
		XX

		Au tour du joueur O
		 x : 1
		 y : 0

		OO
		XX

		Au tour du joueur X
		 x : 1
		 y : 2

		OO
		XX
		 X
		Au tour du joueur O
		 x : 3
		 y : 0

		Mouvement invalide
		Au tour du joueur O
		 x : 2
		 y : 0

		OOO
		XX
		 X
		Le joueur O a gagné
		Voulez-vous recommencer? (oui|non)
		oui
		Au tour du joueur X
		 x : 0
		 y : 0

		X


		Au tour du joueur O
		 x :

*/
//Auteur : François Corneau-Tremblay

#ifndef TICTACTOE_HPP
#define TICTACTOE_HPP

#include <vector>
#include <array>
#include <iostream>
#include <algorithm>

//Enum pour déterminer l'état de la partie
enum etat {
	VICTOIRE,
	NULLE,
	CONTINUER
};

class ticTacToe {
	public :
		ticTacToe();
		
		void jouer();
		
	private :
		void affichTab() const;
		bool mouvValid(int, int) const;
		bool getXOMouv(char);
		
		etat etatJeux();
		
		void recommence();
		
		bool has_winning_position(char);
		
		inline void construct_winning_positions();
		
		inline bool is_tab_full();
		
		char tabJeu[3][3];
		
		//Vector contenant les différentes dispositions permettant à un joueur de gagner
		std::vector<std::array<int[2], 3>> winning_positions;
};

ticTacToe::ticTacToe()
{
	//Initialise le tableau avec des espaces
	for(int i = 0; i < 3; ++i)
		for(int j = 0; j < 3; ++j)
			tabJeu[i][j] = ' ';
		
	//Crée le vector de positions gagnantes
	construct_winning_positions();
}

inline void ticTacToe::construct_winning_positions()
{
	/*
		0,0; 0,1; 0,2;
		1,0; 1,1; 1,2;
		2,0; 2,1; 2,2;
	*/
	//Les positions gagnantes diagonales
	winning_positions.emplace(winning_positions.cend(), std::array<int[2], 3>{ { {0, 0}, {1, 1}, {2, 2} } } 	);
	winning_positions.emplace(winning_positions.cend(), std::array<int[2], 3>{ { {0, 2}, {1, 1}, {2, 0} } } );
	
	//Les positions gagnantes verticales
	winning_positions.emplace(winning_positions.cend(), std::array<int[2], 3>{ { {0, 0}, {0, 1}, {0, 2} } } );
	winning_positions.emplace(winning_positions.cend(), std::array<int[2], 3>{ { {1, 0}, {1, 1}, {1, 2} } } );
	winning_positions.emplace(winning_positions.cend(), std::array<int[2], 3>{ { {2, 0}, {2, 1}, {2, 2} } } );
	
	//Les positions gagnantes horizontales
	winning_positions.emplace(winning_positions.cend(), std::array<int[2], 3>{ { {0, 0}, {1, 0}, {2, 0} } } );
	winning_positions.emplace(winning_positions.cend(), std::array<int[2], 3>{ { {0, 1}, {1, 1}, {2, 1} } } );
	winning_positions.emplace(winning_positions.cend(), std::array<int[2], 3>{ { {2, 0}, {2, 1}, {2, 2} } } );	
}

void ticTacToe::jouer()
{
	char active_player = 'X'; //Joueur ayant la main présentement
	etat current_state = etat::CONTINUER; //État actuel du jeu
	
	while(current_state == etat::CONTINUER)
	{	
		//Tant que l'on n'obtient pas un mouvement valide il faut demander l'avis de l'usager
		while(!getXOMouv(active_player))
			std::cout << "Mouvement invalide \n";
		
		//On affiche le tableau après le mouvement
		affichTab();
		
		//On recalcule l'état du jeu
		current_state = etatJeux();
		
		//Si l'état n'est pas à CONTINUER alors il y a une victoire ou une partie nulle
		if(current_state != etat::CONTINUER)
		{
			//S'il y a une victoire, affiché le gagnant
			if(current_state == etat::VICTOIRE)
				std::cout << "Le joueur " << active_player << " a gagné \n";
			else //Sinon avertir d'une partie nulle
				std::cout << "Partie nulle \n";
			
			std::cout << "Voulez-vous recommencer? (oui|non) \n";
			
			//Récupérer la réponse de l'usager
			std::string answer;
			std::cin >> answer;
			
			if(answer == "oui")
			{
				//Vider le tableau et changer l'état du jeu à CONTINUER pour rester dans la boucle
				//Évite de caller "jouer()" à nouveau, ce qui mènerait à un stack overflow après de nombreuses parties
				recommence();
				current_state = etat::CONTINUER;
			}
		}

		//Change le joueur ayant la main selon celui qui vient de jouer
		active_player = active_player == 'X' ? 'O' : 'X';		
	}
}

//Affiche le tableau de jeu. Cette section pourrait l'afficher de façon plus décente
void ticTacToe::affichTab() const
{
	for(int i = 0; i < 3; ++i)
	{
		for(int j = 0; j < 3; ++j)
			std::cout << tabJeu[i][j];
		
		std::cout << '\n';
	}
}

etat ticTacToe::etatJeux() 
{
	//Si l'un des deux joueurs possède une combinaisons gagnantes il suffit de retourner VICTOIRE
	if(has_winning_position('X') || has_winning_position('O'))
		return etat::VICTOIRE;
	else if(is_tab_full()) //Par contre, si aucun joueur n'a gagné et que le tableau est plein, il y a partie nulle
		return etat::NULLE;
	
	return etat::CONTINUER;
}

bool ticTacToe::has_winning_position(char player)
{
	//On boucle à travers le vecteur de positions gagnantes
	for(auto& position : winning_positions)
		//L'array contient trois positions. Si ces trois positions dans tabJeu possède le même caractère que celui du joueur
		//Alors celui-ci a gagné
		if(std::all_of(position.cbegin(), position.cend(), [this, player](auto pos){ return tabJeu[pos[0]][pos[1]] == player; }))
			return true;
	
	return false;
}

//Retourne vrai si une des positions du tableau possède un espace vide
bool ticTacToe::is_tab_full()
{
	for(int i = 0; i < 3; ++i)
		for(int j = 0; j < 3; ++j)
			if(tabJeu[i][j] == ' ')
				return false;
			
	return true;
}

//Vérifie en premier lieu que les valeurs données respectent les bornes de tabJeu 
//Puis vérifie que la position n'est pas déjà occupée
bool ticTacToe::mouvValid(int x, int y) const
{
	if(x > 2 || x < 0 || y > 2 || y < 0)
		return false;
	
	return tabJeu[x][y] == ' ';
}

//Récupère la valeur en x et en y du prochain coup
bool ticTacToe::getXOMouv(char player)
{
	int x, y;
	std::cout << "Au tour du joueur " << player << "\n x : ";
	std::cin >> x;
	std::cout << " y : ";
	std::cin >> y;
	std::cout << '\n';
	
	//Les index sont inversées dans le cas d'un array à deux dimensions alors il faut donner l'index de 'Y' en premier/
	//Puis l'index en 'X' ensuite
	if(mouvValid(y, x))
	{
		tabJeu[y][x] = player;
		return true;
	}
	else 
		return false;
}

//Vide tabJeu
void ticTacToe::recommence()
{
	for(int i = 0; i < 3; ++i)
		for(int j = 0; j < 3; ++j)
			tabJeu[i][j] = ' ';
}
#endif 










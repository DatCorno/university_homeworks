package com.udem.corneau.tp2;
/*
 	Les positions sur la grille sont index�es de la fa�on suivante :

	0	1	2
	3	4	5
	6	7	8
 */

public interface TicTacToe {

   /* pour initialiser un jeu de tic tac toe */
   public void initialise();

   /* pour recevoir l'index de la cellule choisie par X */
   public void setX( int cellule);

   /* Pour transmettre l'index de la position du O jou� */
   public int getO();

   /* vrai ou faux, le joueur pass� en param�tre ("X" ou "O")
    * a gagn�?  Si vrai, les index des 3 cellules de la combinaison
    * gagnante sont dans le tableau pos.
    *
    *  Il y a 8 combinaisons gagnantes :
     * (0, 1, 2), ( 0, 4, 8) et (0, 3, 6)
     * (6, 7, 8) et (6, 4, 2)
     * (3, 4, 5)
     * (1, 4, 7)
     * (2, 5, 8)
    *
    */
   public boolean gagnant(String joueur, int[] pos );

   /*Toutes les cellules sont occup�es et il n'y a aucun gagnant */
   public boolean isPartieNulle();

   public void testDebug(int[] indicesCoups);

   public void updatePositionForPlayer(int i, char c);
}
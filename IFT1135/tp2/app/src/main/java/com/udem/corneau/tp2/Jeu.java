package com.udem.corneau.tp2;

//François Corneau-Tremblay
//Remis le 11 octobre 2017
import java.util.*;
import java.util.function.Function;

public class Jeu implements TicTacToe {


    //Classe privée qui représente le résultat d'un appel à un prédicat. Cette classe stocke le succès du prédicat
    //ainsi que la position trouvé pour le coup (-1 dans le cas où le prédicat échoue)
    private class PredicateResult {
        public int position;
        public boolean success;

        public PredicateResult(int pos, boolean result) {
            position = pos;
            success = result;
        }
    }

    //Classe privée qui représente les paramètres d'entrée d'un prédicat, soit la combinaison présentement évaluée, le caractère dont on cherche
    //à trouver la position et la fonction pour évaluer le prédicat
    private class PredicateInput {
        public int[] combinaison;
        public char input_to_check;
        Function<int[], Boolean> threshold_function;

        public PredicateInput(char _input_to_check, Function<int[], Boolean> func) {
            input_to_check = _input_to_check;
            threshold_function = func;
        }
    }

    Random rand;

    //Est-ce que Java possède un équivalent de constexpr ???
    //Nombre de coups de O pour déterminer le prochain
    private int ai_turn;
    //Représente l'état du jeu
    private char[] grid;
    //List de tableau contenant les indices de la grid offrant une possibilité de victoire
    private List<int[]> winning_combinations;
    //Combinaisons diagonales
    private List<int[]> diagonal_combinations;
    //Combinaisons contre coin x-côté x
    private List<int[]> sides_x_to_corner_o_combinations;
    //Combinaisons cote x-cote x
    private List<int[]> sides_x_to_side_o_combinations;
    //Indexes des coins
    private int[] corners_indexes;
    //Indexes des côtés
    private int[] sides_indexes;
    //Indexes de toutes les cases
    private int[] all_indexes;

    //Predicate objects
    //Chacun des prédicats permet d'évaluer une situation du jeu, en étant utiliser pour analyser une combinaison de la grille de jeu, sans prendre en compte l'ordre
    //de la combinaison.

    //Ce prédicat sert à évaluer que la combinaison courant ne contient aucun 'X' et au moins un 'O'
    private PredicateInput noXAndAtLeastOneO;
    //Ce prédicat sert à évaluer que la combinaison contient exactement deux 'X' et aucun 'O'
    private PredicateInput twoXAndEmptySpace;
    //Ce prédicat sert à évaluer que la combinaison contient exactement deux 'X' et un seul 'O'
    private PredicateInput twoXAndOneO;
    //Ce prédicat sert à évaluer que la combinaison contient exactement deux 'O' et aucun 'X'
    private PredicateInput twoOAndEmptySpace;

    public Jeu() {
        rand = new Random();
        grid = new char[9];

        noXAndAtLeastOneO = new PredicateInput(' ', combinaison -> thresholdInCombinaison(combinaison, 'X', (count -> count == 0)) &&
                thresholdInCombinaison(combinaison, 'O', (count -> count > 0)));

        twoXAndEmptySpace = new PredicateInput(' ', combinaison -> thresholdInCombinaison(combinaison, 'X', (count -> count == 2)) &&
                thresholdInCombinaison(combinaison, ' ', (count -> count > 0)));

        twoXAndOneO = new PredicateInput('O', combinaison -> thresholdInCombinaison(combinaison, 'X', (count -> count == 2)) &&
                thresholdInCombinaison(combinaison, 'O', (count -> count == 1)));

        twoOAndEmptySpace = new PredicateInput(' ', combinaison -> thresholdInCombinaison(combinaison, 'O', (count -> count == 2)) &&
                thresholdInCombinaison(combinaison, ' ', (count -> count == 1)));


        all_indexes = new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8};

        corners_indexes = new int[]{0, 2, 6, 8};
        sides_indexes = new int[]{1, 3, 5, 7};


        winning_combinations = Arrays.asList(new int[]{0, 1, 2}, new int[]{0, 4, 8}, new int[]{0, 3, 6},
                                            new int[]{6, 7, 8},  new int[]{6, 4, 2},  new int[]{3, 4, 5},
                                            new int[]{1, 4, 7},  new int[]{2, 5, 8});

        diagonal_combinations = Arrays.asList(new int[]{0, 4, 8}, new int[]{6, 4, 2});

        //Ces deux listes sont utiliser pour évaluer le cas #3 et #4 du deuxième coup. Il est possible de calculer la position exact pour placer
        //le 'O' puisqu'il se trouve toujours à l'intersection de la ligne et de la colonne contenant les 'X'. Par contre, la mécanique est déjà
        //présente pour supporter les listes, alors il est judicieux de les contenir comme ceci
        sides_x_to_corner_o_combinations = Arrays.asList(
            new int[]{0, 5, 2},
            new int[]{2, 3, 0},
            new int[]{2, 7, 8},
            new int[]{6, 5, 8},
            new int[]{6, 1, 0},
            new int[]{8, 1, 2},
            new int[]{8, 3, 6}
        );

        sides_x_to_side_o_combinations = Arrays.asList(
                new int[]{1, 3, 0},
                new int[]{1, 5, 2},
                new int[]{3, 7, 6},
                new int[]{5, 7, 8}
        );
    }

    @Override
    public void initialise() {
        ai_turn = 0;

        for(int i = 0; i < 9; i++)
            grid[i] = ' ';
    }

    public void updatePositionForPlayer(int position, char player) {
        grid[position] = player;
    }

    @Override
    public void setX(int cellule) {
        grid[cellule] = 'X';
    }

    @Override
    public int getO() {
        //Incrémente le compteur de tour de l'adversaire pour calculer le coup à faire
        ai_turn++;

        //Position finale que le 'O' prendra
        int position = 0;

        if(ai_turn == 1)
        {
            //Si le centre n'est pas occupé
            if(grid[4] == ' ')
                position = 4;
            else //Sinon, trouver un coin inoccupé
                position = nextValidCorner();
        }

        else if(ai_turn == 2) {
            //Si le joueur est en position de gagner, il faut le bloquer
             position = iteratorOverArray(winning_combinations, twoXAndEmptySpace);

            if(position == -1) {
                //Si le joueur n'est pas en position de gagner, cas #2
                if (iteratorOverArray(diagonal_combinations, twoXAndOneO) != -1) {
                    if (grid[4] == 'O')
                        position = nextValidSide();
                    else
                        position = nextValidCorner();
                } else if (grid[4] == 'O') {
                    //Si le joueur est en position pour le cas #3 ou le cas #4, trouver la position entre les deux 'X'
                    position = iteratorOverArray(sides_x_to_corner_o_combinations, twoXAndEmptySpace);

                    if (position == -1)
                        position = iteratorOverArray(sides_x_to_side_o_combinations, twoXAndEmptySpace);
                }
            }
        } //Le cas du coup #3 et #4 sont le même
        else {
            //Essayer de ganger
            position = iteratorOverArray(winning_combinations, twoOAndEmptySpace);

            if(position == -1) //Bloquer l'adversaire le cas échéant
                position = iteratorOverArray(winning_combinations, twoXAndEmptySpace);
            if(position == -1) //Sinon, tenter une victoire
                position = iteratorOverArray(winning_combinations, noXAndAtLeastOneO);
            if(position == -1) //Et finalement. y aller au hsard
                position = nextValidPosition(all_indexes);
        }

        grid[position] = 'O';

        return position;
    }

    //Cette fonction parcourt la liste passée en paramètre et évalue chacune des combinaisons en fonction du predicat passé
    //Si le résultat est un success, elle le retourne pour accéder à sa position
    private int iteratorOverArray(List<int[]> array_to_iterate, PredicateInput predicate) {

        for(Iterator<int[]> it = array_to_iterate.iterator(); it.hasNext();){
            int[] combinaison = it.next();

            predicate.combinaison = combinaison;
            PredicateResult result = executePredicateFromInput(predicate);

            if(result.success)
                return result.position;
        }

        return -1;
    }

    //Cette fonction permet d'évaluer le prédicat passé, puis de trouver la position recherchée dans la grille à partir de la combinaison
    //dans le cas où la condition du prédicat est évaluée à vrai
    private PredicateResult executePredicateFromInput(PredicateInput input) {
        String combinaison_string = new String() + grid[input.combinaison[0]] + grid[input.combinaison[1]] + grid[input.combinaison[2]];

        if(input.threshold_function.apply(input.combinaison)) {
            int index_derniere_valeur = combinaison_string.indexOf(input.input_to_check);

            if(index_derniere_valeur > -1)
                return new PredicateResult(input.combinaison[index_derniere_valeur], true);
        }

        return new PredicateResult(-1, false);
    }

    //Cette fonction permet d'évaluer la présence de certains caractères dans la combinaison
    private boolean thresholdInCombinaison(int[] combinaison, char player_char, Function<Integer, Boolean> threshold){
        String combinaison_string = new String() + grid[combinaison[0]] + grid[combinaison[1]] + grid[combinaison[2]];
        return threshold.apply((int)(combinaison_string.chars().filter(player -> player == player_char).count()));
    }

    //Boucle tant que la position tirée au hasard est occupée
    private int nextValidPosition(int[] possible_positions) {
        int possible_index;

        do
            possible_index = possible_positions[rand.nextInt(possible_positions.length / 2)];
        while(grid[possible_index] != ' ');

        return possible_index;
    }

    //Retourne un coin inoccupé au hasard
    private int nextValidSide(){
        return nextValidPosition(sides_indexes);
    }

    //Retourne un côté inoccupé au hasard
    private int nextValidCorner(){
        return nextValidPosition(corners_indexes);
    }

    @Override
    public boolean gagnant(String joueur, int[] pos) {
        boolean partie_gagnante = false;
        char joueur_lettre = joueur.charAt(0);
        int[] combinaison = new int[3];

        for(Iterator<int[]> it = winning_combinations.iterator(); it.hasNext();) {
            combinaison = it.next();

            //Vérifie que chaque lettre à l'emplacement de la combinaison est la même
            partie_gagnante = grid[combinaison[0]] == joueur_lettre && grid[combinaison[1]] == joueur_lettre && grid[combinaison[2]] == joueur_lettre;

            //Si la combinaison est gagnante, inutile de continuer à boucler
            if(partie_gagnante)
                break;
        }

        //Puisqu'une assignation change le pointeur d'adresse de l'objet, il faut attribuer la valeur de chaque position une à la fois
        //pour changer les données sous-jacentes du tableau envoyé en pareille au lieu de le copîer à partir de la combinaison locale
        //Ensuite, pos n'est pas toujours requis
        if(pos != null) {
            pos[0] = combinaison[0];
            pos[1] = combinaison[1];
            pos[2] = combinaison[2];
        }
        return partie_gagnante;
    }

    @Override
    public boolean isPartieNulle() {
        //Si la grid ne contient aucun caractère d'espacement c'est qu'elle a été remplie complètement
        //De plus, si il n'y a aucun gagnant c'est que nous avons une partie nulle devant nous
        return (!(new String(grid).contains(" "))) && !(gagnant("X", null) || gagnant("O", null));
    }

    @Override
    public void testDebug(int[] indicesCoups) {

    }
}

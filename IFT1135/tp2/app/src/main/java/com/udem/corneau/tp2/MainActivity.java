package com.udem.corneau.tp2;

import android.content.res.ColorStateList;
import android.content.res.Configuration;
import android.graphics.Color;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

	private TicTacToe jeu;

	private boolean fini;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Initialisation d'un nouveau jeu
        jeu = new Jeu();

        //Si une partie est déjà sauvegardée, il faut la restorer
        if(savedInstanceState != null) {
        	//On récupère la valeur de chaque bouton
        	String[] button_states = savedInstanceState.getStringArray("buttons_state");

        	for(int i = 0; i < 9; ++i) {
        		//On attribue l'ancienne valeur des boutons à leur nouvelle instance
        		Button button = findViewById(getResources().getIdentifier("play_button"+ i, "id", getPackageName()));
        		button.setText(button_states[i]);

        		//Si le texte de ce bouton n'est pas null, il faut remettre à jour le jeu pour qu'il se rappelle que cette case a été choisie
        		if(button_states[i] != null)
	       			jeu.updatePositionForPlayer(i, button_states[i].charAt(0));
			}

			//Il faut réassigner les cases gagnantes s'il y en a
			markWinners();
		}
		else {
        	//On initialise le jeu
        	resetGame();
		}
    }

	@Override
	protected void onSaveInstanceState(Bundle outState) {
		super.onSaveInstanceState(outState);

		//On sauvegarde la valeur de chaque bouton dans le bundle
		String[] buttons_text = new String[9];

		for(int i = 0; i < 9; ++i) {
			Button play_button = findViewById(getResources().getIdentifier("play_button" + i, "id", getPackageName()));
			buttons_text[i] = play_button.getText().toString();

			if(buttons_text[i].isEmpty())
				buttons_text[i] = " ";
		}

		outState.putStringArray("buttons_state", buttons_text);
	}

	private void resetButtonsColorAndText(){
    	//On remet à zéro la valeur de chaque bouton et leur couleur
    	for(int i = 0; i < 9; ++i) {
    		Button play_button = findViewById(getResources().getIdentifier("play_button" + i, "id", getPackageName()));
    		play_button.setText(" ");
    		play_button.setTextColor(Color.parseColor("#000000"));
		}
	}

    public void playButtonClicked(View view){
		Button play_button = (Button)view;

		//Si le bouton n'est pas vide, ou que la partie est finie, il ne faut pas continuer
		if(!play_button.getText().equals(" ") || fini)
			return;

		//Le nom de l'id du bouton nous donne sa position
		String button_name = getResources().getResourceName(play_button.getId());
		int position = Character.getNumericValue(button_name.charAt(button_name.length() - 1));

		//On indique au jeu la position de la case cliquée
		jeu.setX(position);
		play_button.setText("X");

		//Si X a gagné, on indique les cases gagnantes
		if(jeu.gagnant("X", null)){
			markWinners();
		}
		else {
			//S'il n'y a pas de partie nulle, on trouve la position du prochain O
			if(!jeu.isPartieNulle()) {
				int next_positon = jeu.getO();
				Button o_button = findViewById(getResources().getIdentifier("play_button" + next_positon, "id", getPackageName()));
				o_button.setText("O");

				if(jeu.gagnant("O", null))
					markWinners();
			}
			else //Partie nulle, changer le message
				markWinners();
		}
	}

	//Met a jour la couleur des cases gagnantes et change le texte en fonction du gagnant
	private void markWinners() {
		int[] winner_positions = new int[3];

		fini = true;
		TextView winner=  findViewById(R.id.winner_textview);

		if(jeu.gagnant("X", winner_positions))
			winner.setText("X " + getString(R.string.winner_text));

		else if(jeu.gagnant("O", winner_positions))
			winner.setText("O " + getString(R.string.winner_text));
		else if(jeu.isPartieNulle()){
			winner.setText(getString(R.string.tie_game));
			return;
		}
		else
			return;

		markWinnerButtons(winner_positions);
	}

	private void markWinnerButtons(int[] winner_positions) {
    	for(int i = 0; i < winner_positions.length; ++i) {
    		Button play_button = findViewById(getResources().getIdentifier("play_button" + winner_positions[i], "id", getPackageName()));
    		play_button.setTextColor(Color.parseColor("#ff0000"));
		}
	}

	public void newGameClicked(View view){
		resetGame();
	}

	private void resetGame() {
		fini = false;
		jeu.initialise();

		resetButtonsColorAndText();
		((TextView)findViewById(R.id.winner_textview)).setText("");
	}

}

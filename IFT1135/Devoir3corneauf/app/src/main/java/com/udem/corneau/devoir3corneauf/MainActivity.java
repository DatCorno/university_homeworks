package com.udem.corneau.devoir3corneauf;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

	SharedPreferences sharedPreferences;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);

		createSharedPreferences();
	}

	private void createSharedPreferences() {
		//Save the password inside the shared preferences
		sharedPreferences = getSharedPreferences("Settings", Context.MODE_PRIVATE);
		SharedPreferences.Editor editor = sharedPreferences.edit();
		editor.putString("password", "12345");

		editor.apply();
	}

	public void submitButtonClick(View view){
		String password = ((TextView)findViewById(R.id.password_text_id)).getText().toString();

		//Get password, and open BadPasswordActivity if the user input is not valid
		if(!sharedPreferences.getString("password", "").equals(password)) {
			Intent intent = new Intent(MainActivity.this, BadPasswordActivity.class);
			startActivity(intent);
		}
		else {
			//Create an intent for the ViewClassmatesActivity and pass the name given as input for the new activity to use
			Intent intent = new Intent(MainActivity.this, ViewClassmatesActivity.class);
			String name = ((EditText)findViewById(R.id.username_text_id)).getText().toString();
			intent.putExtra(ViewClassmatesActivity.NAME_TAG, name); //Static variable inside ViewClassmatesActivity for ease too use
			startActivityForResult(intent, ViewClassmatesActivity.GET_NOTE);
		}
	}

	@Override
	protected void onActivityResult(int requestCode, int resultCode, Intent data) {

		if (requestCode == ViewClassmatesActivity.GET_NOTE) {
			if(resultCode == Activity.RESULT_OK){
				//Once we get the OK, get the grade extra which is suppose to contain the sum return from all three students
				int grade = data.getIntExtra("grade", -1);

				//Get the first part of the string, add the grade after converting the int to string then add the last part of the grade string
				String grade_string = getResources().getString(R.string.show_grade) + Integer.toString(grade) + getResources().getString(R.string.points);

				//Make grade textview visible again and set its text to the grade we defined
				TextView grade_tv = (TextView)findViewById(R.id.grade_textview_id);
				grade_tv.setText(grade_string);
				grade_tv.setVisibility(View.VISIBLE);
			}
			if (resultCode == Activity.RESULT_CANCELED) {
				//Write your code if there's no result
			}
		}
	}
}

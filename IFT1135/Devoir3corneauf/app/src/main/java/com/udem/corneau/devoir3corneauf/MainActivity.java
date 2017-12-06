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
		sharedPreferences = getSharedPreferences("Settings", Context.MODE_PRIVATE);
		SharedPreferences.Editor editor = sharedPreferences.edit();
		editor.putString("password", "12345");

		editor.apply();
	}

	public void submitButtonClick(View view){
		String password = ((TextView)findViewById(R.id.password_text_id)).getText().toString();

		if(!sharedPreferences.getString("password", "").equals(password)) {
			Intent intent = new Intent(MainActivity.this, BadPasswordActivity.class);
			startActivity(intent);
		}
		else {
			Intent intent = new Intent(MainActivity.this, ViewClassmatesActivity.class);
			String name = ((EditText)findViewById(R.id.username_text_id)).getText().toString();
			intent.putExtra(ViewClassmatesActivity.NAME_TAG, name);
			startActivityForResult(intent, ViewClassmatesActivity.GET_NOTE);
		}
	}

	@Override
	protected void onActivityResult(int requestCode, int resultCode, Intent data) {

		if (requestCode == ViewClassmatesActivity.GET_NOTE) {
			if(resultCode == Activity.RESULT_OK){
				int grade = data.getIntExtra("grade", -1);

				String grade_string = getResources().getString(R.string.show_grade) + Integer.toString(grade) + getResources().getString(R.string.points);

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

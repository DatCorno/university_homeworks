package com.udem.corneau.devoir3corneauf;

import android.app.Activity;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;

public class ViewClassmatesActivity extends AppCompatActivity {

	public final static String NAME_TAG = "NAME";

	public final static int GET_NOTE =  1000;

	private int[] grades;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_view_classmates);

		grades = new int[3];

		((ListView)findViewById(R.id.classmates_list_id)).setAdapter(new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1,
				getResources().getStringArray(R.array.classmates_string_list)));

		Intent intent = getIntent();
		String name = intent.getStringExtra(NAME_TAG);
		((TextView)findViewById(R.id.name_textview_id)).setText(name);

		ListView ls = (ListView)findViewById(R.id.classmates_list_id);
		ls.setOnItemClickListener(new AdapterView.OnItemClickListener() {
			@Override
			public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
				Intent intent = new Intent(ViewClassmatesActivity.this, ViewClassmateDetailsActivity.class);
				intent.putExtra("position", i);
				startActivityForResult(intent, ViewClassmateDetailsActivity.GET_STUDENT_GRADE_CODE);
			}
		});
	}

	public void viewClassmatesBackClick(View view) {
		Intent result_intent = new Intent();

		int sum = 0;

		for(int i : grades)
			sum += i;

		result_intent.putExtra("grade", sum);

		setResult(Activity.RESULT_OK, result_intent);
		finish();
	}

	@Override
	protected void onActivityResult(int requestCode, int resultCode, Intent data) {

		if (requestCode == ViewClassmateDetailsActivity.GET_STUDENT_GRADE_CODE) {
			if(resultCode == Activity.RESULT_OK){
				int index = data.getIntExtra("index", 0);
				int grade = data.getIntExtra("grade", 0);

				grades[index] = grade;
			}
			if (resultCode == Activity.RESULT_CANCELED) {
				//Write your code if there's no result
			}
		}
	}
}

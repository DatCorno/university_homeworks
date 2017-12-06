package com.udem.corneau.devoir3corneauf;

import android.app.Activity;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;

import org.w3c.dom.Text;

import java.util.List;

public class ViewClassmateDetailsActivity extends AppCompatActivity {

	public final static int GET_STUDENT_GRADE_CODE = 1001;

	private int position;
	private String student_id;

	private String[] student_data;
	private String student_name;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_view_classmate_details);

		position = getIntent().getIntExtra("position", 0);
		student_id = getResources().getStringArray(R.array.classmates_id_string_list)[position];
		student_name = getResources().getStringArray(R.array.classmates_string_list)[position];
		student_data = getResources().getStringArray(getResources().getIdentifier(student_id, "array", getPackageName()));

		((ImageView)findViewById(R.id.student_imageview_id)).setImageResource(getResources().getIdentifier(student_id, "drawable", getPackageName()));

		setTextViewValues();
	}

	private void setTextViewValues() {
		TextView name = findViewById(R.id.classmate_name_textview_id);
		name.setText(student_name);
		TextView perm_code = findViewById(R.id.classmate_permcode_textview_id);
		perm_code.setText(student_data[0]);
		TextView email = findViewById(R.id.classmate_email_textview_id);
		email.setText(student_data[1]);

		String enrolled = "";

		if(student_data[2].equals("true"))
			enrolled = getResources().getString(R.string.is_enrolled);
		else
			enrolled = getResources().getString(R.string.is_not_enrolled);

		TextView enrolled_textview = findViewById(R.id.is_classmate_enrolled_textview_id);
		enrolled_textview.setText(enrolled);
	}

	public void returnToListClick(View view) {
		Intent result_intent = new Intent();

		result_intent.putExtra("index", position);

		String grade = ((EditText)findViewById(R.id.classmate_grade_edittext_id)).getText().toString();

		if(grade.isEmpty())
			grade = "0";

		result_intent.putExtra("grade", Integer.parseInt(grade));

		setResult(Activity.RESULT_OK, result_intent);
		finish();
	}
}

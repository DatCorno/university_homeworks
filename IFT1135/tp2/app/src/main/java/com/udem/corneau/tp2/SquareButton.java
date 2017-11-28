package com.udem.corneau.tp2;

//Taken here : https://stackoverflow.com/questions/37783598/how-to-create-exactly-square-buttons-that-fill-in-width-of-screen
import android.content.Context;
import android.util.AttributeSet;
import android.widget.Button;

/**
 * Created by XPS on 2017-11-16.
 */

public class SquareButton extends Button {
	public SquareButton(Context context) {
		super(context);
	}

	public SquareButton(Context context, AttributeSet attrs) {
		super(context, attrs);
	}

	public SquareButton(Context context, AttributeSet attrs, int defStyleAttr) {
		super(context, attrs, defStyleAttr);
	}

	public SquareButton(Context context, AttributeSet attrs, int defStyleAttr, int defStyleRes) {
		super(context, attrs, defStyleAttr, defStyleRes);
	}

	@Override
	public void onMeasure(int widthMeasureSpec, int heightMeasureSpec) {
		super.onMeasure(widthMeasureSpec, widthMeasureSpec);
		int width = MeasureSpec.getSize(widthMeasureSpec);
		int height = MeasureSpec.getSize(heightMeasureSpec);
		int size = width > height ? height : width;
		setMeasuredDimension(size, size); // make it square

	}
}
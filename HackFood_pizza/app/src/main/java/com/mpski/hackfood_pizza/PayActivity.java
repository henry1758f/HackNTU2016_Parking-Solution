package com.mpski.hackfood_pizza;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.NumberPicker;
import android.widget.Spinner;
import android.widget.TextView;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class PayActivity extends AppCompatActivity {
    private TextView User,deposit,cost,total;
    private EditText code;
    private Spinner spinner;
    private NumberPicker Parktime;
    private Button button;
    private Connection connect;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pay);
        User=(TextView)findViewById(R.id.User);
        deposit=(TextView)findViewById(R.id.deposit);
        cost=(TextView)findViewById(R.id.cost);
        total=(TextView)findViewById(R.id.total);
        code=(EditText)findViewById(R.id.editText);
        spinner=(Spinner)findViewById(R.id.spinner);
        ArrayAdapter adapter = new ArrayAdapter(this,android.R.layout.simple_spinner_item,new String[]{"台北市","新北市","基隆市"});
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spinner.setAdapter(adapter);
        spinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {

            }
            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });
        Parktime=(NumberPicker)findViewById(R.id.numberPicker);
        button=(Button)findViewById(R.id.button);
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

            }
        });
        mssql ms=new mssql();
        connect=ms.getConnection();
        determineRate("","3");

    }

    private int determineRate(String city,String code){
        ResultSet rs;
        try{
            Statement st=connect.createStatement();
            rs=st.executeQuery("select 費率 from 停車資料_全 where 識別碼="+code);
            rs.getInt(1);
            Log.d("識別",String.valueOf(rs.getInt(1)));
        }catch(SQLException e){
            e.printStackTrace();
        }
        return 0;
    }

}

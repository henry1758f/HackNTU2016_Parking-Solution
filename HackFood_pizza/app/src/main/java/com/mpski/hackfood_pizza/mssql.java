package com.mpski.hackfood_pizza;
import android.annotation.SuppressLint;
import android.os.StrictMode;
import android.provider.ContactsContract;
import android.util.Log;

import java.sql.*;

public class mssql {

    private boolean _isOpened=false;
    String ipaddress, db, username, password;
    public static Connection connect;
    Statement st;
    String errorcode;
    public boolean isOpened()
    {
        return _isOpened;
    }
    public String ErrorCode(){
        return errorcode;
    }
    public Connection getConnection(){return connect;}
    DatabaseMetaData dm;

    @SuppressLint("NewApi")
    private Connection ConnectionHelper(String user, String password,
                                        String database, String server) {
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder()
                .permitAll().build();
        StrictMode.setThreadPolicy(policy);
        Connection connection = null;
        String ConnectionURL = null;
        try {
            Class.forName("net.sourceforge.jtds.jdbc.Driver");
            ConnectionURL = "jdbc:jtds:sqlserver://" + ipaddress + "/" + db;
            //ConnectionURL="jdbc:jtds:sqlserver://hackparkingntu.database.windows.net:1433/HackParkingNTU";
            /*
            ConnectionURL="jdbc:sqlserver://hackparkingntu.database.windows.net:1433;database=HackParkingNTU;" +
            "user=henry1758f@hackparkingntu;password=HackNTU1995/03/29;encrypt=true;" +
                    "trustServerCertificate=false;hostNameInCertificate=*.database.windows.net;loginTimeout=30;";
                    */
            connection = DriverManager.getConnection(ConnectionURL,username,password);
        } catch (SQLException se) {
            errorcode=se.getMessage();
            Log.e("ERRO", se.getMessage());
        } catch (ClassNotFoundException e) {
            errorcode=e.getMessage();
            Log.e("ERRO", e.getMessage());
        } catch (Exception e) {
            errorcode= e.getMessage();
            Log.e("ERRO", e.getMessage());
        }
        return connection;
    }
    public mssql () {
        try {
            ipaddress = "hackparkingntu.database.windows.net:1433";
            db = "HackParkingNTU";
            username = "henry1758f@hackparkingntu";
            password = "HackNTU1995/03/29";
            connect = ConnectionHelper(username, password, db, ipaddress);
            if(connect==null){
                Log.e("ERRO","connect null");
                return;
            }
            if (connect.isClosed()==false)
            {
                _isOpened=true;
                System.out.println("connect ok");
                dm=connect.getMetaData();

                Statement st=connect.createStatement();
                ResultSet rs=st.executeQuery("select 道路 from 車位資料_全 ");
                int i=0;
                st=connect.createStatement();
                st.executeUpdate("update 車位資料_全 set 車位狀況=10 where 識別碼=10");
            }
            else
            {
                _isOpened=false;
                System.out.println("connect fail");
            }


        }

        catch (Exception ex) {

            ex.printStackTrace();

        }

    }

    public DatabaseMetaData getDatabaseMetadata(){
        return dm;
    }
}
package com.mpski.hackfood_pizza;

import android.content.Context;
import android.content.pm.PackageManager;
import android.content.res.Resources;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Matrix;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.location.Location;
import android.support.v4.app.ActivityCompat;
import android.support.v4.app.FragmentActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.animation.Animation;
import android.view.animation.RotateAnimation;
import android.widget.Toast;

import com.google.android.gms.common.ConnectionResult;
import com.google.android.gms.common.api.GoogleApiClient;
import com.google.android.gms.common.server.converter.StringToIntConverter;
import com.google.android.gms.location.LocationListener;
import com.google.android.gms.location.LocationRequest;
import com.google.android.gms.location.LocationServices;
import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.BitmapDescriptor;
import com.google.android.gms.maps.model.BitmapDescriptorFactory;
import com.google.android.gms.maps.model.CameraPosition;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.Marker;
import com.google.android.gms.maps.model.MarkerOptions;

import java.sql.Connection;
import java.sql.DatabaseMetaData;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class MapsActivity extends FragmentActivity implements OnMapReadyCallback,
        GoogleApiClient.ConnectionCallbacks,
        GoogleApiClient.OnConnectionFailedListener,
        LocationListener {
    private GoogleMap mMap;
    // Google API用戶端物件
    private GoogleApiClient googleApiClient;
    // Location請求物件
    private LocationRequest locationRequest;
    // 記錄目前最新的位置
    private Location currentLocation;
    // 顯示目前與儲存位置的標記物件
    private Marker currentMarker, itemMarker;
    private BitmapDescriptor icon;
    //Sensors
    private SensorManager sensorManager;
    //databasemetadata
    private DatabaseMetaData dm;
    private Connection connect;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_maps);
        SupportMapFragment mapFragment = (SupportMapFragment) getSupportFragmentManager()
                .findFragmentById(R.id.map);
        mapFragment.getMapAsync(this);

        setupicon();
        configGoogleApiClient(); //地圖服務
        configLocationRequest(); //定位服務
        setupSensors(); //方向
        ConnectToTerminal(); //連資料庫


    }
    private void setupmarkers(){
        try{
            ResultSet Latitude,Longtitude;
            Statement st=connect.createStatement();
            Latitude=st.executeQuery("select Latitude from 車位資料_全 ");
            st=connect.createStatement();
            Longtitude=st.executeQuery("select Longitude from 車位資料_全 ");
            while(Latitude.next() && Longtitude.next()){
                mMap.addMarker(new MarkerOptions().position(new LatLng(Latitude.getFloat(1)/1000000,Longtitude.getFloat(1)/1000000)));
                Log.d("qqqqqqqqqqqqqqq", String.valueOf(Latitude.getFloat(1)/1000000)+" "+String.valueOf(Longtitude.getFloat(1)/1000000));
                //mMap.addMarker(new MarkerOptions().position(new LatLng(23.5,120)).icon(icon));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
    private void setupicon(){
        Bitmap bmp = BitmapFactory.decodeResource(getResources(),
                R.drawable.arrow);
        int oldwidth = bmp.getWidth();
        int oldheight = bmp.getHeight();
        float scaleWidth = 100 / (float)oldwidth;
        float scaleHeight = 100 / (float)oldheight;
        Matrix matrix = new Matrix();
        matrix.postScale(scaleWidth, scaleHeight);
        Bitmap resizedBitmap = Bitmap.createBitmap(bmp, 0, 0, oldwidth,oldheight, matrix, true);
        icon=BitmapDescriptorFactory.fromBitmap(resizedBitmap);
    }
    private void ConnectToTerminal(){
        mssql ms=new mssql();
        connect=ms.getConnection();
        dm=ms.getDatabaseMetadata();
    }
    @Override
    public void onMapReady(GoogleMap googleMap) {
        mMap = googleMap;

        setupmarkers();
    }
    private void moveMap(LatLng latlng){
        CameraPosition cameraPosition =
                new CameraPosition.Builder()
                        .target(latlng)
                        .zoom(17)
                        .build();
        // 使用動畫的效果移動地圖
        mMap.animateCamera(CameraUpdateFactory.newCameraPosition(cameraPosition),
                new GoogleMap.CancelableCallback() {
                    @Override
                    public void onFinish() {
                        if (itemMarker != null) {
                            itemMarker.showInfoWindow();
                        }
                    }
                    @Override
                    public void onCancel() {

                    }
                });
    }

    private synchronized void configGoogleApiClient() {
        googleApiClient = new GoogleApiClient.Builder(this)
                .addConnectionCallbacks(this)
                .addOnConnectionFailedListener(this)
                .addApi(LocationServices.API)
                .build();
        googleApiClient.connect();
        Toast.makeText(this,"configGoogleApiClient.",Toast.LENGTH_SHORT).show();
    }

    private void configLocationRequest() {
        locationRequest = new LocationRequest();
        // 設定讀取位置資訊的間隔時間為一秒（1000ms）
        locationRequest.setInterval(1000);
        // 設定讀取位置資訊最快的間隔時間為一秒（1000ms）
        locationRequest.setFastestInterval(1000);
        // 設定優先讀取高精確度的位置資訊（GPS）
        locationRequest.setPriority(LocationRequest.PRIORITY_HIGH_ACCURACY);
    }
    @Override
    public void onConnected(Bundle bundle) {

        Toast.makeText(this,"Google Service Connected.",Toast.LENGTH_SHORT).show();
        // 已經連線到Google Services
        // 啟動位置更新服務
        // 位置資訊更新的時候，應用程式會自動呼叫LocationListener.onLocationChanged
        if (ActivityCompat.checkSelfPermission(this, android.Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED && ActivityCompat.checkSelfPermission(this, android.Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
            return;
        }
        LocationServices.FusedLocationApi.requestLocationUpdates(
                googleApiClient, locationRequest, MapsActivity.this);
    }
    @Override
    public void onConnectionSuspended(int i) {
            // Google Services連線中斷
            // int參數是連線中斷的代號
        Toast.makeText(this,"Google Service Suspended.",Toast.LENGTH_SHORT).show();
    }
    @Override
    public void onConnectionFailed(ConnectionResult connectionResult) {
        Toast.makeText(this,"Google Service Failed.",Toast.LENGTH_SHORT).show();
        // Google Services連線失敗
        // ConnectionResult參數是連線失敗的資訊
        int errorCode = connectionResult.getErrorCode();
        // 裝置沒有安裝Google Play服務
        if (errorCode == ConnectionResult.SERVICE_MISSING) {
            Toast.makeText(this, R.string.google_play_service_missing,
                    Toast.LENGTH_LONG).show();
        }
    }
    @Override
    public void onLocationChanged(Location location) {
        // 位置改變
        // Location參數是目前的位置
        currentLocation = location;
        LatLng latLng = new LatLng(
                location.getLatitude(), location.getLongitude());

        // 設定目前位置的標記
        if (currentMarker == null) {
            currentMarker = mMap.addMarker(new MarkerOptions().position(latLng)
                                            .icon(icon));
            moveMap(latLng);
        }
        else {
            currentMarker.setPosition(latLng);
        }
        // 移動地圖到目前的位置
        //moveMap(latLng);
    }

    private void setupSensors(){
        sensorManager = (SensorManager) getSystemService(Context.SENSOR_SERVICE);
        Sensor magnetic = sensorManager
                .getDefaultSensor(Sensor.TYPE_MAGNETIC_FIELD);
        Sensor accelerometer = sensorManager
                .getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
        sensorManager.registerListener(listener, magnetic,
                SensorManager.SENSOR_DELAY_GAME);
        sensorManager.registerListener(listener, accelerometer,
                SensorManager.SENSOR_DELAY_GAME);
    }

    private SensorEventListener listener = new SensorEventListener() {
        float[] accelerometerValues = new float[3];
        float[] magneticValues = new float[3];
        private float lastDegree;
        public void onSensorChanged(SensorEvent event) {
            if (event.sensor.getType() == Sensor.TYPE_ACCELEROMETER) {
                accelerometerValues = event.values.clone();
            } else if (event.sensor.getType() == Sensor.TYPE_MAGNETIC_FIELD) {
                magneticValues = event.values.clone();
            }
            float[] R = new float[9];
            float[] values = new float[3];
            SensorManager.getRotationMatrix(R, null, accelerometerValues,magneticValues);
            SensorManager.getOrientation(R, values);
            float rotateDegree = (float) Math.toDegrees(values[0]);
            if (Math.abs(rotateDegree - lastDegree) > 1) {
                if(currentMarker!=null){
                    currentMarker.setRotation(rotateDegree - lastDegree);
                }
            }
        }
        @Override
        public void onAccuracyChanged(Sensor sensor, int i) {

        }
    };
    @Override
    protected void onResume() {
        super.onResume();
          //setUpMapIfNeeded();
        // 連線到Google API用戶端
        if (!googleApiClient.isConnected() && currentMarker != null) {
            googleApiClient.connect();
        }
    }
    @Override
    protected void onPause() {
        super.onPause();
        // 移除位置請求服務
        if (googleApiClient.isConnected()) {
            LocationServices.FusedLocationApi.removeLocationUpdates(
                    googleApiClient, this);
        }
    }
    @Override
    protected void onStop() {
        super.onStop();
        // 移除Google API用戶端連線
        if (googleApiClient.isConnected()) {
            googleApiClient.disconnect();
        }
    }
}

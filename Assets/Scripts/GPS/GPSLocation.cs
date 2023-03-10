using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GPSLocation : MonoBehaviour
{
    public TMP_Text GPSStatus;
    public TMP_Text latitudeValue;
    public TMP_Text longitudeValue;
    public TMP_Text altitudeValue;
    public TMP_Text horizontalAccuracyValue;
    public TMP_Text timestampValue;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GPSLoc());
    }

    IEnumerator GPSLoc()
    {
        //checks of de telefoon locatie aan hebt
        if(!Input.location.isEnabledByUser)
            yield break;

        //starts 
        Input.location.Start();
        //Wachts tot dat de service begint
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
        //Service werd niet geinitialiseerd na 20 seconden
        if (maxWait < 1)
        {
            GPSStatus.text = "Time out";
            yield break;
        }
        
        //Connectie onderbroken
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            GPSStatus.text = "Can't find device location";
            yield break;
        }
        else
        {
            GPSStatus.text = "Running";
            InvokeRepeating("UpdateGPSData", 0.5f, 1f);
            //Toegang verleend
        }
    }// Einde van GPSLoc

    private void UpdateGPSData()
    {
        if (Input.location.status == LocationServiceStatus.Running)
        {
            GPSStatus.text = "Running";
            latitudeValue.text = Input.location.lastData.latitude.ToString();
            longitudeValue.text = Input.location.lastData.longitude.ToString();
            altitudeValue.text = Input.location.lastData.altitude.ToString();
            horizontalAccuracyValue.text = Input.location.lastData.horizontalAccuracy.ToString();
            timestampValue.text = Input.location.lastData.timestamp.ToString();
            //Toegang verleend aan gps locatie en geinitialiseerd
        }
        else
        {
            // service is gestopt
        }

    }//Einde van GpsDataUpdate
}

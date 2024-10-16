using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DifficultySlider : MonoBehaviour
{
    public static float DifficultyValue = 1;

    public Button Easy;
    public Button Med;
    public Button Hard;
    public Button VHard;
    public static bool cloudOn;
    public static string n = "Simple";
    public static int diffi = 1;
    public static bool birdOn;
    public static bool HABOn;
    

    public void OnClickEasy()
    {
        cloudOn = false;
        birdOn = false;
        HABOn = false;
      
        n = "Simple";
        diffi = 1;
    }

    public void OnClickMed()
    {
        cloudOn = false;
        birdOn = false;
        HABOn = false;

        n = "Basic";
        diffi = 2;
    }
    public void OnClickHard()
    {
        cloudOn = true;
        birdOn = false;
        HABOn = false;
    
        n = "Advanced";
        diffi = 3;
    }
    public void OnClickVHard()
    {
        cloudOn = true;
        birdOn = true;
        HABOn = true;

        n = "Complex";
        diffi = 4;
    }

    public void OnClickEasyDif() //presets
    {
        cloudOn = false;
        birdOn = false;
        HABOn = false;

        TimerSlider.TurnTimeValue = 20f;
        n = "Simple";
        diffi = 1;
    }

    public void OnClickMedDif()
    {
        cloudOn = false;
        birdOn = false;
        HABOn = false;
        n = "Basic";
        diffi = 2;
    }

    public void OnClickHardDif()
    {
        cloudOn = true;
        birdOn = false;
        HABOn = false;
        n = "Advanced";
        diffi = 3;
    }

    public void OnClickVeryHardDif()
    {
        cloudOn = true;
        birdOn = true;
        HABOn = true;
        n = "Complex";
        diffi = 4;
    }

}

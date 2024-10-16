using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public int tempbackvalue;
    public float temptotaltime;
    public float tempturntimer;
    public string backstring;

    // Start is called before the first frame update
    public void Start()
    {
        tempbackvalue = DifficultySlider.diffi;
        backstring = DifficultySlider.n;
        temptotaltime = TotalTimeScript.TotalTime;
        tempturntimer = TimerSlider.TurnTimeValue;
    }

    public void OnClick()
    {
        TimerSlider.TurnTimeValue= tempturntimer;
        TotalTimeScript.TotalTime= temptotaltime;
        DifficultySlider.n = backstring;
        DifficultySlider.diffi = tempbackvalue;
    }

}

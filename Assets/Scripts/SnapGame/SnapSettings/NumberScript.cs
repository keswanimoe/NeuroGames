using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberScript : MonoBehaviour
{
    public Text turnnum;

    public Text totalnum;

    public Text background;


    public void Update()
    {
        turnnum.text = TimerSlider.TurnTimeValue.ToString();
        if (TimerSlider.TurnTimeValue == 65)
        {
            turnnum.text = "Unlimited";
        }
        totalnum.text = TotalTimeScript.TotalTime.ToString();

        background.text = DifficultySlider.n;

    }
}

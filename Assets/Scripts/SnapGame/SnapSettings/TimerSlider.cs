using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSlider : MonoBehaviour
{
    public Slider sliderInstance;

    public Text SliderValue;

    public AudioSource SliderTick;

    public static float TurnTimeValue=65f;

    public void Start()
    {
        sliderInstance.minValue = 1;
        sliderInstance.maxValue = 13;
        sliderInstance.wholeNumbers = true;
        sliderInstance.value = TurnTimeValue/5;
        SliderValue.text = "Unlimited";
    }

    public void OnClickCustom()
    {
        sliderInstance.minValue = 1;
        sliderInstance.maxValue = 13;
        sliderInstance.wholeNumbers = true;
        sliderInstance.value = TurnTimeValue / 5;
        SliderValue.text = TurnTimeValue.ToString("0");
        if (TurnTimeValue == 65)
        {
            SliderValue.text = "Unlimited";
        }
    }
    public void OnValueChanged(float TurnTime)
    {
        Debug.Log ("New Value"+ TurnTime);
        TurnTimeValue = TurnTime*5;
        SliderTick.Play();
        if (TurnTime == 13)
        {
            SliderValue.text = "Unlimited";
        }
        else
        {
            SliderValue.text = TurnTimeValue.ToString("0");
        }

    }


    public void OnClickEasyDif() //presets
    {
        DifficultySlider.cloudOn = false;
        DifficultySlider.birdOn = false;
        DifficultySlider.HABOn = false;
        TurnTimeValue = 20f;
        DifficultySlider.n = "Simple";
        DifficultySlider.diffi = 1;

    }

    public void OnClickMedDif()
    {
        DifficultySlider.cloudOn = false;
        DifficultySlider.birdOn = false;
        DifficultySlider.HABOn = false;
        TurnTimeValue = 15f;
        DifficultySlider.n = "Moderate";
        DifficultySlider.diffi = 2;
    }

    public void OnClickHardDif()
    {
        DifficultySlider.cloudOn = true;
        DifficultySlider.birdOn = false;
        DifficultySlider.HABOn = false;
        TurnTimeValue = 10f;
        DifficultySlider.n = "Advanced";
        DifficultySlider.diffi = 3;
    }

    public void OnClickVeryHardDif()
    {
        DifficultySlider.cloudOn = true;
        DifficultySlider.birdOn = true;
        DifficultySlider.HABOn = true;
        TurnTimeValue = 5f;
        DifficultySlider.n = "Complex";
        DifficultySlider.diffi = 4;
    }

}

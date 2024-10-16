using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropDownScript : MonoBehaviour
{

    public Image Preview;
    public static int dropdownval = 0;

    public void Start()
    {
        dropdownval = 0; /////////
    }

    public void HandleInputData(int val)
    {
        if (val == 0) 
        {
            Preview.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/dog");
            dropdownval = val;

        }
        else if(val == 1)
        {
            Preview.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/apple");
            dropdownval = val;
        }
        else if (val == 2)
        {
            Preview.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/sofa");
            dropdownval = val;
        }
        else if (val == 3)
        {
            Preview.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/hammer");
            dropdownval = val;
        }
        else if (val == 4)
        {
            Preview.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/taxi");
            dropdownval = val;
        }
    }
}

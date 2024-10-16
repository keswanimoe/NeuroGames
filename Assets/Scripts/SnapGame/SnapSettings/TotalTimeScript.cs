using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalTimeScript : MonoBehaviour
{
    public static float TotalTime=240f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick2()
    {
        TotalTime = 120f;
    }

    public void OnClick4()
    {
        TotalTime = 240f;
    }

    public void OnClick6()
    {
        TotalTime = 360f;
    }

    public void OnClick8()
    {
        TotalTime = 480f;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHighlight : MonoBehaviour
{
    public GameObject Easy;
    public GameObject Med;
    public GameObject Hard;
    public GameObject Vhard;

    public GameObject twomin;
    public GameObject fourmin;
    public GameObject sixmin;
    public GameObject eightmin;


    // Update is called once per frame
    public void Update()
    {
        //for highlighting background buttons
        if (DifficultySlider.n.Equals("Simple"))
        {
            Easy.SetActive(true);
            Med.SetActive(false);
            Hard.SetActive(false);
            Vhard.SetActive(false);
        }

        if (DifficultySlider.n.Equals("Basic"))
        {
            Easy.SetActive(false);
            Med.SetActive(true);
            Hard.SetActive(false);
            Vhard.SetActive(false);
        }

        if (DifficultySlider.n.Equals("Advanced"))
        {
            Easy.SetActive(false);
            Med.SetActive(false);
            Hard.SetActive(true);
            Vhard.SetActive(false);
        }

        if (DifficultySlider.n.Equals("Complex"))
        {
            Easy.SetActive(false);
            Med.SetActive(false);
            Hard.SetActive(false);
            Vhard.SetActive(true);
        }

        //for highlighting time buttons
        if (TotalTimeScript.TotalTime == 120f)
        {
            twomin.SetActive(true);
            fourmin.SetActive(false);
            sixmin.SetActive(false);
            eightmin.SetActive(false);
        }
        if (TotalTimeScript.TotalTime == 240f)
        {
            twomin.SetActive(false);
            fourmin.SetActive(true);
            sixmin.SetActive(false);
            eightmin.SetActive(false);
        }
        if (TotalTimeScript.TotalTime == 360f)
        {
            twomin.SetActive(false);
            fourmin.SetActive(false);
            sixmin.SetActive(true);
            eightmin.SetActive(false);
        }
        if (TotalTimeScript.TotalTime == 480f)
        {
            twomin.SetActive(false);
            fourmin.SetActive(false);
            sixmin.SetActive(false);
            eightmin.SetActive(true);
        }
    }

}

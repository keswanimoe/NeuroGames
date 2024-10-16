using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoButtons : MonoBehaviour
{
    public GameObject Easy;
    public GameObject Med;
    public GameObject Hard;
    public GameObject VHard;

    public Button EasyB;
    public Button MedB;
    public Button HardB;
    public Button VHardB;

    public bool easybool=false;
    public bool medbool = false;
    public bool hardbool = false;
    public bool vhardbool = false;

    public void Awake()
    {
        Easy.SetActive(false);
        Med.SetActive(false);
        Hard.SetActive(false);
        VHard.SetActive(false);
    }

    public void OnClickE()
    {
        if (easybool == false)
        {
            easybool = true;
        }
        else
        {
            easybool = false;
        }

        if (easybool == true)
        {
            Easy.SetActive(true);
        }
        else
        {
            Easy.SetActive(false);
        }
    }

    public void OnClickM()
    {
        if (medbool == false)
        {
            medbool = true;
        }
        else
        {
            medbool = false;
        }

        if (medbool == true)
        {
            Med.SetActive(true);
        }
        else
        {
            Med.SetActive(false);
        }
    }

    public void OnClickH()
    {
        if (hardbool == false)
        {
            hardbool = true;
        }
        else
        {
            hardbool = false;
        }

        if (hardbool == true)
        {
            Hard.SetActive(true);
        }
        else
        {
            Hard.SetActive(false);
        }
    }

    public void OnClickVHard()
    {
        if (vhardbool == false)
        {
            vhardbool = true;
        }
        else
        {
            vhardbool = false;
        }

        if (vhardbool == true)
        {
            VHard.SetActive(true);
        }
        else
        {
            VHard.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

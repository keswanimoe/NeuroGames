using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeInfo : MonoBehaviour
{
    public GameObject Easy;
    public GameObject Med;
    public GameObject PlayerTheme;

    public Button EasyB;
    public Button MedB;
    public Button PlayerThemeB;

    public bool easybool = false;
    public bool medbool = false;
    public bool themebool = false;

    public void Awake()
    {
        Easy.SetActive(false);
        Med.SetActive(false);
        PlayerTheme.SetActive(false);
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

    public void OnClickTheme()
    {
        if (themebool == false)
        {
            themebool = true;
        }
        else
        {
            themebool = false;
        }

        if (themebool == true)
        {
            PlayerTheme.SetActive(true);
        }
        else
        {
            PlayerTheme.SetActive(false);
        }
    }
    }



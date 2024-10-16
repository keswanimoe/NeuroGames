using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedBackground : MonoBehaviour
{
    public GameObject Cloud1;
    public GameObject Cloud2;
    public GameObject Cloud3;
    public GameObject Cloud4;
    public GameObject Cloud5;
    public GameObject Cloud6;
    public GameObject Cloud7;
    public GameObject Cloud8;

    public AudioSource BirdNoises;
    public AudioSource WindMed;


    // Start is called before the first frame update
    void Start()
    {
        Cloud1.SetActive(false);
        Cloud2.SetActive(false);
        Cloud3.SetActive(false);
        Cloud4.SetActive(false);
        Cloud5.SetActive(false);
        Cloud6.SetActive(false);
        Cloud7.SetActive(false);
        Cloud8.SetActive(false);

        if (DifficultySlider.diffi == 2)
        {
            Cloud1.SetActive(true);
            Cloud2.SetActive(true);
            Cloud3.SetActive(true);
            Cloud4.SetActive(true);
            Cloud5.SetActive(true);
            Cloud6.SetActive(true);
            Cloud7.SetActive(true);
            Cloud8.SetActive(true);
        }

        if (DifficultySlider.diffi == 4)
        {
            BirdNoises.Play();
        }

        if (DifficultySlider.diffi == 3)
        {
            WindMed.Play();
        }
    }

}

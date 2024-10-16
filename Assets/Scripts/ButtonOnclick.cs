using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOnclick : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource SoundSource;
    void Start()
    {
        
    }
    public void OnClick()
    {
        SoundSource.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

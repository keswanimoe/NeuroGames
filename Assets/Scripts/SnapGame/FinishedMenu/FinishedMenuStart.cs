using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinishedMenuStart : MonoBehaviour
{
    public AudioSource Jingle;

    public Text Score;
    public Text Mistakes;
    public Text TotTime;
    public Text AvgTurn;
    public Text Background;
    // Start is called before the first frame update
    void Start()
    {
        Jingle.Play();

        Score.text = NewCardScript.Score.ToString();
        Mistakes.text = NewCardScript.CompScore.ToString();
        TotTime.text = (TurnTimerScript.StartTotTime - TotalTimeScript.TotalTime).ToString("0.0");
        AvgTurn.text = ((TurnTimerScript.StartTotTime - TotalTimeScript.TotalTime) / (NewCardScript.turnnum)).ToString("0.0");
       
            //NewCardScript.totalturn
        Background.text = DifficultySlider.n.ToString();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnTimerScript : MonoBehaviour
{
    public GameObject PlayerCardProperties;
    public Text PlayerCard; // declaring text fields
    public Text EnemyCard;
    public Text PlayerScore;
    public Text EnemyScore;
    public Text TurnTimer;
    public Text TotalTimeTxt;
    public GameObject ResultsMenu;
    public string temp;
    
    public static float StartTotTime;
    public static float MaxTurnTime;

    public static float currentTime = 0f;
   // public static float startingTime = TimerSlider.TurnTimeValue; //declaring turn timer numbers

    public Image PlayerImage;
    public Image EnemyImage;


    public void SetText(string text)
    {
        PlayerCard.text = text; //Trying to get text show on click??
        EnemyCard.text = text;
        PlayerScore.text = text;
        EnemyScore.text = text;
        TurnTimer.text = text;
        TotalTimeTxt.text = text;
    }

    public void Start()
    {
        StartTotTime = TotalTimeScript.TotalTime;
        MaxTurnTime = TimerSlider.TurnTimeValue;

    }


    // Update is called once per frame
    public void Update()
    {
        if (TotalTimeScript.TotalTime <= 0)
        {//////////////////////////
            NewCardScript.totalturn = NewCardScript.totalturn + TimerSlider.TurnTimeValue - TurnTimerScript.currentTime; //add to total turn time to calculate avg turn time
            //NewCardScript.turnnum = NewCardScript.turnnum + 1;
            /////////////

            PlayerCardProperties.SetActive(false);
            ResultsMenu.SetActive(true);

        }
        else
        {
            TotalTimeScript.TotalTime -= 1 * Time.deltaTime;
            TotalTimeTxt.text = TotalTimeScript.TotalTime.ToString("0");
        }
           


        if (TimerSlider.TurnTimeValue ==65)
        {
            return;
        }
        else if (TimerSlider.TurnTimeValue == 0)
        {
            return;
        }
        else
        {
            currentTime -= 1 * Time.deltaTime;
            TurnTimer.text = currentTime.ToString("0");

            if (currentTime < 0) //timer runs out
            {

                //yield return new WaitForSeconds(1); //stay on
                currentTime = TimerSlider.TurnTimeValue;

                ////////////////////////////////////////////////////////////// Updating 
                NewCardScript.mistakeCardList.Add(GameSceneStart.playerPictureArray[GameSceneStart.randomPlayernum]); //try Pnumber?
                NewCardScript.mistakeCardList.Add(GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum]); //add mistakes to card and theme array

                NewCardScript.mistakeThemeList.Add(GameSceneStart.cardThemeArray[GameSceneStart.randomECardnum]);
                //////////////////////////////////////////////////////////////

                GameSceneStart.randomPlayernum = Random.Range(0, GameSceneStart.playerArray.Length);
                NewCardScript.PlayerID = GameSceneStart.playerArray[GameSceneStart.randomPlayernum];
                NewCardScript.PlayerPicture = GameSceneStart.playerPictureArray[GameSceneStart.randomPlayernum]; //get picture element
                //PlayerCard.text = NewCardScript.PlayerPicture; //show picture on player card
                PlayerImage.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/" + NewCardScript.PlayerPicture); //find file with name PlayerPicture in the resources folder


                NewCardScript.EnemyPicture = temp;
                GameSceneStart.randomECardnum = Random.Range(0, GameSceneStart.cardArray.Length); //refresh number until pictures are different (unless its the last card in the players deck)
                NewCardScript.EnemyPicture = GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum];
                if (GameSceneStart.cardArray.Length > 1)
                {
                    while (NewCardScript.EnemyPicture == temp) ///////////WHILE cardID == temp//////////////////////// afterwards
                    {
                        GameSceneStart.randomECardnum = Random.Range(0, GameSceneStart.cardArray.Length); //refresh number until elements position is different
                        NewCardScript.EnemyPicture = GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum];
                    }

                }
                NewCardScript.EnemyID = GameSceneStart.cardArray[GameSceneStart.randomECardnum];////////////////////////////////////////////////////////
                NewCardScript.EnemyPicture = GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum];
                //EnemyCard.text = NewCardScript.EnemyPicture;
                EnemyImage.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/" + NewCardScript.EnemyPicture);

                NewCardScript.totalturn = NewCardScript.totalturn + TimerSlider.TurnTimeValue - TurnTimerScript.currentTime; //add to total turn time to calculate avg turn time
                NewCardScript.turnnum = NewCardScript.turnnum + 1;

                NewCardScript.CompScore = (NewCardScript.CompScore + 1);
                //EnemyScore.text = NewCardScript.CompScore.ToString(); //update Computer score

                //NewCardScript.DrawCard.Play();

            }
        }

    }
        
}

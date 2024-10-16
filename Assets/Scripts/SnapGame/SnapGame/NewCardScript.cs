using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewCardScript : MonoBehaviour
{
    public GameObject PlayerCardProperties;
    public GameObject ResultsMenu;
    public Text PlayerCard; // declaring text fields
    public Text EnemyCard;
    public Text PlayerScore;
    //public Text EnemyScore;
    public Text TurnTimer;
    public AudioSource Correct;
    public string temp;
    public AudioSource DrawCard;

    public static List<string> mistakeCardList = new List<string>(); //list of mistakes
    public static List<string> mistakeThemeList = new List<string>(); //list of mistakes

    public static float turnnum=1;
    public static float totalturn=0; //for calculating average turn time
    public static float avgturn=0;

    public static int CompScore; //declaring GLOBAL VARIABLES (so the variables have the same value in all the functions)
    public static int Score; 
    public static int PlayerID;
    public static int EnemyID; //this is the number of the enemy card (will be a picture eventually)
    public static string PlayerPicture;
    public static string EnemyPicture;

    //public Image PlayerImage;
    public Image EnemyImage;
    public Image PlayerImage;


    public void SetText(string text)
    {
        PlayerCard.text = text; //Trying to get text show on click??
        EnemyCard.text = text;
        PlayerScore.text = text;
        //EnemyScore.text = text;
    }

    public void Start() //when scene starts
    {
        turnnum = 1;
        totalturn = 0;
        avgturn = 0;
        //Generate EnemyID and PlayerID
        //Generate Array of all the theme items with corresponding ThemeIDs

        TurnTimerScript.currentTime = TimerSlider.TurnTimeValue; // start of turn timer

        //REFRESH PLAYER CARD
        GameSceneStart.randomPlayernum = Random.Range(0, GameSceneStart.playerArray.Length);

        PlayerID = GameSceneStart.playerArray[GameSceneStart.randomPlayernum];
        PlayerPicture = GameSceneStart.playerPictureArray[GameSceneStart.randomPlayernum]; //get picture element
        //PlayerCard.text = PlayerPicture; //show picture on player card
        PlayerImage.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/" + PlayerPicture); //find file with name PlayerPicture in the resources folder


        GameSceneStart.randomECardnum = Random.Range(0, GameSceneStart.cardArray.Length);
        EnemyID = GameSceneStart.cardArray[GameSceneStart.randomECardnum];
        EnemyPicture = GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum];
        //EnemyCard.text = EnemyPicture;
        EnemyImage.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/" + EnemyPicture); //find file with name PlayerPicture in the resources folder

        CompScore = 0;
        Score = 0;
        PlayerScore.text = Score.ToString();
        //EnemyScore.text = CompScore.ToString();
    }


    public void OnClick() //For NEW CARD BUTTON
    {
        if (PlayerID == EnemyID) //
        {
            CompScore = CompScore + 1;
            //EnemyScore.text = CompScore.ToString();//needed?

            mistakeCardList.Add(GameSceneStart.playerPictureArray[GameSceneStart.randomPlayernum]); //try Pnumber?
            mistakeCardList.Add(GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum]); //add mistakes to card and theme array

            mistakeThemeList.Add(GameSceneStart.cardThemeArray[GameSceneStart.randomECardnum]);

        }
        else
        {

            ArrayScript.jumbleEArray(); //remove element
        }

        EnemyPicture = temp;
        GameSceneStart.randomECardnum = Random.Range(0, GameSceneStart.cardArray.Length); //refresh number until elements position is different
        EnemyPicture = GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum];
        if (GameSceneStart.cardArray.Length > 1)
        {
            while (EnemyPicture == temp) ///////////WHILE cardID == temp//////////////////////// afterwards
            {
                GameSceneStart.randomECardnum = Random.Range(0, GameSceneStart.cardArray.Length); //refresh number until elements position is different
                EnemyPicture = GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum];
            }

        }

        totalturn = totalturn + TimerSlider.TurnTimeValue - TurnTimerScript.currentTime; //add to total turn time to calculate avg turn time
        turnnum = turnnum + 1;

        EnemyID = GameSceneStart.cardArray[GameSceneStart.randomECardnum];
        EnemyPicture = GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum];
        //EnemyCard.text = EnemyPicture;
        EnemyImage.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/" + EnemyPicture); //find file with name PlayerPicture in the resources folder

        TurnTimerScript.currentTime = TimerSlider.TurnTimeValue; // reset timer

        DrawCard.Play();
    }

    public void OnClickSnap() //For SNAP BUTTON
    {
        if (PlayerID == EnemyID) //
        {
            if (GameSceneStart.playerArray.Length==1)
            {
                PlayerCardProperties.SetActive(false);
                ResultsMenu.SetActive(true);
                Score = Score + 1;
            }
            else
            {
                Correct.Play();
                ArrayScript.jumblePArray(); //remove element

                Score = Score + 1; //correct snap, user gets point

                //generating new values for both cards
                GameSceneStart.randomPlayernum = Random.Range(0, GameSceneStart.playerArray.Length);
                PlayerID = GameSceneStart.playerArray[GameSceneStart.randomPlayernum];
                PlayerPicture = GameSceneStart.playerPictureArray[GameSceneStart.randomPlayernum]; //picture is the same element position as PlayerID
                //PlayerCard.text = PlayerPicture; //add picture to player card
                PlayerImage.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/" + PlayerPicture); //find file with name PlayerPicture in the resources folder

                EnemyPicture = temp;
                GameSceneStart.randomECardnum = Random.Range(0, GameSceneStart.cardArray.Length); //refresh number until elements position is different
                EnemyPicture = GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum];
                if (GameSceneStart.cardArray.Length > 1)
                {
                    while (EnemyPicture == temp) ///////////WHILE cardID == temp//////////////////////// afterwards
                    {
                        GameSceneStart.randomECardnum = Random.Range(0, GameSceneStart.cardArray.Length); //refresh number until elements position is different
                        EnemyPicture = GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum];
                    }

                }
                EnemyID = GameSceneStart.cardArray[GameSceneStart.randomECardnum];////////////////////////////////////////////////////////
                EnemyPicture = GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum];
                //EnemyCard.text = EnemyPicture;
                EnemyImage.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/" + EnemyPicture); //find file with name PlayerPicture in the resources folder

                TurnTimerScript.currentTime = TimerSlider.TurnTimeValue; // reset timer
            }
        }

        else
        {
            CompScore = CompScore + 1; //snap incorrect, computer gets point

            mistakeCardList.Add(GameSceneStart.playerPictureArray[GameSceneStart.randomPlayernum]);
            mistakeCardList.Add(GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum]); //add mistakes to card and theme array
            mistakeThemeList.Add(GameSceneStart.cardThemeArray[GameSceneStart.randomECardnum]);

            //generating new values for both cards
            GameSceneStart.randomPlayernum = Random.Range(0, GameSceneStart.playerArray.Length);
            PlayerID = GameSceneStart.playerArray[GameSceneStart.randomPlayernum];
            PlayerPicture = GameSceneStart.playerPictureArray[GameSceneStart.randomPlayernum];
            //PlayerCard.text = PlayerPicture;
            PlayerImage.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/" + PlayerPicture); //find file with name PlayerPicture in the resources folder

            GameSceneStart.randomECardnum = Random.Range(0, GameSceneStart.cardArray.Length); //refresh number until elements position is different
            EnemyID = GameSceneStart.cardArray[GameSceneStart.randomECardnum];
            EnemyPicture = GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum];
            //EnemyCard.text = EnemyPicture;
            EnemyImage.sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/" + EnemyPicture); //find file with name PlayerPicture in the resources folder
            TurnTimerScript.currentTime = TimerSlider.TurnTimeValue; // reset timer
            DrawCard.Play();
        }

        PlayerScore.text = Score.ToString(); //update player score
        //EnemyScore.text = CompScore.ToString(); //update Computer score

        totalturn = totalturn + TimerSlider.TurnTimeValue - TurnTimerScript.currentTime; //add to total turn time to calculate avg turn time
        turnnum = turnnum + 1;

    }

    public void Update()
    {
        foreach (var item in mistakeCardList)
        {
            //Debug.Log(item.ToString());
        }

    }
}

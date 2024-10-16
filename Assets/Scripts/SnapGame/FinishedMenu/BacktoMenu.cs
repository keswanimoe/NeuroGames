using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BacktoMenu : MonoBehaviour
{
    public void OnClick() //Resetting ALL of the static variables, oh boy!
    {
        //SceneManager.LoadScene("MainMenu");
        //time stuff
        TotalTimeScript.TotalTime = 240f;
        TimerSlider.TurnTimeValue = 65f;
        //time stuff

        DropDownScript.dropdownval = 0;

        //Difficulty stuff
        DifficultySlider.cloudOn=false;
        DifficultySlider.n = "Simple";
        DifficultySlider.diffi = 1;
        DifficultySlider.birdOn=false;
        DifficultySlider.HABOn=false;

        BirdManagerScript.cloudNum = 0;
        GreenBirdManagerScript.cloudNum = 0;
        HABManagerScript.cloudNum = 0;
        CloudManagerScript.cloudNum = 0;

        DifficultySlider.DifficultyValue = 1;
        //difficulty stuff

        //array stuff
    GameSceneStart.cardArray = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5 };
        GameSceneStart.cardPictureArray = new[] { "dog", "cat", "cow", "fish", "giraffe","horse", "pig", "zebra",
                                                        "pear", "apple", "banana", "kiwi", "orange", "pineapple", "strawberry", "watermelon",
                                                        "hammer", "wrench", "chainshaw", "drill", "screw", "brush", "pliers", "screwdriver",
                                                        "taxi", "bus", "bike", "car", "truck", "plane", "train","boat",
                                                        "sofa","bed","chair","table","lamp","carpet","coatrack","drawers"};
        //Resources.
        GameSceneStart.cardThemeArray = new[] { "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals",
                                                      "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit",
                                                      "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools",
                                                      "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport",
                                                      "Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture"};
        GameSceneStart.playerArray = new[] { 1, 1, 1, 1, 1, 1, 1, 1 };
        GameSceneStart.playerPictureArray = new[] { "dog", "cat", "cow", "fish", "giraffe", "horse", "pig", "zebra" };
        GameSceneStart.playerTheme = "Animals"; //dropdown value

        NewCardScript.mistakeCardList = new List<string>();
        NewCardScript.mistakeThemeList = new List<string>();
        //array stuff

    }


}

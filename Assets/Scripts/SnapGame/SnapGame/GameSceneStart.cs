using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameSceneStart : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PlayerCardProperties;
    public Text PlayerCard;
    public Text EnemyCard;

    public int PlayerID;
    public int EnemyID;
    public int CompScore = 0;
    public int PlayerScore = 0;

    public static int randomPCardnum;//random number to select random element from array
    public static int randomECardnum;
    public static int randomPlayernum; // Player deck

    //public static int[] cardArray = {​​​​ 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5 }​​​​;
    public static int[] cardArray = { 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5 };
    public static string[] cardPictureArray={ "dog", "cat", "cow", "fish", "giraffe","horse", "pig", "zebra",
                                                        "pear", "apple", "banana", "kiwi", "orange", "pineapple", "strawberry", "watermelon",
                                                        "hammer", "wrench", "chainshaw", "drill", "screw", "brush", "pliers", "screwdriver",
                                                        "taxi", "bus", "bike", "car", "truck", "plane", "train","boat",
                                                        "sofa","bed","chair","table","lamp","carpet","coatrack","drawers"};
    public static string[] cardThemeArray = { "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals",
                                                      "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit",
                                                      "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools",
                                                      "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport",
                                                      "Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture"};
    //public static int[] playerArray = {​​​​ 1, 1, 1, 1, 1, 1, 1, 1 }​​​​; //player deck
    public static int[] playerArray = { 1, 1, 1, 1, 1, 1, 1, 1 };
    public static string[] playerPictureArray = { "dog", "cat", "cow", "fish", "giraffe", "horse", "pig", "zebra" };
    public static string playerTheme = "Animals"; //dropdown value


    public void Start()
    {
        QualitySettings.vSyncCount = 1;
        if (DropDownScript.dropdownval == 0)
        {

            cardPictureArray = new[] { "dog", "cat", "cow", "fish", "giraffe","horse", "pig", "zebra",
                                                        "pear", "apple", "banana", "kiwi", "orange", "pineapple", "strawberry", "watermelon",
                                                        "hammer", "wrench", "chainshaw", "drill", "screw", "brush", "pliers", "screwdriver",
                                                        "taxi", "bus", "bike", "car", "truck", "plane", "train","boat",
                                                        "sofa","bed","chair","table","lamp","carpet","coatrack","drawers"};
            //Resources.
            cardThemeArray = new[] { "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals",
                                                      "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit",
                                                      "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools",
                                                      "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport",
                                                      "Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture"};

            playerPictureArray = new[] { "dog", "cat", "cow", "fish", "giraffe", "horse", "pig", "zebra" };
            playerTheme = "Animals"; //dropdown value

        }
        else if (DropDownScript.dropdownval == 1)
        {

            cardPictureArray = new[] {
                                                        "pear", "apple", "banana", "kiwi", "orange", "pineapple", "strawberry", "watermelon",
                                                        "dog", "cat", "cow", "fish", "giraffe","horse", "pig", "zebra",
                                                        "hammer", "wrench", "chainshaw", "drill", "screw", "brush", "pliers", "screwdriver",
                                                        "taxi", "bus", "bike", "car", "truck", "plane", "train","boat",
                                                        "sofa","bed","chair","table","lamp","carpet","coatrack","drawers"};
            //Resources.
            cardThemeArray = new[] {
                                                      "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit",
                                                      "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals",
                                                      "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools",
                                                      "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport",
                                                      "Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture"};

            playerPictureArray = new[] { "pear", "apple", "banana", "kiwi", "orange", "pineapple", "strawberry", "watermelon" };
            playerTheme = "Fruit"; //dropdown value
        }
        else if (DropDownScript.dropdownval == 3)
        {
            {

                cardPictureArray = new[] {
                                                        "hammer", "wrench", "chainshaw", "drill", "screw", "brush", "pliers", "screwdriver",
                                                        "pear", "apple", "banana", "kiwi", "orange", "pineapple", "strawberry", "watermelon",
                                                        "dog", "cat", "cow", "fish", "giraffe","horse", "pig", "zebra",
                                                        "taxi", "bus", "bike", "car", "truck", "plane", "train","boat",
                                                        "sofa","bed","chair","table","lamp","carpet","coatrack","drawers"};
                //Resources.
                cardThemeArray = new[] {              "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools",
                                                      "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit",
                                                      "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals",                                               
                                                      "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport",
                                                      "Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture"};

                playerPictureArray = new[] { "hammer", "wrench", "chainshaw", "drill", "screw", "brush", "pliers", "screwdriver" };
                playerTheme = "Tools"; //dropdown value

            }
        }
        else if (DropDownScript.dropdownval == 4)
        {

            cardPictureArray = new[] {                  "taxi", "bus", "bike", "car", "truck", "plane", "train","boat",
                                                        "pear", "apple", "banana", "kiwi", "orange", "pineapple", "strawberry", "watermelon",
                                                        "hammer", "wrench", "chainshaw", "drill", "screw", "brush", "pliers", "screwdriver",
                                                        "dog", "cat", "cow", "fish", "giraffe","horse", "pig", "zebra",
                                                        "sofa","bed","chair","table","lamp","carpet","coatrack","drawers"};
            //Resources.
            cardThemeArray = new[] {                  "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport",
                                                      "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit",
                                                      "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools",
                                                      "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals",
                                                      "Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture"};

            playerPictureArray = new[] { "taxi", "bus", "bike", "car", "truck", "plane", "train", "boat" };
            playerTheme = "Transport"; //dropdown value

        }
        else if (DropDownScript.dropdownval == 2)
        {
            Debug.Log("Hello! Ahhh!");
            cardPictureArray = new[] {                  "sofa","bed","chair","table","lamp","carpet","coatrack","drawers",
                                                        "pear", "apple", "banana", "kiwi", "orange", "pineapple", "strawberry", "watermelon",
                                                        "hammer", "wrench", "chainshaw", "drill", "screw", "brush", "pliers", "screwdriver",
                                                        "taxi", "bus", "bike", "car", "truck", "plane", "train","boat",
                                                         "dog", "cat", "cow", "fish", "giraffe","horse", "pig", "zebra"};
            //Resources.
            cardThemeArray = new[] {
                                                      "Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture","Furniture",
                                                      "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit", "Fruit",
                                                      "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools", "Tools",
                                                      "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport", "Transport",
                                                      "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals", "Animals",};

            playerPictureArray = new[] { "sofa", "bed", "chair", "table", "lamp", "carpet", "coatrack", "drawers"};
            playerTheme = "Furniture"; //dropdown value
        }
    }

   
    public void SetText(string text)
    {
        PlayerCard.text = text; //Trying to get text show on click??
        EnemyCard.text = text;
    }



    void Awake()
    {

        randomPCardnum = Random.Range(0, cardArray.Length);
        randomECardnum = Random.Range(0, cardArray.Length);

        randomPlayernum = Random.Range(0, playerArray.Length);



        NewCardScript.PlayerID = playerArray[randomPlayernum];
        NewCardScript.EnemyID = cardArray[randomECardnum]; //generate values for 

    }

}

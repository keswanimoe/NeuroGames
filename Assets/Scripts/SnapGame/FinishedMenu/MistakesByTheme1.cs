using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MistakesByTheme1 : MonoBehaviour
{
    public int Animals=0;
    public int Transport=0;
    public int Tools=0;
    public int Food=0;
    public int Furniture=0;

    public Text AniText;
    public Text TransText;
    public Text ToolsText;
    public Text FoodText;
    public Text FurniText;
    public Text PlayerDeckText;
    //public Text Theme5Text;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var x in NewCardScript.mistakeThemeList)
        {
            //Debug.Log(x.ToString());
        }

        for (int i = 0; i < NewCardScript.mistakeThemeList.Count; i++)
        {
            if (NewCardScript.mistakeThemeList[i] == "Animals")
            {
                Animals = Animals + 1;
            }

            else if (NewCardScript.mistakeThemeList[i] == "Transport")
            {
                Transport = Transport + 1;
            }

            else if (NewCardScript.mistakeThemeList[i] == "Tools")
            {
                Tools = Tools + 1;
            }

            else if (NewCardScript.mistakeThemeList[i] == "Fruit")
            {
                Food = Food + 1; //this is actually fruit!
            }

            else if (NewCardScript.mistakeThemeList[i] == "Furniture")
            {
                Furniture = Furniture + 1;
            }
        }

        AniText.text = Animals.ToString();
        TransText.text = Transport.ToString();
        ToolsText.text = Tools.ToString();
        FoodText.text = Food.ToString();
        FurniText.text = Furniture.ToString();
        PlayerDeckText.text = GameSceneStart.playerTheme;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

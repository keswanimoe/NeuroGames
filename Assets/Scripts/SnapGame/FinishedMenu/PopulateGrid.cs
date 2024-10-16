using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateGrid : MonoBehaviour
{
    public GameObject prefab;

    //public int numberToCreate = NewCardScript.mistakeCardList.Count;

    public int numberToCreate;

    public string array;

    // Start is called before the first frame update
    void Start()
    {
        numberToCreate = NewCardScript.mistakeCardList.Count; //will be NewCardScript.mistakeCardList.Count eventually
        Populate();

        //for (int i=0; i < numberToCreate; i++)
        //{
        print(string.Join("\n", NewCardScript.mistakeCardList));
        print(string.Join("\n", NewCardScript.mistakeThemeList));
        //}
    }

    // Update is called once per frame
    void Populate()
    {
        GameObject newObj;
        GameObject newObj2;
        for (int i = 0; i < (numberToCreate); i+=2)
        {

                if (string.Equals(NewCardScript.mistakeThemeList[i/2], GameSceneStart.playerTheme)) 
                {

                }
                else
                {
                    newObj = (GameObject)Instantiate(prefab, transform);
                    newObj2 = (GameObject)Instantiate(prefab, transform);
                    //for each i, change newObj.sprite to ith element of MistakesTheme from NewCardScript
                    newObj.GetComponent<Image>().sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/" + NewCardScript.mistakeCardList[i]);
                    newObj2.GetComponent<Image>().sprite = Resources.Load<Sprite>("ThemeImages/ThemePictures/" + NewCardScript.mistakeCardList[i+1]);
                }
         }

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;
using System;

public class ArrayScript : MonoBehaviour
{
    public static void jumblePArray() //generate random number for player card
    {
           
        // replace the element at index with the last element
        GameSceneStart.playerArray[GameSceneStart.randomPlayernum] = GameSceneStart.playerArray[GameSceneStart.playerArray.Length - 1]; //get rid of player element (player ID)
        Array.Resize(ref GameSceneStart.playerArray, GameSceneStart.playerArray.Length - 1);

        GameSceneStart.playerPictureArray[GameSceneStart.randomPlayernum] = GameSceneStart.playerPictureArray[GameSceneStart.playerPictureArray.Length - 1]; //get rid of player picture 
        Array.Resize(ref GameSceneStart.playerPictureArray, GameSceneStart.playerPictureArray.Length - 1);////////

        GameSceneStart.cardArray[GameSceneStart.randomECardnum] = GameSceneStart.cardArray[GameSceneStart.cardArray.Length - 1]; ///get rid of enemy element (enemy ID) (do we need this?/////////)
                // finally, let's decrement Array's size by one
        Array.Resize(ref GameSceneStart.cardArray, GameSceneStart.cardArray.Length - 1);



        GameSceneStart.cardThemeArray[GameSceneStart.randomECardnum] = GameSceneStart.cardThemeArray[GameSceneStart.cardThemeArray.Length - 1]; // get rid of enemy element
        // finally, let's decrement Array's size by one
        Array.Resize(ref GameSceneStart.cardThemeArray, GameSceneStart.cardThemeArray.Length - 1); ///is this needed?

Theme

        GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum] = GameSceneStart.cardPictureArray[GameSceneStart.cardPictureArray.Length - 1]; ///get rid of enemy picture (enemy picture array)
                // finally, let's decrement Array's size by one
        Array.Resize(ref GameSceneStart.cardPictureArray, GameSceneStart.cardPictureArray.Length - 1);/////////
    }

    public static void jumbleEArray() //generate random number for player card
    {
        // replace the element at index with the last element
        GameSceneStart.cardArray[GameSceneStart.randomECardnum] = GameSceneStart.cardArray[GameSceneStart.cardArray.Length - 1]; // get rid of enemy element
        // finally, let's decrement Array's size by one
        Array.Resize(ref GameSceneStart.cardArray, GameSceneStart.cardArray.Length - 1);

        GameSceneStart.cardThemeArray[GameSceneStart.randomECardnum] = GameSceneStart.cardThemeArray[GameSceneStart.cardThemeArray.Length - 1]; // get rid of enemy element
        // finally, let's decrement Array's size by one
        Array.Resize(ref GameSceneStart.cardThemeArray, GameSceneStart.cardThemeArray.Length - 1);

        GameSceneStart.cardPictureArray[GameSceneStart.randomECardnum] = GameSceneStart.cardPictureArray[GameSceneStart.cardPictureArray.Length - 1]; // get rid of enemy element
        // finally, let's decrement Array's size by one
        Array.Resize(ref GameSceneStart.cardPictureArray, GameSceneStart.cardPictureArray.Length - 1);
    }


}


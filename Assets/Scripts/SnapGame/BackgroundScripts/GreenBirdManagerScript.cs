using UnityEngine;
using System.Collections;

public class GreenBirdManagerScript : MonoBehaviour
{
    //Set this variable to your Cloud Prefab through the Inspector
    public GameObject birdPrefab;

    //Set this variable to how often you want the Cloud Manager to make clouds in seconds.
    //For Example, I have this set to 2
    public float delay;

    //If you ever need the clouds to stop spawning, set this variable to false, by doing: CloudManagerScript.spawnClouds = false;
    //public static bool spawnClouds = DifficultySlider.birdOn;

    public static int cloudNum = 0;

    // Use this for initialization
    void Start()
    {
        //Begin SpawnClouds Coroutine
        StartCoroutine(SpawnClouds());
    }

    IEnumerator SpawnClouds()
    {
        //This will always run
        while (DifficultySlider.birdOn == true)
        {

            if (cloudNum < 10)
            {
                //Instantiate Cloud Prefab and then wait for specified delay, and then repeat
                Instantiate(birdPrefab);
                yield return new WaitForSeconds(delay);
                cloudNum = cloudNum + 1;
            }
            else
            {
                DifficultySlider.birdOn = false;
            }

        }
    }
}

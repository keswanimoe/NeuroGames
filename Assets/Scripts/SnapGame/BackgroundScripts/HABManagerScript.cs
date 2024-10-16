using UnityEngine;
using System.Collections;

public class HABManagerScript : MonoBehaviour
{
    //Set this variable to your Cloud Prefab through the Inspector
    public GameObject HABPrefab;

    //Set this variable to how often you want the Cloud Manager to make clouds in seconds.
    //For Example, I have this set to 2
    public float delay;

    //If you ever need the clouds to stop spawning, set this variable to false, by doing: CloudManagerScript.spawnClouds = false;
    //public static bool spawnClouds = DifficultySlider.HABOn;

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
        while (DifficultySlider.HABOn == true)
        {

            if (cloudNum < 10)
            {
                //Instantiate Cloud Prefab and then wait for specified delay, and then repeat
                Instantiate(HABPrefab);
                yield return new WaitForSeconds(delay);
                cloudNum = cloudNum + 1;
            }
            else
            {
                DifficultySlider.HABOn = false;
            }

        }
    }
}

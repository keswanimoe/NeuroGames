using UnityEngine;
using System.Collections;

public class HABScript : MonoBehaviour
{
    //Set these variables to whatever you want the slowest and fastest speed for the clouds to be, through the inspector.
    //If you don't want clouds to have randomized speed, just set both of these to the same number.
    //For Example, I have these set to 2 and 5
    public float minSpeed;
    public float maxSpeed;

    //Set these variables to the lowest and highest y values you want clouds to spawn at.
    //For Example, I have these set to 1 and 4
    public float minX;
    public float maxX;

    //Set this variable to how far off screen you want the cloud to spawn, and how far off the screen you want the cloud to be for it to despawn. You probably want this value to be greater than or equal to half the width of your cloud.
    //For Example, I have this set to 4, which should be more than enough for any cloud.
    public float buffer;

    float speed;
    float camWidth;

    void Start()
    {
        if (DifficultySlider.HABOn == true)
        {
            //Set camWidth. Will be used later to check whether or not cloud is off screen.
            camWidth = 3000;

            //Set Cloud Movement Speed, and Position to random values within range defined above
            speed = Random.Range(minSpeed, maxSpeed);
            transform.position = new Vector3(Random.Range(minX, maxX), -1000, -100); //or z=20 for fading
        }

    }

    // Update is called once per frame
    void Update()
    {

        //Translates the cloud to the right at the speed that is selected
        //            transform.Translate(speed * Time.deltaTime, Mathf.Sin(100*speed * Time.deltaTime)* 1 / 4, 0); for birds
        transform.Translate(0, speed * Time.deltaTime, 0);
        //If cloud is off Screen, Destroy it.
        if (transform.position.y - buffer > camWidth)
        {
            //Destroy(gameObject);
            transform.position = new Vector3(Random.Range(minX, maxX), -1000, -100);
        }


    }
}
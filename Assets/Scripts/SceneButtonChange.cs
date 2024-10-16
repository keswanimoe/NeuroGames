using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonChange : MonoBehaviour
{
    public void GoToScene(string i)
    {

        SceneManager.LoadScene(i);
    }


}

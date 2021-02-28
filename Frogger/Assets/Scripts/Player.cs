using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int lives = 3;

    void Start()
    {
        //Get the number of lives stored from previous sessions
        //If the key doesn't exist, a value of 0 is returned
        lives = PlayerPrefs.GetInt("lives", 0);
        if (lives == 0)
            lives = 3;
    }


    void Check()
    {
        //Do your stuff here


        //Reduce lives
        lives--;

        //Save in PlayerPrefs, and COMMIT using PlayerPrefs.Save()
        PlayerPrefs.SetInt("lives", lives);
        PlayerPrefs.Save();

        //Reload level
        SceneManager.LoadScene("Menu");
    }

}

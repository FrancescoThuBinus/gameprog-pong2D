using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PostManager: MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                GetComponent<SceneManagement>().ChangeScene("Game");

            }
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                GetComponent<SceneManagement>().ChangeScene("GameAI");

            }
            if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                GetComponent<SceneManagement>().ChangeScene("GameAI2");

            }
        }

            // GetComponent<SceneManagement>().ChangeScene("Game");


        }


}



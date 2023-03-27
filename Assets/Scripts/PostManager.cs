using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class PostManager: MonoBehaviour
{

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<SceneManagement>().ChangeScene("Game");
        }

    }


}



using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerScoreL = 0;
    public int PlayerScoreR = 0;

    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;

    public static GameManager instance;
    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start() //isi nilai playerscore ke ui
    {
        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreR.text = PlayerScoreR.ToString();
    }



    public void ScoreCheck()
    {
        if (PlayerScoreL == 20)
        {
            Debug.Log("Pemain kiri menang");
            this.gameObject.SendMessage("ChangeScene", "MainMenu");
        }
        else if (PlayerScoreR == 20)
        {
            Debug.Log("Pemain kanan menang");
            this.gameObject.SendMessage("ChangeScene", "MainMenu");
        }
    }

    public void Score(string wallID)
    {
        if (wallID == "Line L")
        {
            //untuk score
            PlayerScoreR = PlayerScoreR + 1;
            txtPlayerScoreR.text = PlayerScoreR.ToString(); //UI + int
            ScoreCheck();
        }
        else
        {
            
            PlayerScoreL = PlayerScoreL + 1;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
            ScoreCheck();
        }
    }
}



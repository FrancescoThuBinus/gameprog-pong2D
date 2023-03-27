using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    private int waitingTime = 1;
    
    
    private IEnumerator WaitingTime(float seconds)
    {
            
            yield return new WaitForSeconds(seconds);
    
            this.gameObject.SendMessage("ChangeScene", "LeftPostGame");
        
    }

    private IEnumerator WaitingTimeR(float seconds)
    {
        //WinRCanvas.gameObject.SetActive(true);
        yield return new WaitForSeconds(seconds);

        this.gameObject.SendMessage("ChangeScene", "RightPostGame");

    }


    public int PlayerScoreL = 0;
    public int PlayerScoreR = 0;

    public Text txtPlayerScoreL;
    public Text txtPlayerScoreR;

    public static GameManager instance;
    [SerializeField] private Canvas pauseCanvas;
    private bool isPause;
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
        if (PlayerScoreL == 10)
        {
            StartCoroutine(WaitingTime(waitingTime));

            Debug.Log("Pemain kiri menang");
            
        }
        else if (PlayerScoreR == 10)
        {
            StartCoroutine(WaitingTimeR(waitingTime));
            Debug.Log("Pemain kanan menang");
            
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

    public void PauseGame()
    {
        if(isPause == false)
        {
            isPause = true;
            pauseCanvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {
        if (isPause == true)
        {
            isPause = false;
            pauseCanvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
    
    public void RestartGame()
    {
        GetComponent<SceneManagement>().ChangeScene("Game");
        Time.timeScale = 1;
    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

    }


}



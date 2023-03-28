using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SkinSelector : MonoBehaviour
{
    //public SpriteRenderer spriteRenderer;
    public static Color skinColor = Color.black;
    public static Color skinColor2 = Color.red;      
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject scoreColor;


    public void SetSkinColorRed()
    {
        skinColor = Color.red;
        skinColor2 = Color.red;
        //ChangeSkinColor();
        LoadOtherScene();
        Debug.Log("updatecolorberhasil");
    }

    public void SetSkinColorGreen()
    {
        skinColor = Color.green;
        skinColor2 = Color.green;
        //ChangeSkinColor();
        LoadOtherScene();
    }

    public void SetSkinColorBlue()
    {
        skinColor = Color.blue;
        skinColor2 = Color.blue;
        //ChangeSkinColor();
        LoadOtherScene();
    }
    public void SetSkinColorYellow()
    {
        skinColor = Color.yellow;
        skinColor2 = Color.yellow;
        //ChangeSkinColor();
        LoadOtherScene();
        Debug.Log("updatecolorberhasil");
    }
    public void SetSkinColorPink()
    {
        skinColor = Color.magenta;
        skinColor2 = Color.magenta;
        //ChangeSkinColor();
        LoadOtherScene();
        Debug.Log("updatecolorberhasil");
    }

    public void SetSkinColorBlack()
    {
        skinColor = Color.black;
        skinColor2 = Color.black;
        //ChangeSkinColor();
        LoadOtherScene();
        Debug.Log("updatecolorberhasil");
    }

    public void SetSkinColorWhite()
    {
        skinColor = Color.white;
        skinColor2 = Color.white;
        //ChangeSkinColor();
        LoadOtherScene();
        Debug.Log("updatecolorberhasil");
    }

    public void LoadOtherScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            SceneManager.LoadScene("GameAI", LoadSceneMode.Additive);
            Invoke("ChangeSkinColor", 0.1f);
        }
        if (SceneManager.GetActiveScene().buildIndex == 14)
        {
            SceneManager.LoadScene("GameAI2", LoadSceneMode.Additive);
            Invoke("ChangeSkinColor", 0.1f);
        }
        //SceneManager.LoadScene("OtherScene", LoadSceneMode.Additive);
        Invoke("ChangeSkinColor", 0.1f);
    }

    

    private void ChangeSkinColor()
    {
        //if (SceneManager.GetActiveScene().buildIndex == 12)
        //{
        //    SceneManager.LoadScene("GameAI");
        //}
        //if (SceneManager.GetActiveScene().buildIndex == 14)
        //{
        //    SceneManager.LoadScene("GameAI2");
        //}

        GameObject player = GameObject.FindWithTag("Player");
        //GameObject scoreColor = GameObject.FindWithTag("ScoreColor");

        NewSkinControl newskinControl = player.GetComponent<NewSkinControl>();
        //NewSkinControl new2skinControl = scoreColor.GetComponent<NewSkinControl>();
        newskinControl.UpdateSkinColor();
        //new2skinControl.UpdateSkinColor();
    }
}

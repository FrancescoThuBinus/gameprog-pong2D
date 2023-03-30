using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SkinSelector : MonoBehaviour
{
    //public SpriteRenderer spriteRenderer;
    public static Color skinColor = Color.black;
    public static Color skinColor2 = Color.red;      
    [SerializeField] private NewSkinControl playerSkin;
    [SerializeField] private NewSkinControl textSkin;
    [SerializeField] private GameObject scoreColor;


    public void SetSkinColorRed()
    {
        playerSkin.spriteRenderer.color = Color.red;
        textSkin.textColor.color = Color.red;
        skinColor2 = Color.red;
        PindahScene();

        Debug.Log("updatecolorberhasil");
    }

    public void SetSkinColorGreen()
    {
        Debug.Log("updatecolorberhasil");
        playerSkin.spriteRenderer.color = Color.green;
        textSkin.textColor.color = Color.green;
        skinColor2 = Color.green;
        Debug.Log("updatecolorberhasil");
        PindahScene();

    }

    public void SetSkinColorBlue()
    {
        Debug.Log("updatecolorberhasil");
        playerSkin.spriteRenderer.color = Color.cyan;
        textSkin.textColor.color = Color.cyan;
        skinColor2 = Color.blue;
        PindahScene();

    }
    public void SetSkinColorYellow()
    {
        playerSkin.spriteRenderer.color = Color.yellow;
        textSkin.textColor.color = Color.yellow;
        skinColor2 = Color.yellow;
        PindahScene();

        Debug.Log("updatecolorberhasil");
    }
    public void SetSkinColorPink()
    {
        playerSkin.spriteRenderer.color = Color.magenta;
        textSkin.textColor.color = Color.magenta;
        skinColor2 = Color.magenta;
        PindahScene();

        Debug.Log("updatecolorberhasil");
    }

    public void SetSkinColorBlack()
    {
        playerSkin.spriteRenderer.color = Color.black;
        textSkin.textColor.color = Color.black;
        skinColor2 = Color.black;
        PindahScene();

        Debug.Log("updatecolorberhasil");
    }

    public void SetSkinColorWhite()
    {
        playerSkin.spriteRenderer.color = Color.white;
        textSkin.textColor.color = Color.white;
        skinColor2 = Color.white;
        PindahScene();

        Debug.Log("updatecolorberhasil");
    }



    private void PindahScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            SceneManager.LoadScene("GameAI");
        }
        if (SceneManager.GetActiveScene().buildIndex == 14)
        {
            SceneManager.LoadScene("GameAI2");
        }
    }



    //private void ChangeSkinColor()
    //{


    //    GameObject player = GameObject.FindWithTag("Player");
    //    //GameObject scoreColor = GameObject.FindWithTag("ScoreColor");

    //    NewSkinControl newskinControl = player.GetComponent<NewSkinControl>();
    //    //NewSkinControl new2skinControl = scoreColor.GetComponent<NewSkinControl>();
    //    newskinControl.UpdateSkinColor();
    //    //new2skinControl.UpdateSkinColor();
    //}
}

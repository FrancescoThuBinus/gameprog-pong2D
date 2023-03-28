using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;

public class PlayerSkin : MonoBehaviour
{
    public GameObject[] playerSkin;
    public int selectedSkin = 0;
    //public Button[] skinButtons;
    //public string selectedSkinKey = "SelectedPlayerSkin";

    public void NextSkin()
    {
        Debug.Log("NextSkinWorks");
        playerSkin[selectedSkin].SetActive(false);
        selectedSkin = (selectedSkin + 1) % playerSkin.Length;
        playerSkin[selectedSkin].SetActive(true);
    }

    public void PreviousSkin()
    {
        Debug.Log("PreviousSkinWorks");
        playerSkin[selectedSkin].SetActive(false);
        selectedSkin--;
        if (selectedSkin < 0)
        {
            selectedSkin += playerSkin.Length;
        }
        playerSkin[selectedSkin].SetActive(true);
    }

    public void Starting()
    {
        PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        this.gameObject.SendMessage("ChangeScene", "Game");

    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


// This code is used for Popup of New Username WHEN New Player is clicked in Second Screen.
public class PopUpPlayerName : MonoBehaviour
{
    [SerializeField] GameObject PopupGameObject;
    private bool isImgOn = false;
    [SerializeField] public TMP_Text Player1ButtonText;
    private string inputString;

    void Start()
    {
        PopupGameObject.SetActive(false);
        isImgOn = false;

    }
    public void PopUpImageDisplay()
    {
        if (!isImgOn)
        {
            PopupGameObject.SetActive(true);
            isImgOn = true;
        }
        else
        {
            PopupGameObject.SetActive(false);
            isImgOn = false;
        }

    }

    // Get Text From Input Field When Save Button is Clicked
    public void getInputText(string s)
    {
        inputString = s;
        Debug.Log(inputString);
    }


    public void SetPlayerName()
    {
        //From the input Field get the text

        if (!string.IsNullOrEmpty(inputString))
        {
            Player1ButtonText.text = inputString;
            PopupGameObject.SetActive(false);
            isImgOn = false;
        }

    }
}

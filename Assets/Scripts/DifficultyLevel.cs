using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DifficultyLevel : MonoBehaviour
{
    [SerializeField] GameObject PopupGameObject;
    private bool isImgOn = false;
    [SerializeField] public TMP_Text DLText;

    void Start()
    {
        PopupGameObject.SetActive(false);
        isImgOn = false;

    }

    // When Difficulty Button is clicked. We get a Popup Listing DificultyLevels
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

    //Clicking easy button would change DL Text to Easy
    public void SetEasyLevel()
    {

        DLText.text = "Easy";

        //After the text is set the popup should disappear
        PopupGameObject.SetActive(false);
        isImgOn = false;

    }

    public void SetMediumLevel()
    {
        DLText.text = "Medium";

        //After the text is set the popup should disappear
        PopupGameObject.SetActive(false);
        isImgOn = false;

    }

    public void SetHardLevel()
    {
        DLText.text = "Hard";

        //After the text is set the popup should disappear
        PopupGameObject.SetActive(false);
        isImgOn = false;

    }

}

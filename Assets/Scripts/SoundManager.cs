using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

  

    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {   
        // We will check if the game has any audio settings from previous save file. If not we will set mute to false.

        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }

        AudioListener.pause = muted;
    }

    public void SoundOn()
    {
        if (muted)
        {
            muted = false;
            AudioListener.pause = false;
        }
        Save();
    }

    public void SoundOff()
    {
        if (!muted)
        {
            muted = true;
            AudioListener.pause = true;
        }
        Save();
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void Save()
    {
        PlayerPrefs.SetInt("muted",muted? 1: 0);
    }

}

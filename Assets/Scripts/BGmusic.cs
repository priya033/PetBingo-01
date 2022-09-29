using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * This code ensures that the Background Music plays through all the scenes
 **/
public class BGmusic : MonoBehaviour
{
    public static BGmusic instance;

    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
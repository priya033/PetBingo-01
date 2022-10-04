using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerToNextScene : MonoBehaviour
{
    //Scene will change after 3 seconds
    private float timer = 3f;
    
    // Update is called once per frame
    void Update()
    {
        //We are decreasing the timer here
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            //When the timer is done. We change the Scene to the next scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

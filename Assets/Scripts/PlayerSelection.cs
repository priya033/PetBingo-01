using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerSelection : MonoBehaviour
{

    // When Player1Button is clicked in the second Screen . It will take it to the third screen.
   public void Player1Button()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }



}

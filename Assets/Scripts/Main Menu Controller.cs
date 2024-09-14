using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    //Runs when "play" button pressed
   public void PlayGame()
    {
        Debug.Log("Button Pressed");
        SceneManager.LoadScene("Gameplay");
    }

    //Runs when "try again" or "play again" buttons prssed
    public void EnterMenu()
    {
        SceneManager.LoadScene("Main Menu");

    }


}

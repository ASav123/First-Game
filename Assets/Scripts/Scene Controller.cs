using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    //Runs when "play" button pressed
   public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    //Runs when "try again" or "play again" buttons prssed
    public void EnterMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    //Runs when player health reaches zero
    public void PlayerDeath()
    {
        SceneManager.LoadScene("Death Screen");
    }

    //Runs when player beats all three waves
    public void PayerWin()
    {
        SceneManager.LoadScene("Win Screen");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Menu
{

    // function activated on click of "play"
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");

    }
} //class

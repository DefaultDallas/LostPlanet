using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }

    
    public void OnQuitButton()
    {
        Application.Quit();
    }
}

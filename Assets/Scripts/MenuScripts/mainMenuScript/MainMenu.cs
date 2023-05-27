using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ToMap()
    {
        SceneManager.LoadScene(10);
    }

    public void ToStats()
    {
        SceneManager.LoadScene(9);
    }

    public void ReadMe()
    {
        SceneManager.LoadScene(3);
    }

    public void PlayvsAI()
    {
        SceneManager.LoadScene(11);
    }

    public void PlayStory()
    {
        SceneManager.LoadScene(6);
    }

    public void ToTutorial()
    {
        SceneManager.LoadScene(8);
    }

    public void ToOptions()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);

    }

    public void ToAchievements()
    {
        SceneManager.LoadScene(5);
    }


    public void VictoryP2()
    {
        SceneManager.LoadScene(8);
    }

    public void VictoryP1()
    {
        SceneManager.LoadScene(7);
    }
}

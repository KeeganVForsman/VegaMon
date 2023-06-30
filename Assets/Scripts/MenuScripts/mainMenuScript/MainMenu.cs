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

    public void PlayvsAIEasy()
    {
        SceneManager.LoadScene(11);
    }

    public void PlayvsAiHard()
    {
        SceneManager.LoadScene(12);
    }

    public void PlayvsMeduim()
    {
        SceneManager.LoadScene(13);
    }

    public void DiffSelect()
    {
        SceneManager.LoadScene(15);
    }

    public void PlayStory()
    {
        SceneManager.LoadScene(6);
    }

    public void ToTutorial()
    {
        SceneManager.LoadScene(4);
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

    public void Adventure()
    {
        SceneManager.LoadScene(17);
    }

    public void Ai_selection()
    {
        SceneManager.LoadScene(18);
    }

}

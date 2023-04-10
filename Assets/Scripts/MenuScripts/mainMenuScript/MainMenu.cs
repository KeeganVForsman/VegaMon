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

    public void ToPostMatch3()
    {
        SceneManager.LoadScene(10);
    }

    public void ToPostTennis()
    {
        SceneManager.LoadScene(11);
    }

    public void ToDio()
    {
        SceneManager.LoadScene(13);
    }

    public void ReadMe()
    {
        SceneManager.LoadScene(3);
    }


    public void PlayTennis()
    {
        SceneManager.LoadScene(5);
    }

    public void PlayMatch3()
    {
        SceneManager.LoadScene(2);
    }

    public void PlaySnake()
    {
        SceneManager.LoadScene(14);
    }

    public void ToPostArcade()
    {
        SceneManager.LoadScene(9);
    }

    public void PlayStory()
    {
        SceneManager.LoadScene(1);
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

    public void MeetPower()
    {
        SceneManager.LoadScene(16);
    }

    public void MeetDio()
    {
        SceneManager.LoadScene(13);
    }

    public void MeetItchi()
    {
        SceneManager.LoadScene(12);
    }
}

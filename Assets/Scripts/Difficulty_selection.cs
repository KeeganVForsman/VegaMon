using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty_selection : MonoBehaviour
{
    public enum DifficultyLevel { Easy, Meduim, Hard, }

    public DifficultyLevel level;

    public DifficultyLevel selectedDifficulty;


    public void OnbuttonClick()
    {
        string buttonName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        switch (buttonName)
        {
            case "EasyButton":
                selectedDifficulty = DifficultyLevel.Easy;
                break;
            case "MeduimButton":
                selectedDifficulty = DifficultyLevel.Meduim;
                break;
            case "HardButton":
                selectedDifficulty = DifficultyLevel.Hard;
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

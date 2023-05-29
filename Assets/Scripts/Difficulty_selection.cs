using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Difficulty_selection : MonoBehaviour
{
    public enum BattleStates2 { START, Player1, AI, WIN, LOSE, }
    public enum DifficultyLevel { Easy, Meduim, Hard, }

    public DifficultyLevel level;

    public DifficultyLevel selectedDifficulty;

    Button Easy;
    Button Meduim;
    Button Hard;

    public BattleStates2 states2;

    public void OnbuttonClick()
    {
        states2 = BattleStates2.Player1;
    }

    public void OnbuttonClick3()
    {
        states2 = BattleStates2.AI;
        Debug.Log("WHy");
    }

    // Start is called before the first frame update
    void Start()
    {
      /*  Easy = GetComponent<Button>();
        Meduim = GetComponent<Button>();
        Hard = GetComponent<Button>();
      */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* public void OnbuttonClick()
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
    } */
}

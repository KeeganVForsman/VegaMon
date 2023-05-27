using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AI_manager : MonoBehaviour
{
    public enum BattleStates2 { START, PLAYER_1, AI, WIN, LOSE, }
    public enum DifficultyLevel { Easy, Meduim, Hard, }

    public BattleStates2 states2;
    public DifficultyLevel level;
    public GameObject Player_1;
    public GameObject Ai;

    public DifficultyLevel selectedDifficulty;

    //Unit_Script Player_1Unit;
    Ai_creature Ai_Unit;
    Creature1 Player_1Unit;


    public Transform Player_1Spawn;
    public Transform Ai_Spawn;

    public Text Creature_1Name;
    public Text Ai_Name;
    public Text Dialogue;
    public Text Creature1CurrentHp;
    public Text Creature3CurrentHp;

    Button Pl_1Attack;
    Button Pl_1Heal;
    Button Pl_1Block;
    Button Pl_1Special;

    Button Ai_Special;
    Button Ai_Attack;
    Button Ai_Heal;
    Button Ai_Block;

    public int Player_1healCount = 0;
    public int Ai_healCount = 0;
    public int Player_1SpecialUse = 0;
    public int Ai_SpecialUse = 0;

    // Start is called before the first frame update

    void Start()
    {
        Pl_1Attack = GetComponent<Button>();
        Pl_1Heal = GetComponent<Button>();
        Pl_1Block = GetComponent<Button>();
        Pl_1Special = GetComponent<Button>();

        Ai_Special = GetComponent<Button>();
        Ai_Attack = GetComponent<Button>();
        Ai_Heal = GetComponent<Button>();
        Ai_Block = GetComponent<Button>();


        states2 = BattleStates2.START;
        startBattle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void startBattle()
    {
        GameObject Player_1Turn = Instantiate(Player_1, Player_1Spawn);
        Player_1Unit = Player_1Turn.GetComponent<Creature1>();

        GameObject Ai_Turn = Instantiate(Ai, Ai_Spawn);
        Ai_Unit = Ai_Turn.GetComponent<Ai_creature>();

        Creature_1Name.text = Player_1Unit.creature1Name;

        Ai_Name.text = Ai_Unit.creatureName;

        Dialogue.text = "Let the battle begin.";

        

        Who_Starts();
    }

    public int RandomNumber()
    {
        int New = Random.Range(1, 3);
        return New;
    }

    public void Player_1BattleTurn() //Displays message of who goes next
    {
        //Hide_P2_UI_Show_P1_UI();
        Dialogue.text = "Its Player 1's turn.... Please choose an action.";
    }

    public void Ai_BattleTurn() //Displays message of who goes next
    {
        //Hide_P1_UI_Show_P2_UI();
        Dialogue.text = "Its The Ai's turn.";
    }

    public void Who_Starts()
    {
        if (selectedDifficulty == DifficultyLevel.Easy)
        {
            states2 = BattleStates2.PLAYER_1;
            Player_1BattleTurn();
        }
       
        else if (selectedDifficulty == DifficultyLevel.Hard)
        {
            states2 = BattleStates2.AI;
            Ai_BattleTurn();
        }
        else if(selectedDifficulty == DifficultyLevel.Meduim)
        {
            if (RandomNumber() == 1)
            {
                states2 = BattleStates2.PLAYER_1;

                Player_1BattleTurn();
            }
            else
            {
                states2 = BattleStates2.AI;
                Ai_BattleTurn();
            }
        }
    }
    
    

}

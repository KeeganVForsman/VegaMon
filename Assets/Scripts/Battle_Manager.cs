using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleStates { START, PLAYER_1, PLAYER_2, WIN, LOSE, }

public class Battle_Manager : MonoBehaviour
{
    public BattleStates states;
    public GameObject Player_1;
    public GameObject Player_2;

    Unit_Script Player_1Unit;
    Unit_Script Player_2Unit;

    public Transform Player_1Spawn;
    public Transform Player_2Spawn;

    public Text Creature_1Name;
    public Text Creature_2Name;
    public Text Dialogue;

    // Start is called before the first frame update
    void Start()
    {
        states = BattleStates.START;
        startBattle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void startBattle()
    {
        GameObject Player_1Turn = Instantiate(Player_1, Player_1Spawn);
        Player_1Unit = Player_1Turn.GetComponent<Unit_Script>();

        GameObject Player_2Turn = Instantiate(Player_2, Player_2Spawn);
        Player_2Unit = Player_2Turn.GetComponent<Unit_Script>();

        Creature_1Name.text = Player_1Unit.creatureName;

        Creature_2Name.text = Player_2Unit.creatureName;

        Dialogue.text = "Let the battle begin.";

        states = BattleStates.PLAYER_1;
        Player_1BattleTurn();
    }

    public void RandomNumber()
    {

    }

    public void Player_1BattleTurn()
    {
        Dialogue.text = "Its Player 1's turn.... Please choose an action.";
    }
}

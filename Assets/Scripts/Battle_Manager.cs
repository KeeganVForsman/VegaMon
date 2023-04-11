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

    //Unit_Script Player_1Unit;
    Unit_Script Player_2Unit;
    Creature1 Player_1Unit;

    public Transform Player_1Spawn;
    public Transform Player_2Spawn;

    public Text Creature_1Name;
    public Text Creature_2Name;
    public Text Dialogue;
    public Text Creature1CurrentHp;
    public Text Creature2CurrentHp;

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
        Player_1Unit = Player_1Turn.GetComponent<Creature1>();

        GameObject Player_2Turn = Instantiate(Player_2, Player_2Spawn);
        Player_2Unit = Player_2Turn.GetComponent<Unit_Script>();

        Creature_1Name.text = Player_1Unit.creature1Name;

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

    public void Player_2BattleTurn()
    {
        Dialogue.text = "Its Player 2's turn.... Please choose an action.";
    }

    public void OnAttackPlayer_1Button()
    {
        if (states != BattleStates.PLAYER_1)
            return;
        else
        {
            Player_1BattleTurn();
            Player_1Attack();
            Debug.Log("it works");
        }
    }

    public void OnAttackPlayer_2Button()
    {
        if (states != BattleStates.PLAYER_2)
            return;
        else
        {
            Player_2BattleTurn();
            Player_2Attack();
            Debug.Log("it works again");
        }
    }

    public void Player_1Attack()
    {
        bool isDead = Player_2Unit.DamageTookC2(Player_1Unit.creature1Dmg);

        if (isDead)
        {
            states = BattleStates.WIN;
            BattleEndP1();
        }
        else
        {
            states = BattleStates.PLAYER_2;
        }
    }

    public void Player_2Attack()
    {
        bool isDead2 = Player_1Unit.DamageTook(Player_2Unit.creature2Dmg);

        if(isDead2)
        {
            states = BattleStates.WIN;
            BattleEndP2();
        }
        else
        {
            states = BattleStates.PLAYER_1;
        }
    }

    void BattleEndP1()
    {
        if (states == BattleStates.WIN)
        {
            Dialogue.text = "you win";
        }
        /* else if (states == BattleStates.LOSE)
        {
            Dialogue.text = "you lose";
        }*/
    }

    void BattleEndP2()
    {
        if (states == BattleStates.WIN)
        {
            Dialogue.text = "Player 2 won";
        }
       /* else if (states == BattleStates.LOSE)
        {
            Dialogue.text = "";
        }*/
    }

}

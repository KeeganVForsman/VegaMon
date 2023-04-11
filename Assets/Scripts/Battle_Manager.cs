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

    public void Player_1BattleTurn() //Displays message of who goes next
    {
        Dialogue.text = "Its Player 1's turn.... Please choose an action.";
    }

    public void Player_2BattleTurn() //Displays message of who goes next
    {
        Dialogue.text = "Its Player 2's turn.... Please choose an action.";
    }

    public void OnAttackPlayer_1Button() //Handels what happens if Player one presses the attack button on screen and checks if it is players turn to attack
    {
        if (states != BattleStates.PLAYER_1)
            return;
        else
        {
            Player_2BattleTurn();
            Player_1Attack();
            Debug.Log("it works");
        }
    }

    public void OnAttackPlayer_2Button() //Handels what happens if Player two presses the attack button on screen and checks if it is players turn to attack
    {
        if (states != BattleStates.PLAYER_2)
            return;
        else
        {
            Player_1BattleTurn();
            Player_2Attack();
            Debug.Log("it works again");
        }
    }

    public void Player_1Attack() // Checks to see if the player isdead otherwise it continues with the action of attacking
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

    public void Player_2Attack() // Checks to see if the player isdead otherwise it continues with the action of attacking
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
            Dialogue.text = "you win player 1";
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

    public void Player_1HealthRestored()
    {
        if (states != BattleStates.PLAYER_1)
            return;
        Player_1Unit.Player_1Heal(5);
        Dialogue.text = "Health potion used";

        states = BattleStates.PLAYER_2;
        Debug.Log("health works");
    }

    public void Player_2HealthRestored()
    {
        if (states != BattleStates.PLAYER_2)
            return;
        Player_2Unit.Player_2Heal(7);
        Dialogue.text = "Health potion used";
        Debug.Log("health works for me too");

        states = BattleStates.PLAYER_1;
    }

   /* public void SetHp(int Hp)
    {
       Creature1CurrentHp = creature1CurrentHp.ToString();
}*/

}

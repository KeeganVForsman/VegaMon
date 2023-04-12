using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    Button Pl_1Attack;
    Button Pl_1Heal;
    Button Pl_1Block;
    Button Pl_1Special;

    Button Pl_2Special;
    Button Pl_2Attack;
    Button Pl_2Heal;
    Button Pl_2Block;

    public int Player_1healCount = 0;
    public int Player_2healCount = 0;
    public int Player_1SpecialUse = 0;
    public int Player_2SpecialUse = 0;

    // Start is called before the first frame update
    void Start()
    {
        Pl_1Attack = GetComponent<Button>();
        Pl_1Heal = GetComponent<Button>();
        Pl_1Block = GetComponent<Button>();
        Pl_1Special = GetComponent<Button>();

        Pl_2Special = GetComponent<Button>();
        Pl_2Attack = GetComponent<Button>();
        Pl_2Heal = GetComponent<Button>();
        Pl_2Block = GetComponent<Button>();


        states = BattleStates.START;
        startBattle();
    }

    // Update is called once per frame
    void Update()
    {

    }
    



    public void Hide_P1_UI_Show_P2_UI()
    {
        Pl_1Attack.gameObject.SetActive(false);
        Pl_1Heal.gameObject.SetActive(false);
        Pl_1Block.gameObject.SetActive(false);
        Pl_1Special.gameObject.SetActive(false);

        Pl_1Special.gameObject.SetActive(true);
        Pl_2Attack.gameObject.SetActive(true);
        Pl_2Heal.gameObject.SetActive(true);
        Pl_2Block.gameObject.SetActive(true);
    }

    public void Hide_P2_UI_Show_P1_UI()
    {
        Pl_1Attack.gameObject.SetActive(true);
        Pl_1Heal.gameObject.SetActive(true);
        Pl_1Block.gameObject.SetActive(true);
        Pl_1Special.gameObject.SetActive(true);

        Pl_1Special.gameObject.SetActive(false);
        Pl_2Attack.gameObject.SetActive(false);
        Pl_2Heal.gameObject.SetActive(false);
        Pl_2Block.gameObject.SetActive(false);
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

        if(RandomNumber() == 1)
        {
            states = BattleStates.PLAYER_1;

            Player_1BattleTurn();
        }
        else
        {
            states = BattleStates.PLAYER_2;
            Player_2BattleTurn();
        }
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

    public void Player_2BattleTurn() //Displays message of who goes next
    {
        //Hide_P1_UI_Show_P2_UI();
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
        
        if (isDead2)
        {
            states = BattleStates.WIN;
            BattleEndP2();
        }
        else
        {
            states = BattleStates.PLAYER_1;
        }
    }

    void BattleEndP1() //Displays Texts that tells the player if they won or not
    {
        if (states == BattleStates.WIN)
        {
            //Dialogue.text = "you win player 1";
            SceneManager.LoadScene(7);
        }
    }

    void BattleEndP2()//Displays Texts that tells the player if they won or not
    {
        if (states == BattleStates.WIN)
        {
            //Dialogue.text = "Player 2 won";
            SceneManager.LoadScene(8);
        }
    }

    public void Player_1HealthRestored() //Used to restore health of the player and limits the amount of potions that can be used.
    {

        if (states != BattleStates.PLAYER_1)
            return;
        if (Player_1healCount < 3)
        {
            Player_1healCount++;
            Player_1Unit.Player_1Heal(5);
            Dialogue.text = "Health potion used";

            states = BattleStates.PLAYER_2;
            Debug.Log("health works");
        }
        else
        {
            Dialogue.text = "You have no potions.";
        }

    }

    public void Player_2HealthRestored()//Used to restore health of the player and limits the amount of potions that can be used.
    {
        if (states != BattleStates.PLAYER_2)
            return;
        if(Player_2healCount < 3)
        {
            Player_2healCount++;
            Player_2Unit.Player_2Heal(7);
            Dialogue.text = "Health potion used";
            Debug.Log("health works for me too");

            states = BattleStates.PLAYER_1;
        }
        else
        {
            Dialogue.text = "You have none potions.";
        }
    }

    public void Player_1Blocked()//Used to minus the damage that other players commit.
    {
        if (states != BattleStates.PLAYER_1)
            return;
        Player_1Unit.Blocked();

        Debug.Log("Pls let this work");

        states = BattleStates.PLAYER_2;
    }

    public void Player_2Blocked()//Used to minus the damage that other players commit.
    {
        if (states != BattleStates.PLAYER_2)
            return;
        Player_2Unit.BlockedP2();

        Debug.Log("This needs to work");

        states = BattleStates.PLAYER_1;
    }
   /* public void SetHp(int Hp)
    {
       Creature1CurrentHp = creature1CurrentHp.ToString();
}*/
     public void Player1_Special()//Handels the specials of the players.
    {
        if (states != BattleStates.PLAYER_1)
            return;
        if(Player_1SpecialUse < 2)
        {
            Player_1SpecialUse++;
            Player_2BattleTurn();
            Player_1Attack();
            HealthUltP1();
            Debug.Log("its special");

            states = BattleStates.PLAYER_2;
        }
        else
        {
            Dialogue.text = "No special Available.";
        }
    }

    public void HealthUltP1() // The same as the health execpt without the restrictions
    {
        Player_1Unit.Player_1Heal(7);
        Dialogue.text = "Health gained";
        Debug.Log("health alt works");
    }

    public void Player2_Special()//Handels the specials of the players.
    {

        if (states != BattleStates.PLAYER_2)
            return;
        if (Player_2SpecialUse < 2)
        {
            Player_2SpecialUse++;
            Player_1BattleTurn();
            Player_2Attack();
            Player_2Blocked();
            Debug.Log("its so special");

            states = BattleStates.PLAYER_1;
        }
        else
        {
            Dialogue.text = "No super Available.";
        }
    }

}

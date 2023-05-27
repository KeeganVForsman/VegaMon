using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum BattleStates2 { START, PLAYER_1, AI, WIN, LOSE, }

public class AI_Script : MonoBehaviour
{
    public BattleStates states;
    public GameObject Player_1;
    public GameObject Ai;


    //Unit_Script Player_1Unit;
    AI_Creature aI_Creature;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

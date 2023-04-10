using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleStates { START, PLAYER_1, PLAYER_2, WIN, LOSE, }

public class Battle_Manager : MonoBehaviour
{
    public BattleStates states;
    public GameObject Player_1;
    public GameObject Player_2;

    public Transform Player_1Spawn;
    public Transform Player_2Spawn;

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
        Instantiate(Player_1, Player_1Spawn);
        Instantiate(Player_2, Player_2Spawn);
    }
}

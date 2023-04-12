using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creature2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Text Player_2Hp;
    public string creature2Name;
    public int creature2Lvl;
    public int creature2CurrentHp;
    public int creature2Dmg;


    public bool DamageTookC2(int dmg)
    {
        creature2CurrentHp -= dmg;

        if (creature2CurrentHp <= 0)
            return true;
        else
            return false;
    }
}

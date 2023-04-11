using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string creature1Name;
    public int creature1Lvl;
    public int creature1CurrentHp;
    public int creature1Dmg;


    public bool DamageTook(int dmg)
    {
        creature1CurrentHp -= dmg;

        if (creature1CurrentHp <= 0)
            return true;
        else
            return false;
    }
}

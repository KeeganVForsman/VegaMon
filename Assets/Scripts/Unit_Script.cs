using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string creatureName;
    public int creatureLvl;
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

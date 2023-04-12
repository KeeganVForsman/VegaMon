using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    
    public Text Player_1Hp;
    public Text Creature1CurrentHp;
    public string creature1Name;
    public int creature1Lvl;
    public int creature1CurrentHp;
    public int creature1Dmg;
    public int creature1MaxHp;
    public bool isBlockingP1 = false;


    public bool DamageTook(int dmg)
    {
        if (isBlockingP1 == true)
        {
            dmg -= 5;
        }
            creature1CurrentHp -= dmg;
        //SetHpP1();

        //Player_1Hp.text = creature1CurrentHp.ToString();

            if (creature1CurrentHp <= 0)
                return true;
            else
                return false;
       /* creature1CurrentHp -= dmg;

        if (creature1CurrentHp <= 0)
            return true;
        else
            return false;*/
    }

    public void Player_1Heal(int Health)
    {
        creature1CurrentHp += Health;
        if (creature1CurrentHp > creature1MaxHp)
            creature1CurrentHp = creature1MaxHp;
        //SetHpP1();
    }

    public void SetHpP1()
    {
        
        Creature1CurrentHp.text = creature1CurrentHp.ToString();

    }

    public void Blocked()
    {
        isBlockingP1 = true;
    }

}

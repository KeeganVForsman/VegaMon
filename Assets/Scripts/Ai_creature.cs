using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ai_creature : MonoBehaviour
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
    public int creature3CurrentHp;
    public int creature3Dmg;
    public int creature3MaxHp;
    public bool isBlockingAi = false;

    public Slider HpSlider;



    public bool DamageTookC3(int dmg)
    {
        if (isBlockingAi == true)
        {
            dmg -= 5;
        }
        creature3CurrentHp -= dmg;

        if (creature3CurrentHp <= 0)
            return true;
        else
            return false;
    }

    public void Ai_Heal(int Health)
    {
        creature3CurrentHp += Health;
        if (creature3CurrentHp > creature3MaxHp)
            creature3CurrentHp = creature3MaxHp;
    }

    public void Ai_Blocked()
    {
        isBlockingAi = true;
    }
}

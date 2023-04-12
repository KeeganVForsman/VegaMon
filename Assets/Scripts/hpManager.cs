using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpManager : MonoBehaviour
{
    public Image healthBar;
    public int healthammount = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        healthammount -= damage;
        healthBar.fillAmount = healthammount / 100;
    }

}

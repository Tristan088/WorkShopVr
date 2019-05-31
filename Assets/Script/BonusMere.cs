using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusMere : MonoBehaviour
{
    public int ammos;
    public float timerBonus;
    protected float timerLeft;


    public void ActiveBonus()
    {

    }

    public void ShootBonus()
    {
        if(--ammos<=0)
        {
            GetRaketBack();
        }
        
    }

    public void GetRaketBack()
    {
        
    }
}

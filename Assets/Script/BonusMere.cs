using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusMere : MonoBehaviour
{
    public int ammos;
    public float timerBonus;
    protected float timerLeft;


    public virtual void ActiveBonus()
    {
        
    }

    public virtual void ShootBonus()
    {
        if(--ammos<=0)
        {
            GetRaketBack();
        }
        
    }

    public virtual void Active()
    {
        Debug.Log("BONUS MERE :  Active Bonus");
    }

    public virtual void GetRaketBack()
    {
        
    }
}



public class BonusRacket : BonusMere
{

}

public class BonusBall : BonusMere
{

}
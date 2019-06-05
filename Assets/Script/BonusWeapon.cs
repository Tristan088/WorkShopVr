using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusWeapon : BonusMere
{
    public override void Active()
    {
        base.Active();
        Debug.Log("Bonus Weapon :  Active Bonus");
    }
}
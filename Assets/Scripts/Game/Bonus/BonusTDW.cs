using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusTDW : MonoBehaviour,IBonuse
{
    public void Use()
    {
        EventBus.AOnAddTimeDurationWeapon.Invoke(0);
        ObjectsPool.Instanse.ReturnObject(this);
    }
}

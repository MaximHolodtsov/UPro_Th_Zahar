using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpeed : MonoBehaviour,IBonuse
{
    public void Use()
    {
        EventBus.AOnSpeedCharacter.Invoke(0);
        ObjectsPool.Instanse.ReturnObject(this);
    }
}

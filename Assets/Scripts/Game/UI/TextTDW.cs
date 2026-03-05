using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTDW : AbstractText
{
    
    void Update()
    {
        if (_text != null)
            _text.text = $"Bonus TDW: {EventBus.FOnAddTimeDurationWeapon.Invoke(0)}";
    }
}

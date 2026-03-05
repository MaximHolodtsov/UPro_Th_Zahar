using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Info",menuName ="Info/Bonus")]

public class BonusInfo : ScriptableObject
{
    [SerializeField]
    private Sprite _sprite;
    [SerializeField]
    private BonusType _bonusType;

    public Sprite Sprite { get => _sprite; }
    public BonusType bonusType { get => _bonusType; }
    
}
public enum BonusType
{
    Speed,
    TDW,
    TSW,
    TCE
}
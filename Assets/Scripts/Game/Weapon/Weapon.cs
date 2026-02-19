using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private InfoWeapon Infoweapon;

    public InfoWeapon Infoweapon1 { get => Infoweapon; set => Infoweapon = value; }

    public void Init()
    {

    }
}

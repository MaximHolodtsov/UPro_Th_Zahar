using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInit : MonoBehaviour
{
    private SpriteRenderer _sr;
    public void Init()
    {
        _sr = GetComponent<SpriteRenderer>();
        _sr.sprite = SaveCharacter.Instanse.CurrentCharacter.Character;
        GetComponent<CharacterMove>().Init();
        GetComponent<CharacterSettings>().Init(SaveCharacter.Instanse.CurrentCharacter.MaxHP);
    }
}

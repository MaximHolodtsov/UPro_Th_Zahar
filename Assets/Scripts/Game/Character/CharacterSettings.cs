using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSettings : MonoBehaviour
{
    private float _speedCharater = 1;
    private float _addTimeDuractionWeapon = 0;
    private float _addTimeSpeedWeapon = 1;
    private float _addTimeCreateEnemies = 0;
    private float _hp;



    public void Init(float HP)
    {
        EventBus.FOnSpeedCharacter += GetSpeed;
        EventBus.FOnAddTimeDurationWeapon += GetTBW;
        EventBus.FOnAddTimeSpeedWeapon += GetTSW;
        EventBus.FOnAddTimeSpeedWeapon += GetTCE;

        EventBus.AOnSpeedCharacter += AddSpeed;
        EventBus.AOnAddTimeDurationWeapon += AddTDW;
        EventBus.AOnAddTimeSpeedWeapon += AddTSW;
        EventBus.AOnAddTimeCreateEnemies += AddTCE;

        EventBus.AOnSubHPCharactre += SetHp;
        EventBus.FOnGetHPCharactre += GetHP;

        _hp = HP;
    }

    private void SetHp(float damage)
    {
        _hp -= damage;
        if (_hp <= 0)
            StartCoroutine(LoadScene());
    }
    private IEnumerator LoadScene()
    {
        yield return Load.Instanse.LoadScene(1);
    }

    private float GetHP(byte arg)
    {
        return _hp;
    }

    private void AddTCE(float obj)
    {
        _addTimeCreateEnemies += 0.1F;
    }

    private void AddTSW(float obj)
    {
        _addTimeDuractionWeapon += 0.1f;
    }

    private void AddTDW(float obj)
    {
        _addTimeDuractionWeapon += 0.1f;
    }

    private void AddSpeed(float obj)
    {
        _speedCharater += 0.1f;
    }

    private float GetTCE(byte arg)
    {
        return _addTimeCreateEnemies;
    }

    private float GetTSW(byte arg)
    {
        return _addTimeSpeedWeapon;
    }

    private float GetTBW(byte arg)
    {
        return _addTimeDuractionWeapon;
    }

    private float GetSpeed(byte arg)
    {
        return _speedCharater;
    }
    public void OnDestroy()
    {
        EventBus.FOnSpeedCharacter -= GetSpeed;
        EventBus.FOnAddTimeDurationWeapon -= GetTBW;
        EventBus.FOnAddTimeSpeedWeapon -= GetTSW;
        EventBus.FOnAddTimeSpeedWeapon -= GetTCE;

        EventBus.AOnSpeedCharacter -= AddSpeed;
        EventBus.AOnAddTimeDurationWeapon -= AddTDW;
        EventBus.AOnAddTimeSpeedWeapon -= AddTSW;
        EventBus.AOnAddTimeCreateEnemies -= AddTCE;

        EventBus.AOnSubHPCharactre -= SetHp;
        EventBus.FOnGetHPCharactre -= GetHP;
    }
}





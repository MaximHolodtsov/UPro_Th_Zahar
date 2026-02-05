using System;
using UnityEngine;

public class EventBus : MonoBehaviour
{
    public static Action<PanelDiscription> OnInfoCharacter; //static имеет посто€нно айди(т.к он всегда хранитс€ в оперативке)
    public static Action<InfoWeapon> OnAddWeapon;  //Action может передавать “ќЋ№ ќ параметры и ничего возращает
    public static Action<GameObject> OnWeaponDes;

    public static Action<float> AOnSubHPCharactre;
    public static Func<byte, float> FOnGetHPCharactre;

    public static Action<float> AOnSpeedCharacter;
    public static Action<float> AOnAddTimeDurationWeapon;
    public static Action<float> AOnAddTimeSpeedWeapon;
    public static Action<float> AOnAddTimeCreateEnemies;

    public static Func<byte, Vector2> OnControll; // Funk может передавать данные и 1 возращать(тот что написаный последним)
    public static Func<byte, Vector3> OnPositionCharacter;

    public static Func<byte, float> FOnSpeedCharacter;
    public static Func<byte, float> FOnAddTimeDurationWeapon;
    public static Func<byte, float> FOnAddTimeSpeedWeapon;
    public static Func<byte, float> FOnAddTimeCreateEnemies;
}



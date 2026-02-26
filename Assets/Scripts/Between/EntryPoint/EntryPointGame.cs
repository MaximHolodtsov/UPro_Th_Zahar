using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointGame : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefabCharacter;
    [SerializeField]
    private CameraMove _camera;
    [SerializeField]
    private Weapon _prefabWeapon;
    [SerializeField]
    private WeaponManager _weaponManager;





   private void Start()
    {
        GameObject Character = Instantiate(_prefabCharacter, Vector3.zero, Quaternion.identity);
        Character.GetComponent<CharacterInit>().Init();
        _camera.Init(Character.transform);
        ObjectsPool.Instanse.AddObjects(_prefabWeapon, 10);
        _weaponManager.Init(Character);
        EventBus.OnAddWeapon?.Invoke(SaveCharacter.Instanse.CurrentCharacter.PrefabWaepon);
    }

}
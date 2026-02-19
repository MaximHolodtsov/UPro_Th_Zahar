using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointGame : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefabCharacter;
    [SerializeField]
    private CameraMove _camera;





    private void Start()
    {
        GameObject Character = Instantiate(_prefabCharacter, Vector3.zero, Quaternion.identity);
        Character.GetComponent<CharacterInit>().Init();
        _camera.Init(Character.transform);
    }

}
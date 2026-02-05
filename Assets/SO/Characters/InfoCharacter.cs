using UnityEngine;

[CreateAssetMenu(fileName = "Info", menuName = "Info/Character")]
public class InfoCharacter : ScriptableObject
{
    [SerializeField]
    private Sprite _character;
    [SerializeField]
    private Sprite _baseWeapon;
    [SerializeField]
    private string _discription;
    [SerializeField]
    private InfoWeapon _prefabWaepon;
    [SerializeField]
    private float _maxHP;

    public Sprite Character { get => _character; }
    public Sprite BaseWeapon { get => _baseWeapon; }
    public string Discription { get => _discription; }
    public InfoWeapon PrefabWaepon { get => _prefabWaepon; }
    public float MaxHP { get => _maxHP; }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private InfoWeapon Infoweapon;
    private SpriteRenderer _spriteRenderer;
    private AbstractStrategyMoveWeapon _stategyMoveWeapon;

    public InfoWeapon Infoweapon1 { get => Infoweapon; set => Infoweapon = value; }

    public void Init()
    {
        Invoke(nameof(Despawn), Infoweapon.DespawnSec + EventBus.FOnAddTimeDurationWeapon.Invoke(0));

        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = Infoweapon.Weapon;

        Destroy(GetComponent<Collider2D>());
        PolygonCollider2D colider = gameObject.AddComponent<PolygonCollider2D>();
        colider.isTrigger = true;

        switch(Infoweapon.TypeWepaon)
        {
            case TypeWeapon.Sword:
                _stategyMoveWeapon = new MoveSword();
                break;
            case TypeWeapon.Book:
                _stategyMoveWeapon = new MoveBook();
                break;
            case TypeWeapon.Hammer:
                _stategyMoveWeapon = new MoveHumer();
                break;
            default:
                _stategyMoveWeapon = new MoveSword();
                break;

        }

        _stategyMoveWeapon.Init(GetComponent<Rigidbody2D>());
        EventBus.OnWeaponDes += CheckWeapon;
    }
    private void Update()
    {
        _stategyMoveWeapon.MoveWeapon();
    }
    private void CheckWeapon(GameObject obj)
    {
        if (obj == gameObject) Despawn();
    }
    private void Despawn()
    {
        ObjectsPool.Instanse.ReturnObject(this);
        EventBus.OnWeaponDes -= CheckWeapon;
    }
    private void OnDestroy()
    {
        EventBus.OnWeaponDes -= CheckWeapon;
    }
}

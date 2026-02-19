using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private Controll InputActions;
    private Vector2 oldTargeMove = Vector2.up;
    public void Init()
    {
        InputActions = new Controll();
        InputActions.Enable();
        rb = GetComponent<Rigidbody2D>();
        EventBus.OnControll += GetControll;
        EventBus.OnPositionCharacter += GetPositionCharacter;

    }

    private Vector3 GetPositionCharacter(byte arg)
    {
        return transform.position;
    }

    private Vector2 GetControll(byte arg)
    {
        if (InputActions.Character.Move.ReadValue<Vector2>() != Vector2.zero)
            oldTargeMove = InputActions.Character.Move.ReadValue<Vector2>();
        return oldTargeMove;
    }
    private void FixedUpdate()
    {
        rb.AddForce(InputActions.Character.Move.ReadValue<Vector2>() * EventBus.FOnSpeedCharacter.Invoke(0));
    }
    private void OnDestroy()
    {
        EventBus.OnControll -= GetControll;
        EventBus.OnPositionCharacter -= GetPositionCharacter;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCharacter : Singleton<SaveCharacter>
{
    [SerializeField]
    private InfoCharacter _currentCharacter;

    public InfoCharacter CurrentCharacter { get => _currentCharacter; } //это свойство которое может только вернуть то что написано в скобочках

    public void Init()
    {
        EventBus.OnInfoCharacter += SetCurrentCharacter; //подписка на событие 
    }

    private void SetCurrentCharacter(PanelDiscription panel) 
    {
        _currentCharacter = panel.Info; //передаём панель 
    }

    public override void OnDestroy()
    {
        base.OnDestroy();
        EventBus.OnInfoCharacter -= SetCurrentCharacter; //отписываемся
    }
}



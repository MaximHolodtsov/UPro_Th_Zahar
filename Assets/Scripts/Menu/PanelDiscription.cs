using UnityEngine;
using UnityEngine.UI;

public class PanelDiscription : MonoBehaviour
{
    InfoCharacter _info;

    public InfoCharacter Info { get => _info; }


    private void OnDestroy()
    {
        EventBus.OnInfoCharacter -= SetBackground;
    }

    public void Spawn(InfoCharacter character)
    {
        _info = character;

        transform.GetChild(0).GetComponent<Image>().sprite = _info.Character; 
        transform.GetChild(1).GetComponent<Localize>().LocalizationKey = _info.Discription;
        transform.GetChild(2).GetComponent<Image>().sprite = _info.BaseWeapon; 

        GetComponent<Button>().onClick.AddListener(() =>
        {
            EventBus.OnInfoCharacter?.Invoke(this); //проверка на подписку
        });

        GetComponent<RectTransform>().localScale = Vector3.one;
        GetComponent<RectTransform>().position = new Vector3(transform.position.x, transform.position.y, 0); //присваемваем позиции 
        EventBus.OnInfoCharacter += SetBackground; // подписка на событие 
    }

    private void SetBackground(PanelDiscription panel)
    {
        if (panel == this)
            transform.GetComponent<Image>().color = new Color(1f, 0.2394544f, 0f, 1); //если приходит не наша панель то меняем цвет
        else
            transform.GetComponent<Image>().color = new Color(0.4849057f, 0.797084f, 1f, 1); //если наша панель то цвет оставляем 
    }
}



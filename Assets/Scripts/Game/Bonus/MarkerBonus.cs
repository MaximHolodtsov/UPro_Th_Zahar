using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerBonus : MonoBehaviour
{
    [SerializeField]
    private List<BonusInfo> _listbonusInfo;
    public void Spawn(Transform position)
    {
        BonusInfo info = _listbonusInfo[Random.Range(0,_listbonusInfo.Count)];
        GetComponent<SpriteRenderer>().sprite = info.Sprite;
        switch (info.bonusType)
        {
            case BonusType.Speed:
                gameObject.AddComponent<BonusSpeed>();
                break;
            case BonusType.TCE:
                gameObject.AddComponent<BonusTCE>();
                break;
            case BonusType.TDW:
                gameObject.AddComponent<BonusTDW>();
                break;
            case BonusType.TSW:
                gameObject.AddComponent<BonusTSW>();
                break;
        }
        transform.position = position.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class AbstractText : MonoBehaviour
{
    protected TMP_Text _text;
    void Start()
    {
        _text = GetComponent<TMP_Text>();
    }




    }

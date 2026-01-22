using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointMenu : MonoBehaviour
{
    [SerializeField] private SetLanguageLocalization sll;
    private void Start()
    {
        CSVReader.LoadCSV();
        sll.Init();
    }
}

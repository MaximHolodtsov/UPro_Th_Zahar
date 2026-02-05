using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointMenu : MonoBehaviour
{
    [SerializeField] private PanelDiscription _prefabPanel;
    [SerializeField]
    private List<InfoCharacter> _characterList;
    [SerializeField] CreatePanelDiscription createPnaelDiscription;
    [SerializeField] private SetLanguageLocalization sll;
    private void Awake()
    {
        CSVReader.LoadCSV();
        sll.Init();
        ObjectsPool.Instanse.AddObjects<PanelDiscription>(_prefabPanel, 10);
        SaveCharacter.Instanse.Init();
        FindAnyObjectByType<SelectedPanelDiscription>().Init();
        createPnaelDiscription.Create(_characterList);
    }
}

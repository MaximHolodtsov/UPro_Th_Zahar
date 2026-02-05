using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoadGame : MonoBehaviour
{
    [SerializeField] private GameObject _panelMenu;
    [SerializeField] private GameObject panelLoad;
    [SerializeField] private Slider loadsSlider;
    [SerializeField] private Button button;
    private void Start()
    {
        button.onClick.AddListener(() =>
        {
            StartCoroutine(LoadScene());
            _panelMenu.SetActive(false);
            panelLoad.SetActive(true);

        });
    }
    private IEnumerator LoadScene()
    {
        StartCoroutine(Load.Instanse.LoadScene(2));
        while (Load.Instanse.load < 0.9f)
        {
            loadsSlider.value = Load.Instanse.load;
            yield return null;
        }
        loadsSlider.value = 1f;
    }
}


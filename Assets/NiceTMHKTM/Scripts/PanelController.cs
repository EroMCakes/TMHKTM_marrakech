using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class PanelController : MonoBehaviour
{
    [SerializeField]
    public GameObject[] englishPanelPrefabs, frenchPanelPrefabs, italianPanelPrefabs;

    [SerializeField]
    public GameObject[] frenchTargets, englishTargets, italianTargets;

    public string language = "english";

    [SerializeField]
    public GameObject mainCanvas;

    private void Awake()
    {
        ViewController.LoadViewWithIndex(0);
        englishTargets[1].SetActive(false);
        frenchTargets[1].SetActive(false);
        italianTargets[1].SetActive(false);
    }

    
}

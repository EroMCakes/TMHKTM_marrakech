using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class PanelController : MonoBehaviour
{
    [SerializeField]
    public GameObject[] englishPanelPrefabs, frenchPanelPrefabs;

    public string language = "english";

    [SerializeField]
    public GameObject mainCanvas;

    private void Awake()
    {
        ViewController.LoadViewWithIndex(0);
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    [SerializeField]
    GameObject[] panelPrefabs;

    [SerializeField]
    GameObject mainCanvas;

    private void Awake()
    {
        Instantiate(panelPrefabs[0]).transform.SetParent(mainCanvas.transform, false);
    }
}

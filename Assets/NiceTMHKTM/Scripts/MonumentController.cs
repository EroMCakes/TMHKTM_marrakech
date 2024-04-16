using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MonumentController : MonoBehaviour
{
    private PanelController panelController;
    // Start is called before the first frame update
    void Start()
    {
        panelController = GameObject.FindObjectOfType<PanelController>();
                Instantiate(panelController.englishTargets[0]);
    }
}

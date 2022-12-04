using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonumentController : MonoBehaviour
{
    private PanelController panelController;
    // Start is called before the first frame update
    void Start()
    {
        panelController = GameObject.FindObjectOfType<PanelController>();
        Instantiate(panelController.englishTargets[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

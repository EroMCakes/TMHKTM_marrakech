using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ViewController : MonoBehaviour {

    private PanelController panelController;
    
    public void LoadViewWithIndex(int viewIndex) {
        // Destroy(panelController.mainCanvas.transform.GetChild(0));
        Instantiate(panelController.panelPrefabs[viewIndex]).transform.SetParent(panelController.mainCanvas.transform, false);
    }
}
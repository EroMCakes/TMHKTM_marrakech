using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPanelController : MonoBehaviour
{
    [SerializeField]
    private Text[] colorDigits;

    private void Awake() {
        for (int index = 0; index < 4; index++) {
            if(!colorDigits[index].isEmpty()) colorDigits.text = "";
        }    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools; 


public class MuskPanelController : MonoBehaviour
{
    [SerializeField]
    private Text victim, position;

    private PanelController panelController;

    public void ResetCodeFields() {
        victim.text = "";
        position.text = "";
    }

    public void ValidateCodeFields() {
        if (victim.text == "Elon Musk" || victim.text == "elon musk" || victim.text == "ELON MUSK" || victim.text == "Elon musk") {
            if(position.text == "4") {
                ViewController.LoadViewWithIndex(12);
            } else {
                ResetCodeFields();
            }
        } else {
            ResetCodeFields();
        }
    }

public void LoadBackView() => ViewController.LoadViewWithIndex(10);

    // Start is called before the first frame update
    void Start()
    {
        panelController = GameObject.FindObjectOfType<PanelController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

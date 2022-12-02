using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class PortraitPadManager : MonoBehaviour
{
    [SerializeField]
    private Text codeField;

    public void EnterDigit(int enteredNumber) => codeField.text += enteredNumber.ToString();
    
    public void ResetCodeField() => codeField.text = "";

    public void ValidateCodeField() {
        if(codeField.text == "814") {
            ViewController.LoadViewWithIndex(10);
        } else {
            codeField.text = "";
        }
    }

    public void BackButton() {
        ViewController.LoadViewWithIndex(8);
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

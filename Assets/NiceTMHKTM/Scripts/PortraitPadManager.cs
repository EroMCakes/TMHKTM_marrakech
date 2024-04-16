using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class PortraitPadManager : MonoBehaviour
{
    [SerializeField]
    private Text codeField;

    public void EnterDigit(int enteredNumber) {
        if (codeField.text == "Insert code..." || codeField.text == "Entrez le Code..." || codeField.text == "Inserir il codice...") codeField.text = "";
        codeField.text += enteredNumber.ToString();
    }
    
    public void ResetCodeField() => codeField.text = "";

    public void ValidateCodeField() {
        if(codeField.text == "817") {
            ViewController.LoadViewWithIndex(10);
        } else {
            codeField.text = "EROR";
        }
    }

    public void BackButton() {
        ViewController.LoadViewWithIndex(8);
    }
}

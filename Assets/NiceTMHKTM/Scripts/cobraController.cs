using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class cobraController : MonoBehaviour
{
    [SerializeField]
    private Text inputField;

    private string inputCode;


    public void EnterLetterAs(string letter) {
        if (inputField.text == "Insert code..." || inputField.text == "Insérez le code...") {
            ResetStringCode();
        }
        inputCode += letter;
        inputField.text += letter;
    }

    public void BackSpace() {
        inputCode = inputCode.Remove(inputCode.Length - 1, 1);
        inputField.text = inputCode; 
    }

    public void ResetStringCode() {
        inputCode = "";
        inputField.text = "";
    }

    public void CodeValidation() {
        if (inputCode == "COBRA") {
            ViewController.LoadViewWithIndex(5);
        } else {
            ResetStringCode();
        }
    }
}

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

    private PanelController panelController;

    private void Start() {
        panelController = GameObject.FindObjectOfType<PanelController>();
    }


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
            Destroy(GameObject.Find("CobraTargets (Clone)"));
            if(panelController.language == "english") {
                Instantiate(panelController.englishTargets[1]);
            } else {
                Instantiate(panelController.frenchTargets[1]);
            }
            ViewController.LoadViewWithIndex(5);
        } else {
            ResetStringCode();
        }
    }
}

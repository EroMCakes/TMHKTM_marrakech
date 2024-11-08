using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class ColorPanelController : MonoBehaviour
{
    [SerializeField]
    private Text thousandsDigit, hundredsDigit, tensDigit, unitsDigit;

    private PanelController panelController;

    private int codeDigit = 0;
    private int code = 0;

    public void EnterDigitNumber(int enteredNumber) {
        if(codeDigit < 4) {
            switch (codeDigit)
            {
                case 0: {
                    code += enteredNumber * 1000;
                    thousandsDigit.text = enteredNumber.ToString();
                    codeDigit++;
                    break;
                }
                case 1: {
                    code += enteredNumber * 100;
                    hundredsDigit.text = enteredNumber.ToString();
                    codeDigit ++;
                    break;
                }
                case 2: {
                    code += enteredNumber * 10;
                    tensDigit.text = enteredNumber.ToString();
                    codeDigit++;
                    break;
                }
                case 3: {
                    code += enteredNumber;
                    unitsDigit.text = enteredNumber.ToString();
                    codeDigit++;
                    break;
                }
            }
        }
    }

    public void BackSpace() {
        if(codeDigit > 0)
        {
            switch (codeDigit) {
                case 4: {
                    code -= int.Parse(unitsDigit.text);
                    unitsDigit.text = "";
                    codeDigit--;
                    break;
                }
                case 3: {
                    code -= int.Parse(tensDigit.text) * 10;
                    tensDigit.text = "";
                    codeDigit--;
                    break;
                }
                case 2: {
                    code -= int.Parse(hundredsDigit.text) * 100;
                    hundredsDigit.text = "";
                    codeDigit--;
                    break;
                }
                case 1: {
                    code -= int.Parse(thousandsDigit.text) * 1000;
                    thousandsDigit.text = "";
                    codeDigit--;
                    break;
                }
            }
        }
    }

    public void ResetCode() {
        code = 0;
        thousandsDigit.text = "";
        hundredsDigit.text = "";
        tensDigit.text = "";
        unitsDigit.text = "";
        codeDigit = 0;
    }

    public void BackButton() {
        ViewController.LoadViewWithIndex(6);
    }

    public void ValidateColorCode() {
        //check code value and load next prefab
        if (code == 8569) {
            ViewController.LoadViewWithIndex(8);
        } else {
            ResetCode();
        }
    }
}

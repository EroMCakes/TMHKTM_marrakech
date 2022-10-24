using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ViewControllTools
{
    public class ViewController : MonoBehaviour
    {
        private static PanelController panelController;

        public static void LoadViewWithIndex(int viewIndex)
        {
            panelController = FindObjectOfType<PanelController>();
            var canvas = panelController.mainCanvas;
            if (canvas.transform.childCount > 0)
            {
                Destroy(canvas.transform.GetChild(0).gameObject);
            }
            if (panelController.language == "english")
            {
                Instantiate(panelController.englishPanelPrefabs[viewIndex])
                    .transform
                    .SetParent(canvas.transform, false);
            }
            else
            {
                Instantiate(panelController.frenchPanelPrefabs[viewIndex])
                    .transform
                    .SetParent(canvas.transform, false);
            }
        }

        public static void DestroyCurrentViewPanel()
        {
            panelController = FindObjectOfType<PanelController>();
            var canvas = panelController.mainCanvas;
            Destroy(canvas.transform.GetChild(0).gameObject);
        }

        public void SelectLanguage(string language)
        {
            panelController.language = language;
            DestroyCurrentViewPanel();
            LoadViewWithIndex(2);
        }
    }
}

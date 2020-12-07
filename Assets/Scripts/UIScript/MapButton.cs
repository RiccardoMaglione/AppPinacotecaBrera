using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapButton : MonoBehaviour
{
    public GameObject MapPanel;
    public Text[] TextButton;
    private void Start()
    {
        MapPanel.SetActive(false);
        for (int i = 0; i < TextButton.Length; i++)
        {
            if (TextButton[i] != null)
            {
                TextButton[i].text = "OPEN MAP";
            }
        }
    }
    public void GoToMap()
    {
        if (MapPanel.activeSelf == false)
        {
            MapPanel.SetActive(true);
            for (int i = 0; i < TextButton.Length; i++)
            {
                if(TextButton[i] != null)
                {
                    TextButton[i].text = "CLOSE MAP";
                }
            }
        }
        else
        {
            MapPanel.SetActive(false);
            for (int i = 0; i < TextButton.Length; i++)
            {
                if (TextButton[i] != null)
                {
                    TextButton[i].text = "OPEN MAP";
                }
            }
        }
    }
}

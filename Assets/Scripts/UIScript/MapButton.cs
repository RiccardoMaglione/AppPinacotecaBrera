using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapButton : MonoBehaviour
{
    public GameObject MapPanel;
    public Button[] ThisButton;
    public Sprite[] SpriteButton;
    private void Start()
    {
        MapPanel.SetActive(false);
        for (int i = 0; i < ThisButton.Length; i++)
        {
            if (ThisButton[i] != null)
            {
                ThisButton[i].GetComponent<Image>().sprite = SpriteButton[0];
            }
        }
    }
    public void GoToMap()
    {
        if (MapPanel.activeSelf == false)
        {
            MapPanel.SetActive(true);
            for (int i = 0; i < ThisButton.Length; i++)
            {
                if(ThisButton[i] != null)
                {
                    ThisButton[i].GetComponent<Image>().sprite = SpriteButton[1];
                }
            }
        }
        else
        {
            MapPanel.SetActive(false);
            for (int i = 0; i < ThisButton.Length; i++)
            {
                if (ThisButton[i] != null)
                {
                    ThisButton[i].GetComponent<Image>().sprite = SpriteButton[0];
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightButton : MonoBehaviour
{
    public GameObject Button;
    public Sprite ImgOn;
    public Sprite ImgOff;
    int Count = 0;

    public void ChangeImage()
    {
        if (Count == 0)
        {
            Button.GetComponent<Image>().sprite = ImgOn;
            Count++;
        }
        else
        {
            Button.GetComponent<Image>().sprite = ImgOff;
            Count = 0;
        }
    }
}

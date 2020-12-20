using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockPicture : MonoBehaviour
{
    public GameObject Picture1;
    public GameObject Picture2;
    public GameObject Picture3;

    public Sprite PictureSi1;
    public Sprite PictureSi2;
    public Sprite PictureSi3;
    public Sprite PictureNo1;
    public Sprite PictureNo2;
    public Sprite PictureNo3;

    void Update()
    {
        if (PlayerPrefs.GetInt("RingImage") == 0)
        {
            Picture1.GetComponent<Image>().sprite = PictureNo1;
        }
        if (PlayerPrefs.GetInt("LightImage") == 0)
        {
            Picture2.GetComponent<Image>().sprite = PictureNo2;
        }
        if (PlayerPrefs.GetInt("PuzzleImage") == 0)
        {
            Picture3.GetComponent<Image>().sprite = PictureNo3;
        }



        if (PlayerPrefs.GetInt("RingImage") == 1)
        {
            Picture1.GetComponent<Image>().sprite = PictureSi1;
        }
        if (PlayerPrefs.GetInt("LightImage") == 1)
        {
            Picture2.GetComponent<Image>().sprite = PictureSi2;
        }
        if (PlayerPrefs.GetInt("PuzzleImage") == 1)
        {
            Picture3.GetComponent<Image>().sprite = PictureSi3;
        }
    }
}
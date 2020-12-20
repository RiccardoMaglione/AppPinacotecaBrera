using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockBadge : MonoBehaviour
{
    public GameObject Badge1;
    public GameObject Badge2;

    public Sprite BadgeSi1;
    public Sprite BadgeSi2;
    public Sprite BadgeNo1;
    public Sprite BadgeNo2;

    void Update()
    {
        if (PlayerPrefs.GetInt("FirstBadge") == 0)
        {
            Badge1.GetComponent<Image>().sprite = BadgeNo1;
        }
        if (PlayerPrefs.GetInt("BadgeFinal") == 0)
        {
            Badge2.GetComponent<Image>().sprite = BadgeNo2;
        }
        if (PlayerPrefs.GetInt("FirstBadge") == 1)
        {
            Badge1.GetComponent<Image>().sprite = BadgeSi1;
        }
        if (PlayerPrefs.GetInt("BadgeFinal") == 1)
        {
            Badge2.GetComponent<Image>().sprite = BadgeSi2;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCameraGameplay : MonoBehaviour
{
    public GameObject[] PlayerSpot;
    public GameObject MapPanel;
    public static bool Warp1Active;
    public static bool Warp2Active;
    public static bool Warp3Active;

    void Update()
    {
        if(UIManager.Warp1 == true || Warp1Active == true)
        {
            UIManager.Warp1 = false;
            Warp1Active = false;
            for (int i = 0; i < PlayerSpot.Length; i++)
            {
                PlayerSpot[i].SetActive(false);
            }
            PlayerSpot[0].SetActive(true);
        }
        if (UIManager.Warp2 == true|| Warp2Active == true)
        {
            UIManager.Warp2 = false;
            Warp2Active = false;
            for (int i = 0; i < PlayerSpot.Length; i++)
            {
                PlayerSpot[i].SetActive(false);
            }
            PlayerSpot[1].SetActive(true);
        }
        if (UIManager.Warp3 == true || Warp3Active == true)
        {
            UIManager.Warp3 = false;
            Warp3Active = false;
            for (int i = 0; i < PlayerSpot.Length; i++)
            {
                PlayerSpot[i].SetActive(false);
            }
            PlayerSpot[2].SetActive(true);
        }
    }

    public void WarpPicture1()
    {
        Warp2Active = false;
        Warp3Active = false;
        Warp1Active = true;
        if (MapPanel != null)
        {
            if (MapPanel.activeSelf == true)
            {
                MapPanel.SetActive(false);
            }
        }
    }
    public void WarpPicture2()
    {
        Warp1Active = false;
        Warp3Active = false;
        Warp2Active = true;
        if (MapPanel != null)
        {
            if (MapPanel.activeSelf == true)
            {
                MapPanel.SetActive(false);
            }
        }
    }
    public void WarpPicture3()
    {
        Warp1Active = false;
        Warp2Active = false;
        Warp3Active = true;
        if (MapPanel != null)
        {
            if (MapPanel.activeSelf == true)
            {
                MapPanel.SetActive(false);
            }
        }
    }
}

﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    #region Variables
    public GameObject MenuPanel;
    public GameObject InfoPanel;
    public GameObject VisitPanel;
    public GameObject StatsPanel;
    public GameObject MapPanel;

    public GameObject ringsFullscreenPanel;
    public GameObject completedRingMinigamePanel;

    public GameObject kissFullscreenPanel;
    public GameObject completedKissMinigamePanel;

    public GameObject lightsFullscreenPanel;
    public GameObject completedLightMinigamePanel;

    public static UIManager instance;

    public static bool Warp1;
    public static bool Warp2;
    public static bool Warp3;

    
    #endregion

    void Awake()
    {
        if(instance== null)
        {
            instance = this;
        }
    }


    public void GoToPlay()
    {
        MenuPanel.SetActive(false);
        MapPanel.SetActive(true);
    }
    public void GoToInfo()
    {
        MenuPanel.SetActive(false);
        InfoPanel.SetActive(true);
    }
    public void GoToVisit()
    {
        MenuPanel.SetActive(false);
        VisitPanel.SetActive(true);
    }
    public void GoToStats()
    {
        MenuPanel.SetActive(false);
        StatsPanel.SetActive(true);
    }

    public void BackToMenu()
    {
        if (MapPanel != null)
        {
            if(MapPanel.activeSelf == true)
            {
                MapPanel.SetActive(false);
            }
        }
        if (InfoPanel != null)
        {
            if (InfoPanel.activeSelf == true)
            {
                InfoPanel.SetActive(false);
            }
        }
        if (VisitPanel != null)
        {
            if (VisitPanel.activeSelf == true)
            {
                VisitPanel.SetActive(false);
            }
        }
        if (StatsPanel != null)
        {
            if (StatsPanel.activeSelf == true)
            {
                StatsPanel.SetActive(false);
            }
        }

        MenuPanel.SetActive(true);
    }

    public void WarpPicture1()
    {
        Warp2 = false;
        Warp3 = false;
        Warp1 = true;
        SceneManager.LoadScene("BlockOut");
    }
    public void WarpPicture2()
    {
        Warp1 = false;
        Warp3 = false;
        Warp2 = true;
        SceneManager.LoadScene("BlockOut");
    }
    public void WarpPicture3()
    {
        Warp1 = false;
        Warp2 = false;
        Warp3 = true;
        SceneManager.LoadScene("BlockOut");
    }

    public void GoToCompletedRingsPanel()
    {
        ringsFullscreenPanel.SetActive(false);
        completedRingMinigamePanel.SetActive(true);
    }
    public void GoToFullscreenRingsPanel()
    {
        ringsFullscreenPanel.SetActive(true);
        completedRingMinigamePanel.SetActive(false);
    }

    public void GoToCompletedKissPanel()
    {
        kissFullscreenPanel.SetActive(false);
        completedKissMinigamePanel.SetActive(true);
    }
    public void GoToFullscreenKissPanel()
    {
        kissFullscreenPanel.SetActive(true);
        completedKissMinigamePanel.SetActive(false);
    }

    public void GoToCompletedLightPanel()
    {
        lightsFullscreenPanel.SetActive(false);
        completedLightMinigamePanel.SetActive(true);
    }
    public void GoToFullscreenLightPanel()
    {
        lightsFullscreenPanel.SetActive(true);
        completedLightMinigamePanel.SetActive(false);
    }
}

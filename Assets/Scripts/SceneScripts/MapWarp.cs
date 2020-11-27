using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapWarp : MonoBehaviour
{
    #region Variables
    public GameObject MenuPanel;
    public GameObject UnderMenuPanel;
    public GameObject ContactPanel;
    public GameObject HourPanel;
    public GameObject ArrivedPanel;
    public GameObject MapPanel;
    public GameObject OptionPanel;
    public GameObject InfoPanel;

    public static bool Warp1;
    public static bool Warp2;
    public static bool Warp3;

    bool CanOpen = true;
    int CountUnderMenu = 0;
    #endregion

    #region Method of Scene Menu
    /// <summary>
    /// Scena Menu
    /// Pulsante che disattiva il pannello menù e passa al pannello mappa
    /// alla scena di gioco
    /// </summary>
    public void GoToPlay()
    {
        MenuPanel.SetActive(false);
        MapPanel.SetActive(true);
    }
    /// <summary>
    /// Scena Menu
    /// Pulsante che disattiva  il pannello menù e passa al pannello opzioni
    /// alla scena di gioco
    /// </summary>
    public void GoToOption()
    {
        MenuPanel.SetActive(false);
        OptionPanel.SetActive(true);
    }

    public void GoToContact()
    {
        MenuPanel.SetActive(false);
        ContactPanel.SetActive(true);
    }

    public void GoToHour()
    {
        MenuPanel.SetActive(false);
        HourPanel.SetActive(true);
    }

    public void GoToArrived()
    {
        MenuPanel.SetActive(false);
        ArrivedPanel.SetActive(true);
    }
    public void GoToInfo()
    {
        MenuPanel.SetActive(false);
        InfoPanel.SetActive(true);
    }
    public void GoToUnderMenu()
    {
        UnderMenuPanel.SetActive(true);
    }
    public void BackUnderMenu()
    {
        UnderMenuPanel.SetActive(false);
    }

























    /// <summary>
    /// Scena Menu
    /// Metodo per tornare nel menu disattivando la schermata della mappa - Upgrade mettere tutte le schermate disattivate della scena corrispondente
    /// </summary>
    public void BackToMenu()
    {
        if(MapPanel != null)
        {
            if(MapPanel.activeSelf == true)
            {
                MapPanel.SetActive(false);
            }
        }
        if (OptionPanel != null)
        {
            if (OptionPanel.activeSelf == true)
            {
                OptionPanel.SetActive(false);
            }
        }
        if (ContactPanel != null)
        {
            if (ContactPanel.activeSelf == true)
            {
                ContactPanel.SetActive(false);
            }
        }
        if (HourPanel != null)
        {
            if (HourPanel.activeSelf == true)
            {
                HourPanel.SetActive(false);
            }
        }
        if (ArrivedPanel != null)
        {
            if (ArrivedPanel.activeSelf == true)
            {
                ArrivedPanel.SetActive(false);
            }
        }
        if (InfoPanel != null)
        {
            if (InfoPanel.activeSelf == true)
            {
                InfoPanel.SetActive(false);
            }
        }
        MenuPanel.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
    #endregion

    #region Method of Scene Gameplay
    public void GoToMapGameplay()
    {
        if(OptionPanel != null)
        {
            MenuPanel.SetActive(false);
        }
        if (MapPanel != null)
        {
            MapPanel.SetActive(true);
        }
    }

    public void BackToRoom()
    {
        if (MapPanel != null)
        {
            if(MapPanel.activeSelf == true)
            {
                MapPanel.SetActive(false);
            }
        }
        if (OptionPanel != null)
        {
            if (OptionPanel.activeSelf == true)
            {
                OptionPanel.SetActive(false);
            }
        }
        Time.timeScale = 1;
    }

    /// <summary>
    /// Scena Gameplay
    /// Metodo per tornare al gioco disattivando la schermata della mappa - Upgrade mettere tutte le schermate disattivate della scena corrispondente
    /// </summary>
    public void BackToPrincipalScreen()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
    #endregion

    #region Method of both scene
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

    #endregion
}

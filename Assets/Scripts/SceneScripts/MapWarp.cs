using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapWarp : MonoBehaviour
{
    #region Variables
    public GameObject MenuPanel;
    public GameObject MapPanel;
    public GameObject OptionPanel;

    public static bool Warp1;
    public static bool Warp2;
    public static bool Warp3;
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
        MenuPanel.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
    #endregion

    #region Method of Scene Gameplay
    /// <summary>
    /// Scena Gameplay
    /// Metodo per tornare al gioco disattivando la schermata della mappa - Upgrade mettere tutte le schermate disattivate della scena corrispondente
    /// </summary>
    public void BackToPlay()
    {
        MapPanel.SetActive(false);
        OptionPanel.SetActive(false);
        Time.timeScale = 1;
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

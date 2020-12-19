using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    #region Variables
    public GameObject MenuPanel;
    public GameObject InfoPanel;
    public GameObject VisitPanel;
    public GameObject StatsPanel;
    public GameObject MapPanel;

    public GameObject StatsInStatsPanel;
    public GameObject BadgePanel;
    public GameObject PaintingsPanel;

    public GameObject ringsFullscreenPanel;
    public GameObject completedRingMinigamePanel;

    public GameObject kissFullscreenPanel;
    public GameObject completedKissMinigamePanel;

    public GameObject lightsFullscreenPanel;
    public GameObject completedLightMinigamePanel;

    public GameObject itaPanel;
    public GameObject engPanel;

    public static UIManager instance;

    public GameObject inGameKissPanel;
    public GameObject storyPanel;

    public static bool Warp1;
    public static bool Warp2;
    public static bool Warp3;

    public GameObject Manina;
    #endregion

    void Awake()
    {
        if(instance== null)
        {
            instance = this;
        }

        //if (PlayerPrefs.GetInt("language", 0) == 1)
        //{
        //    itaPanel.SetActive(true);
        //    engPanel.SetActive(false);
        //}
        //
        //else
        //{
        //    itaPanel.SetActive(false);
        //    engPanel.SetActive(true);
        //}

        SaveStatusMinigame();
    }

    private void Start()
    {
        if (PlayerPrefs.GetInt("Puzzle") == 1)
        {
            GoToStoryPanel();
        }
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("Luca") == 1)
        {
            GoToCompletedRingsPanel();
        }

        //if (PlayerPrefs.GetInt("Puzzle") == 1)
        //{
        //    GoToStoryPanel();
        //}
        
        if (PlayerPrefs.GetInt("Light") == 1)
        {
            GoToCompletedLightPanel();
        }
    }

    public void ActiveHead()
    {
        Destroy(Manina);
    }

    public void GoToPlay()
    {
        PlayerPrefs.SetInt("BlockOut", 1);
        AudioManager.instance.Play("BottoneEnter");
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

    public void BackToStats()
    {
        if (BadgePanel != null)
        {
            if (BadgePanel.activeSelf == true)
            {
                BadgePanel.SetActive(false);
            }
        }
        if (PaintingsPanel != null)
        {
            if (PaintingsPanel.activeSelf == true)
            {
                PaintingsPanel.SetActive(false);
            }
        }

        StatsInStatsPanel.SetActive(true);
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
        if(ringsFullscreenPanel != null)
        {
            ringsFullscreenPanel.SetActive(false);
        }
        if (completedRingMinigamePanel != null)
        {
            completedRingMinigamePanel.SetActive(true);
        }
    }
    public void GoToFullscreenRingsPanel()
    {
        if(ringsFullscreenPanel != null)
        {
            ringsFullscreenPanel.SetActive(true);
        }
        if (completedRingMinigamePanel)
        {
            completedRingMinigamePanel.SetActive(false);
        }
    }
    public void GoToCompletedKissPanel()
    {
        if (kissFullscreenPanel != null)
        {
            kissFullscreenPanel.SetActive(false);
        }
        if (completedKissMinigamePanel != null)
        {
            completedKissMinigamePanel.SetActive(true);
        }
        if (storyPanel != null)
        {
            storyPanel.SetActive(false);
        }
    }
    public void GoToFullscreenKissPanel()
    {
        if(kissFullscreenPanel != null)
        {
            kissFullscreenPanel.SetActive(true);
        }
        if(storyPanel != null)
        {
            storyPanel.SetActive(false);
        }
        if (completedKissMinigamePanel != null)
        {
            completedKissMinigamePanel.SetActive(false);
        }
    }
    public void GoToCompletedLightPanel()
    {
        if(lightsFullscreenPanel != null)
        {
            lightsFullscreenPanel.SetActive(false);
        }
        if(completedLightMinigamePanel != null)
        {
            completedLightMinigamePanel.SetActive(true);
        }
    }
    public void GoToFullscreenLightPanel()
    {
        if (lightsFullscreenPanel != null)
        {
            lightsFullscreenPanel.SetActive(true);
        }
        if (completedLightMinigamePanel != null)
        {
            completedLightMinigamePanel.SetActive(false);
        }
    }
    public void SaveStatusMinigame()
    {
        int varRing = PlayerPrefs.GetInt("Luca");
        PlayerPrefs.SetInt("Luca", varRing);
        int varPuzzle = PlayerPrefs.GetInt("Puzzle");
        PlayerPrefs.SetInt("Puzzle", varPuzzle);
        int varLight = PlayerPrefs.GetInt("Light");
        PlayerPrefs.SetInt("Light", varLight);
    }
    public void GoToStoryPanel()
    {
        if (completedKissMinigamePanel != null)
        {
            completedKissMinigamePanel.SetActive(false);
        }
        if (kissFullscreenPanel != null)
        {
            kissFullscreenPanel.SetActive(false);
        }
        if (storyPanel != null)
        {
            storyPanel.SetActive(true);
        }
        if (inGameKissPanel != null)
        {
            inGameKissPanel.SetActive(false);
        }
    }
    public void GoToBadge()
    {
        StatsInStatsPanel.SetActive(false);
        BadgePanel.SetActive(true);
    }
    public void GoToQuadri()
    {
        StatsInStatsPanel.SetActive(false);
        PaintingsPanel.SetActive(true);
    }
    public void GoToEng()
    {
        itaPanel.SetActive(false);
        engPanel.SetActive(true);
    }
    public void GoToIta()
    {
        engPanel.SetActive(false);
        itaPanel.SetActive(true);
    }
}

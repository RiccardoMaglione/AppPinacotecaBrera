using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject MenuPanelGameplay;

    public static bool isContact = false;
    public static bool isHour = false;
    public static bool isArrived = false;
    public void GoToMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GoToMenuGameplay()
    {
        MenuPanelGameplay.SetActive(true);
    }
    public void BackMenuGameplay()
    {
        MenuPanelGameplay.SetActive(false);
    }
    public void GoToContactGameplay()
    {
        isContact = true;
        GoToMenuScene();
    }
    public void GoToHourGameplay()
    {
        isHour = true;
        GoToMenuScene();
    }
    public void GoToArrivedGameplay()
    {
        isArrived = true;
        GoToMenuScene();
    }
}

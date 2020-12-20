using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMGThird : MonoBehaviour
{
    public GameObject[] PiecesImages;
    public GameObject CompletePanel;
    public GameObject MiniGamePanel;
    public GameObject ButtonsPanel;
    public GameObject BackButton;

    private void Update()
    {
        if(PiecesImages[0].activeInHierarchy && PiecesImages[1].activeInHierarchy && PiecesImages[2].activeInHierarchy && PiecesImages[3].activeInHierarchy)
        {
            //PlayerPrefs.SetInt("", 1);
            PlayerPrefs.SetInt("Light", 1);
            PlayerPrefs.SetInt("LightDoor", 1);
            PlayerPrefs.SetInt("LightImage", 1);
            MiniGamePanel.SetActive(false);
            ButtonsPanel.SetActive(false);
            CompletePanel.SetActive(true);
            BackButton.SetActive(false);
        }
    }
    public void ButtonOne()
    {
        AudioManager.instance.Play("InterruttoreOn");
        if (PiecesImages[1].activeInHierarchy)
            PiecesImages[1].SetActive(false);
        else
            PiecesImages[1].SetActive(true);
        if (PiecesImages[2].activeInHierarchy)
            PiecesImages[2].SetActive(false);
        else
            PiecesImages[2].SetActive(true);
    }
    public void ButtonTwo()
    {
        AudioManager.instance.Play("InterruttoreOn");
        if (PiecesImages[0].activeInHierarchy)
            PiecesImages[0].SetActive(false);
        else
            PiecesImages[0].SetActive(true);
        if (PiecesImages[2].activeInHierarchy)
            PiecesImages[2].SetActive(false);
        else
            PiecesImages[2].SetActive(true);
    }
    public void ButtonThree()
    {
        AudioManager.instance.Play("InterruttoreOn");
        if (PiecesImages[0].activeInHierarchy)
            PiecesImages[0].SetActive(false);
        else
            PiecesImages[0].SetActive(true);
        if (PiecesImages[1].activeInHierarchy)
            PiecesImages[1].SetActive(false);
        else
            PiecesImages[1].SetActive(true);
        if (PiecesImages[3].activeInHierarchy)
            PiecesImages[3].SetActive(false);
        else
            PiecesImages[3].SetActive(true);
    }
    public void ButtonFour()
    {
        AudioManager.instance.Play("InterruttoreOn");
        if (PiecesImages[2].activeInHierarchy)
            PiecesImages[2].SetActive(false);
        else
            PiecesImages[2].SetActive(true);
        if (PiecesImages[3].activeInHierarchy)
            PiecesImages[3].SetActive(false);
        else
            PiecesImages[3].SetActive(true);
    }
}

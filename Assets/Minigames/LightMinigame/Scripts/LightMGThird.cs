using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMGThird : MonoBehaviour
{
    public GameObject[] PiecesImages;

    private void Update()
    {
        if(PiecesImages[0].activeInHierarchy && PiecesImages[1].activeInHierarchy && PiecesImages[2].activeInHierarchy && PiecesImages[3].activeInHierarchy)
        {
            PlayerPrefs.SetInt("Light", 1);
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

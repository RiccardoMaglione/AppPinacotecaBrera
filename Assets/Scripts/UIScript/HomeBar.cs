using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HomeBar : MonoBehaviour
{
    public GameObject Home;
    public GameObject EndValueActivate;
    public GameObject InfoButtonLeft;
    public GameObject WallpaperClose;
    public GameObject WallpaperOpen;

    public GameObject ArrowLeft;
    public GameObject ArrowRight;

    public float TranslateTimeActivate = 2;
    public float TranslateTimeDeactivate = 2;

    bool isActive = false;

    void Start()
    {
        Home.transform.position = new Vector3(-(EndValueActivate.transform.position.x * 425), Home.transform.position.y, Home.transform.position.z);
        if(InfoButtonLeft != null)
            InfoButtonLeft.SetActive(false);
        if (WallpaperOpen != null)
            WallpaperOpen.SetActive(false);
        if (ArrowLeft != null)
            ArrowLeft.SetActive(false);
        if (WallpaperClose != null)
            WallpaperClose.SetActive(true);
        if (ArrowRight != null)
            ArrowRight.SetActive(true);
    }


    public void SwipeHome()
    {
        if (isActive == false)
        {
            AudioManager.instance.Play("OpenTendina");
            ActiveHome();
        }
        else
        {
            
            DeactiveHome();
        }
    }

    public void ActiveHome()
    {
        Home.transform.DOMove(new Vector3(EndValueActivate.transform.position.x, Home.transform.position.y, Home.transform.position.z), TranslateTimeActivate);
        isActive = true;
        StartCoroutine(ActiveThings());
    }
    public void DeactiveHome()
    {
        AudioManager.instance.Play("CloseTendina");
        Home.transform.DOMove(new Vector3(-(EndValueActivate.transform.position.x * 425), Home.transform.position.y, Home.transform.position.z), TranslateTimeDeactivate);
        isActive = false;
        StartCoroutine(DeactiveThings());
    }

    IEnumerator ActiveThings()
    {
        yield return new WaitForSeconds(0);
        if(InfoButtonLeft != null)
            InfoButtonLeft.SetActive(true);
        if (WallpaperOpen != null)
            WallpaperOpen.SetActive(true);
        if (ArrowLeft != null)
            ArrowLeft.SetActive(true);
        if (WallpaperClose != null)
            WallpaperClose.SetActive(false);
        if (ArrowRight != null)
            ArrowRight.SetActive(true);
    }
    IEnumerator DeactiveThings()
    {
        yield return new WaitForSeconds(0);
        if(InfoButtonLeft != null)
            InfoButtonLeft.SetActive(false);
        if (WallpaperOpen != null)
            WallpaperOpen.SetActive(false);
        if (ArrowLeft != null)
            ArrowLeft.SetActive(false);
        if (WallpaperClose != null)
            WallpaperClose.SetActive(true);
        if (ArrowRight != null)
            ArrowRight.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HomeBar : MonoBehaviour
{
    public GameObject Home;
    public GameObject EndValueActivate;
    public GameObject InfoButtonLeft;
    public GameObject InfoButtonRight;
    public GameObject LineRightBlackDown;
    public GameObject LineLeftBlackDown;
    public float TranslateTimeActivate = 2;
    public float TranslateTimeDeactivate = 2;

    bool isActive = false;

    void Start()
    {
        Home.transform.position = new Vector3(-(EndValueActivate.transform.position.x * 425), Home.transform.position.y, Home.transform.position.z);
        if(InfoButtonLeft != null)
            InfoButtonLeft.SetActive(false);
        if (LineLeftBlackDown != null)
            LineLeftBlackDown.SetActive(false);
        if (InfoButtonRight != null)
            InfoButtonRight.SetActive(true);
        if (LineRightBlackDown != null)
            LineRightBlackDown.SetActive(true);
    }


    public void SwipeHome()
    {
        if (isActive == false)
        {
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
        Home.transform.DOMove(new Vector3(-(EndValueActivate.transform.position.x * 425), Home.transform.position.y, Home.transform.position.z), TranslateTimeDeactivate);
        isActive = false;
        StartCoroutine(DeactiveThings());
    }

    IEnumerator ActiveThings()
    {
        yield return new WaitForSeconds(TranslateTimeActivate);
        if(InfoButtonLeft != null)
            InfoButtonLeft.SetActive(true);
        if (LineLeftBlackDown != null)
            LineLeftBlackDown.SetActive(true);
        if (InfoButtonRight != null)
            InfoButtonRight.SetActive(false);
        if (LineRightBlackDown != null)
            LineRightBlackDown.SetActive(false);
    }
    IEnumerator DeactiveThings()
    {
        yield return new WaitForSeconds(TranslateTimeActivate);
        if(InfoButtonLeft != null)
            InfoButtonLeft.SetActive(false);
        if (LineLeftBlackDown != null)
            LineLeftBlackDown.SetActive(false);
        if (InfoButtonRight != null)
            InfoButtonRight.SetActive(true);
        if (LineRightBlackDown != null)
            LineRightBlackDown.SetActive(true);
    }
}

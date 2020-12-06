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
        InfoButtonLeft.SetActive(false);
        LineLeftBlackDown.SetActive(false);
        InfoButtonRight.SetActive(true);
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
        InfoButtonLeft.SetActive(true);
        LineLeftBlackDown.SetActive(true);
        InfoButtonRight.SetActive(false);
        LineRightBlackDown.SetActive(false);
    }
    IEnumerator DeactiveThings()
    {
        yield return new WaitForSeconds(TranslateTimeActivate);
        InfoButtonLeft.SetActive(false);
        LineLeftBlackDown.SetActive(false);
        InfoButtonRight.SetActive(true);
        LineRightBlackDown.SetActive(true);
    }
}

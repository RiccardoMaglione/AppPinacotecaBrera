using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingAnimation : MonoBehaviour
{
    [SerializeField]
    float time;

    [SerializeField]
    public LeanTweenType type;

    [SerializeField]
    float direction;

    public GameObject Manina;

    



    

    // Update is called once per frame
    void Update()
    {
        LeanTween.moveY(gameObject, direction, time).setEase(type);
        StartCoroutine(Late());                
    }

    IEnumerator Late()
    {
        yield return new WaitForSeconds(2f);
        if(Manina!=null)
        Manina.SetActive(true);
    }
}

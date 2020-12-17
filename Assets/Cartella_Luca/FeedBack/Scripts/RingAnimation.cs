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

    RaycastHit hit;
    Ray ray;



    

    // Update is called once per frame
    void Update()
    {
        LeanTween.moveY(gameObject, direction, time).setEase(type);
        StartCoroutine(Late());
                
    }

    IEnumerator Late()
    {
        yield return new WaitForSeconds(2f);
        Manina.SetActive(true);
    }
}

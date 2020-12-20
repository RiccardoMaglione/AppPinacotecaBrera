using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingAnimation2 : MonoBehaviour
{
    [SerializeField]
    float time;

    [SerializeField]
    public LeanTweenType type;

    [SerializeField]
    float direction;

    public GameObject Manina;

    public GameObject endpoint;



    

    // Update is called once per frame
    void Update()
    {
        LeanTween.moveY(gameObject, endpoint.transform.position.y , time).setEase(type);
        StartCoroutine(Late());
                
    }

    IEnumerator Late()
    {
        yield return new WaitForSeconds(2f);
        Manina.SetActive(true);
    }
}

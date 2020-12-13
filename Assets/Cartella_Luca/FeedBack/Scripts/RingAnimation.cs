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

  

    // Start is called before the first frame update
    void Start()
    {
              
    }

    // Update is called once per frame
    void Update()
    {
         LeanTween.moveY(gameObject, direction,time).setEase(type);  
    }
}

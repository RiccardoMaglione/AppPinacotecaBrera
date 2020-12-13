using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchIcon : MonoBehaviour
{
    
    [SerializeField]
    float time;
   
    [SerializeField]
    public LeanTweenType Secondtype;
  
    // Update is called once per frame
    void Update()
    {      
        LeanTween.scale(gameObject, new Vector3(3f, 3f, 1f), time).setEase(Secondtype);
                
    }

   
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScrollScale : MonoBehaviour
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
        LeanTween.scale(gameObject, new Vector3(0.9f,1.3f,1f), time).setEase(type);
        
    }

    
}

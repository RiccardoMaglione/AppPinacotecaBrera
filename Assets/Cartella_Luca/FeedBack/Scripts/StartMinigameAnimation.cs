using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMinigameAnimation : MonoBehaviour
{
    
    public GameObject Touch;

    [SerializeField]
    float time;

    [SerializeField]
    public LeanTweenType type;

    
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(gameObject, new Vector3(1f, 1f, 1f), time).setEase(type);
    }

    private void Update()
    {
        if(gameObject.transform.localScale.y >= 1f)
        {
            Touch.SetActive(true);
        }
    }


}

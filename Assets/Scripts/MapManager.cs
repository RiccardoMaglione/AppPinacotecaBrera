using UnityEngine;

public class MapManager : MonoBehaviour
{
    public GameObject button1;
    public GameObject button1Eng;
    public GameObject button2;
    public GameObject button2Eng;
    public GameObject button3;
    public GameObject button3Eng;

    void Awake()
    {
        //PlayerPrefs.SetInt("Ring", 0);
        //PlayerPrefs.SetInt("LightDoor", 0);
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("Ring", 0) < 1)
        {
            button1.SetActive(true);
            button1Eng.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Ring", 0) == 1)
        {
            button1.SetActive(true);
            button1Eng.SetActive(true);
            button2.SetActive(true);
            button2Eng.SetActive(true);
        }

        if (PlayerPrefs.GetInt("LightDoor", 0) == 1)
        {
            button1.SetActive(true);
            button1Eng.SetActive(true);
            button2.SetActive(true);
            button2Eng.SetActive(true);
            button3.SetActive(true);
            button3Eng.SetActive(true);           
        }
    }
}

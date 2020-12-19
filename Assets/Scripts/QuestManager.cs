using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static QuestManager instance;
    public GameObject button1;
    public GameObject button1Eng;
    public GameObject button2;
    public GameObject button2Eng;
    public GameObject button3;
    public GameObject button3Eng;
    public GameObject doorRing;
    public GameObject doorLight;
    public GameObject doorLight2;
    public GameObject doorLight3;
    public GameObject doorKiss;


    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("Quest") == 0)
        {
            button1.SetActive(true);
            button1Eng.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Quest") == 1)
        {
            button1.SetActive(true);
            button1Eng.SetActive(true);
            button2.SetActive(true);
            button2Eng.SetActive(true);
            doorRing.SetActive(true);
            doorLight.SetActive(true);
            doorLight2.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Quest") == 2)
        {
            button1.SetActive(true);
            button1Eng.SetActive(true);
            button2.SetActive(true);
            button2Eng.SetActive(true);
            button3.SetActive(true);
            button3Eng.SetActive(true);
            doorRing.SetActive(true);
            doorLight.SetActive(true);
            doorLight2.SetActive(true);
            doorLight3.SetActive(true);
            doorKiss.SetActive(true);
        }
    }
}

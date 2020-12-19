using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public GameObject doorRing;
    public GameObject doorLight1;
    public GameObject doorLight2;
    public GameObject doorLight3;
    public GameObject doorPuzzle;
    
    void Update()
    {
        if (PlayerPrefs.GetInt("Ring", 0) == 1)
        {
            doorRing.SetActive(true);
            doorLight1.SetActive(true);
            doorLight2.SetActive(true);
        }

        if (PlayerPrefs.GetInt("LightDoor", 0) == 1)
        {
            doorRing.SetActive(true);
            doorLight1.SetActive(true);
            doorLight2.SetActive(true);
            doorLight3.SetActive(true);
            doorPuzzle.SetActive(true);
        }
    }
}

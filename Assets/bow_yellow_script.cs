using UnityEngine;
using UnityEngine.UI;

public class BowYellowClothing : MonoBehaviour
{
    public Image bow_yellow_button;  
    public Sprite bow_yellow_0;
    public GameObject bow_yellow;

    private bool isWearing = false;

    void Start()
    {
        bow_yellow_button.sprite = bow_yellow_0;
        bow_yellow.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        bow_yellow.SetActive(isWearing); 
    }
}
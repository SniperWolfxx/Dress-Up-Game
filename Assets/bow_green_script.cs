using UnityEngine;
using UnityEngine.UI;

public class BowGreenClothing : MonoBehaviour
{
    public Image bow_green_button;  
    public Sprite bow_green_0;
    public GameObject bow_green;

    private bool isWearing = false;

    void Start()
    {
        bow_green_button.sprite = bow_green_0;
        bow_green.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        bow_green.SetActive(isWearing); 
    }
}
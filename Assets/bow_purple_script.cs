using UnityEngine;
using UnityEngine.UI;

public class BowPurpleClothing : MonoBehaviour
{
    public Image bow_purple_button;  
    public Sprite bow_purple_0;
    public GameObject bow_purple;

    private bool isWearing = false;

    void Start()
    {
        bow_purple_button.sprite = bow_purple_0;
        bow_purple.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        bow_purple.SetActive(isWearing); 
    }
}
using UnityEngine;
using UnityEngine.UI;

public class BowPinkClothing : MonoBehaviour
{
    public Image bow_pink_button;  
    public Sprite bow_pink_0;
    public GameObject bow_pink;

    private bool isWearing = false;

    void Start()
    {
        bow_pink_button.sprite = bow_pink_0;
        bow_pink.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        bow_pink.SetActive(isWearing); 
    }
}

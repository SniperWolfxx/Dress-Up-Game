using UnityEngine;
using UnityEngine.UI;

public class BowOrangeClothing : MonoBehaviour
{
    public Image bow_orange_button;  
    public Sprite bow_orange_0;
    public GameObject bow_orange;

    private bool isWearing = false;

    void Start()
    {
        bow_orange_button.sprite = bow_orange_0;
        bow_orange.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        bow_orange.SetActive(isWearing); 
    }
}
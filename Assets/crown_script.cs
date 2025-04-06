using UnityEngine;
using UnityEngine.UI;

public class CrownClothing : MonoBehaviour
{
    public Image crown_button;  
    public Sprite crown_0;  
    public GameObject crown;  

    private bool isWearing = false;

    void Start()
    {
        crown_button.sprite = crown_0; 
        crown.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        crown.SetActive(isWearing); 
    }
}


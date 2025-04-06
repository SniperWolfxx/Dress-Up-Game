using UnityEngine;
using UnityEngine.UI;

public class HatBlueClothing : MonoBehaviour
{
    public Image hat_blue_button;  
    public Sprite hat_blue_0;  
    public GameObject hat_blue;  

    private bool isWearing = false;

    void Start()
    {
        hat_blue_button.sprite = hat_blue_0; 
        hat_blue.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        hat_blue.SetActive(isWearing); 
    }
}


using UnityEngine;
using UnityEngine.UI;

public class HatGreenClothing : MonoBehaviour
{
    public Image hat_green_button;  
    public Sprite hat_green_0;
    public GameObject hat_green;

    private bool isWearing = false;

    void Start()
    {
        hat_green_button.sprite = hat_green_0;
        hat_green.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        hat_green.SetActive(isWearing); 
    }
}

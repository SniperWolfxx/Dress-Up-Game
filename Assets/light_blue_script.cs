using UnityEngine;
using UnityEngine.UI;

public class LightBlueBackground : MonoBehaviour
{
    public Image light_blue_button;  
    public Sprite light_blue_0;
    public GameObject light_blue;

    private bool isWearing = false;

    void Start()
    {
        light_blue_button.sprite = light_blue_0;
        light_blue.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        light_blue.SetActive(isWearing); 
    }
}
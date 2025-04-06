using UnityEngine;
using UnityEngine.UI;

public class HatPurpleClothing : MonoBehaviour
{
    public Image hat_purple_button;  
    public Sprite hat_purple_0;
    public GameObject hat_purple;

    private bool isWearing = false;

    void Start()
    {
        hat_purple_button.sprite = hat_purple_0;
        hat_purple.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        hat_purple.SetActive(isWearing); 
    }
}
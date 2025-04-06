using UnityEngine;
using UnityEngine.UI;

public class HatPinkClothing : MonoBehaviour
{
    public Image hat_pink_button;  
    public Sprite hat_pink_0;
    public GameObject hat_pink;

    private bool isWearing = false;

    void Start()
    {
        hat_pink_button.sprite = hat_pink_0;
        hat_pink.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        hat_pink.SetActive(isWearing); 
    }
}
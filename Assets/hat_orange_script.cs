using UnityEngine;
using UnityEngine.UI;

public class HatOrangeClothing : MonoBehaviour
{
    public Image hat_orange_button;  
    public Sprite hat_orange_0;
    public GameObject hat_orange;

    private bool isWearing = false;

    void Start()
    {
        hat_orange_button.sprite = hat_orange_0;
        hat_orange.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        hat_orange.SetActive(isWearing); 
    }
}

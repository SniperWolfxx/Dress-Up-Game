using UnityEngine;
using UnityEngine.UI;

public class HatYellowClothing : MonoBehaviour
{
    public Image hat_yellow_button;  
    public Sprite hat_yellow_0;
    public GameObject hat_yellow;

    private bool isWearing = false;

    void Start()
    {
        hat_yellow_button.sprite = hat_yellow_0;
        hat_yellow.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        hat_yellow.SetActive(isWearing); 
    }
}
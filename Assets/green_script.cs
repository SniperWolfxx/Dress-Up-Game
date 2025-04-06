using UnityEngine;
using UnityEngine.UI;

public class GreenBackground : MonoBehaviour
{
    public Image green_button;  
    public Sprite green_0;
    public GameObject green;

    private bool isWearing = false;

    void Start()
    {
        green_button.sprite = green_0;
        green.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        green.SetActive(isWearing); 
    }
}
using UnityEngine;
using UnityEngine.UI;

public class DarkBlueBackground : MonoBehaviour
{
    public Image dark_blue_button;  
    public Sprite dark_blue_0;
    public GameObject dark_blue;

    private bool isWearing = false;

    void Start()
    {
        dark_blue_button.sprite = dark_blue_0;
        dark_blue.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        dark_blue.SetActive(isWearing); 
    }
}
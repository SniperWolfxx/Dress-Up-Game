using UnityEngine;
using UnityEngine.UI;

public class PinkBackground : MonoBehaviour
{
    public Image pink_button;  
    public Sprite pink_0;
    public GameObject pink;

    private bool isWearing = false;

    void Start()
    {
        pink_button.sprite = pink_0;
        pink.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        pink.SetActive(isWearing); 
    }
}

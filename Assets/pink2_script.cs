using UnityEngine;
using UnityEngine.UI;

public class Pink2Background : MonoBehaviour
{
    public Image pink2_button;  
    public Sprite pink2_0;
    public GameObject pink2;

    private bool isWearing = false;

    void Start()
    {
        pink2_button.sprite = pink2_0;
        pink2.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        pink2.SetActive(isWearing); 
    }
}
using UnityEngine;
using UnityEngine.UI;

public class DotsEffect : MonoBehaviour
{
    public Image dots_button;  
    public Sprite dots_0;
    public GameObject dots;

    private bool isWearing = false;

    void Start()
    {
        dots_button.sprite = dots_0;
        dots.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        dots.SetActive(isWearing); 
    }
}
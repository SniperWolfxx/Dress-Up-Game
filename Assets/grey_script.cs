using UnityEngine;
using UnityEngine.UI;

public class GreyBackground : MonoBehaviour
{
    public Image grey_button;  
    public Sprite grey_0;
    public GameObject grey;

    private bool isWearing = false;

    void Start()
    {
        grey_button.sprite = grey_0;
        grey.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        grey.SetActive(isWearing); 
    }
}
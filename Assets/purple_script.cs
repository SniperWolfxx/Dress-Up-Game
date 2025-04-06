using UnityEngine;
using UnityEngine.UI;

public class PurpleBackground : MonoBehaviour
{
    public Image purple_button;  
    public Sprite purple_0;
    public GameObject purple;

    private bool isWearing = false;

    void Start()
    {
        purple_button.sprite = purple_0;
        purple.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        purple.SetActive(isWearing); 
    }
}
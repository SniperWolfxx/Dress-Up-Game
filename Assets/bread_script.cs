using UnityEngine;
using UnityEngine.UI;

public class BreadClothing : MonoBehaviour
{
    public Image bread_button;  
    public Sprite bread_0;  
    public GameObject bread;  

    private bool isWearing = false;

    void Start()
    {
        bread_button.sprite = bread_0; 
        bread.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        bread.SetActive(isWearing); 
    }
}
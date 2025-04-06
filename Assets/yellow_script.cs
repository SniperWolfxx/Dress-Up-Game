using UnityEngine;
using UnityEngine.UI;

public class YellowBackground : MonoBehaviour
{
    public Image yellow_button;  
    public Sprite yellow_0;
    public GameObject yellow;

    private bool isWearing = false;

    void Start()
    {
        yellow_button.sprite = yellow_0;
        yellow.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        yellow.SetActive(isWearing); 
    }
}
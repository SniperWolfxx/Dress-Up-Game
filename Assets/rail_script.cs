using UnityEngine;
using UnityEngine.UI;

public class RailBackground : MonoBehaviour
{
    public Image rail_button;  
    public Sprite rail_0;
    public GameObject rail;

    private bool isWearing = false;

    void Start()
    {
        rail_button.sprite = rail_0;
        rail.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        rail.SetActive(isWearing); 
    }
}
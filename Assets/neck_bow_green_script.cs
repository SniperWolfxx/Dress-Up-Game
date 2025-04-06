using UnityEngine;
using UnityEngine.UI;

public class NeckBowGreenClothing : MonoBehaviour
{
    public Image neck_bow_green_button;  
    public Sprite neck_bow_green_0;
    public GameObject neck_bow_green;

    private bool isWearing = false;

    void Start()
    {
        neck_bow_green_button.sprite = neck_bow_green_0;
        neck_bow_green.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        neck_bow_green.SetActive(isWearing); 
    }
}

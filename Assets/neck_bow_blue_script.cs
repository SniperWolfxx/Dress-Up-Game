using UnityEngine;
using UnityEngine.UI;

public class NeckBowBlueClothing : MonoBehaviour
{
    public Image neck_bow_blue_button;  
    public Sprite neck_bow_blue_0;
    public GameObject neck_bow_blue;

    private bool isWearing = false;

    void Start()
    {
        neck_bow_blue_button.sprite = neck_bow_blue_0;
        neck_bow_blue.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        neck_bow_blue.SetActive(isWearing); 
    }
}
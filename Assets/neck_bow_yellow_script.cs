using UnityEngine;
using UnityEngine.UI;

public class NeckBowYellowClothing : MonoBehaviour
{
    public Image neck_bow_yellow_button;  
    public Sprite neck_bow_yellow_0;
    public GameObject neck_bow_yellow;

    private bool isWearing = false;

    void Start()
    {
        neck_bow_yellow_button.sprite = neck_bow_yellow_0;
        neck_bow_yellow.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        neck_bow_yellow.SetActive(isWearing); 
    }
}

using UnityEngine;
using UnityEngine.UI;

public class NeckBowOrangeClothing : MonoBehaviour
{
    public Image neck_bow_orange_button;  
    public Sprite neck_bow_orange_0;
    public GameObject neck_bow_orange;

    private bool isWearing = false;

    void Start()
    {
        neck_bow_orange_button.sprite = neck_bow_orange_0;
        neck_bow_orange.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        neck_bow_orange.SetActive(isWearing); 
    }
}

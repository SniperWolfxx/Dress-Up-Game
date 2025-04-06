using UnityEngine;
using UnityEngine.UI;

public class NeckBowPurpleClothing : MonoBehaviour
{
    public Image neck_bow_purple_button;  
    public Sprite neck_bow_purple_0;
    public GameObject neck_bow_purple;

    private bool isWearing = false;

    void Start()
    {
        neck_bow_purple_button.sprite = neck_bow_purple_0;
        neck_bow_purple.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        neck_bow_purple.SetActive(isWearing); 
    }
}

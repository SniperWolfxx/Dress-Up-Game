using UnityEngine;
using UnityEngine.UI;

public class NeckBowPinkClothing : MonoBehaviour
{
    public Image neck_bow_pink_button;  
    public Sprite neck_bow_pink_0;
    public GameObject neck_bow_pink;

    private bool isWearing = false;

    void Start()
    {
        neck_bow_pink_button.sprite = neck_bow_pink_0;
        neck_bow_pink.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        neck_bow_pink.SetActive(isWearing); 
    }
}

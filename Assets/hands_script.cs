using UnityEngine;
using UnityEngine.UI;

public class HandsClothing : MonoBehaviour
{
    public Image hands_button;  
    public Sprite hands_0;
    public GameObject hands;

    private bool isWearing = false;

    void Start()
    {
        hands_button.sprite = hands_0;
        hands.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        hands.SetActive(isWearing); 
    }
}

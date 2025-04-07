using UnityEngine;
using UnityEngine.UI;

public class StarsEffect : MonoBehaviour
{
    public Image stars_button;  
    public Sprite stars_0;
    public GameObject stars;

    private bool isWearing = false;

    void Start()
    {
        stars_button.sprite = stars_0;
        stars.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        stars.SetActive(isWearing); 
    }
}
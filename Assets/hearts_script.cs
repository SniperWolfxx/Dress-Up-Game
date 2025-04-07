using UnityEngine;
using UnityEngine.UI;

public class HeartsEffect : MonoBehaviour
{
    public Image hearts_button;  
    public Sprite hearts_0;
    public GameObject hearts;

    private bool isWearing = false;

    void Start()
    {
        hearts_button.sprite = hearts_0;
        hearts.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        hearts.SetActive(isWearing); 
    }
}
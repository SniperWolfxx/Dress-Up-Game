using UnityEngine;
using UnityEngine.UI;

public class DiamondsEffect : MonoBehaviour
{
    public Image diamonds_button;  
    public Sprite diamonds_0;
    public GameObject diamonds;

    private bool isWearing = false;

    void Start()
    {
        diamonds_button.sprite = diamonds_0;
        diamonds.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        diamonds.SetActive(isWearing); 
    }
}
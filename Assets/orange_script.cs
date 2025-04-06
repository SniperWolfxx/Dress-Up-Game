using UnityEngine;
using UnityEngine.UI;

public class OrangeBackground : MonoBehaviour
{
    public Image orange_button;  
    public Sprite orange_0;
    public GameObject orange;

    private bool isWearing = false;

    void Start()
    {
        orange_button.sprite = orange_0;
        orange.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        orange.SetActive(isWearing); 
    }
}

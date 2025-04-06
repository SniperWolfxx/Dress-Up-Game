using UnityEngine;
using UnityEngine.UI;

public class SakuraClothing : MonoBehaviour
{
    public Image sakura_button;  
    public Sprite sakura_0;  
    public GameObject sakura;  

    private bool isWearing = false;

    void Start()
    {
        sakura_button.sprite = sakura_0; 
        sakura.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        sakura.SetActive(isWearing); 
    }
}
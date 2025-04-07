using UnityEngine;
using UnityEngine.UI;

public class FullSquareBackground : MonoBehaviour
{
    public Image full_square_button;  
    public Sprite full_square_0;
    public GameObject full_square;

    private bool isWearing = false;

    void Start()
    {
        full_square_button.sprite = full_square_0;
        full_square.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        full_square.SetActive(isWearing); 
    }
}

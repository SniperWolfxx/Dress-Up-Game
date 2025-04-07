using UnityEngine;
using UnityEngine.UI;

public class SquareBackground : MonoBehaviour
{
    public Image square_button;  
    public Sprite square_0;
    public GameObject square;

    private bool isWearing = false;

    void Start()
    {
        square_button.sprite = square_0;
        square.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        square.SetActive(isWearing); 
    }
}
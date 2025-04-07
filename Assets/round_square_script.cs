using UnityEngine;
using UnityEngine.UI;

public class RoundSquareBackground : MonoBehaviour
{
    public Image round_square_button;  
    public Sprite round_square_0;
    public GameObject round_square;

    private bool isWearing = false;

    void Start()
    {
        round_square_button.sprite = round_square_0;
        round_square.SetActive(false); 
    }

    public void ToggleClothing()
    {
        isWearing = !isWearing; 
        round_square.SetActive(isWearing); 
    }
}
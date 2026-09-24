using UnityEngine.UI;
using UnityEngine;

public class Aura : MonoBehaviour
{
    public Camera ViewModeeel;
    public Score Coins;
    public PlayerController Controlllller;
    public Image AuraImage;


    void Start()
    {
        
    }

    void Update()
    {
        if (Coins.Count >= 3 && Input.GetKey(KeyCode.V))
        {
            UseAura();
        }
    }

    private void UseAura()
    {
        Controlllller.speed = 10;
        ViewModeeel.fieldOfView = 80;
        Coins.Count -= 3;
    }
}

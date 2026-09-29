using UnityEngine.UI;
using UnityEngine;

public class Aura : MonoBehaviour
{
    public Camera ViewModeeel;
    public Score Coins;
    public PlayerController Controlllller;
    public Image AuraImage;
    public Image AuraBG;


    void Start()
    {
        
    }

    void Update()
    {
        if (Coins.Count >= 3 && Input.GetKey(KeyCode.V))
        {
            UseAura();
        }

        if (Coins.Count >= 3)
        {
            AuraBG.color = new Color(110, 255, 110);
        }
        else
        {
            AuraBG.color = new Color(188, 188, 188);
        }

    }

    private void UseAura()
    {
        Controlllller.speed += 3;
        ViewModeeel.fieldOfView = 80;
        Coins.Count -= 3;
        AuraImage.color = new Color(255, 255, 255);
    }
}

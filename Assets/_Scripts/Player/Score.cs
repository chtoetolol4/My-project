using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{   
    public int Count;
    public TextMeshProUGUI ScoreText;

    void Start()
    {
        Count = 0;
        ScoreText.text = "Coins: " + Count.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Count++;
            ScoreText.text = "Coins: " + Count.ToString();
            Destroy(collision.gameObject);
        }
    }
}

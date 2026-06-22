using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{   
    private int count;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        count = 0;
        scoreText.text = "Coins: " + count.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            count++;
            scoreText.text = "Coins: " + count.ToString();
            Destroy(collision.gameObject);
        }
    }
}

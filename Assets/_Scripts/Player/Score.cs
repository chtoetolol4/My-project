using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{   
    public int Count;
    public event Action<int> OnTextUpdate;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        Count = 0;
        scoreText.text = "Coins: " + Count.ToString();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Count++;
            // OnTextUpdate.Invoke(Count);
            scoreText.text = "Coins: " + Count.ToString();
            Destroy(collision.gameObject);
        }
    }
}

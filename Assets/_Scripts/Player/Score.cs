using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{   
    public int Count;
    public event Action<int> OnTextUpdate;

    void Start()
    {
        Count = 0;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Count++;
            OnTextUpdate.Invoke(Count);
            Destroy(collision.gameObject);
        }
    }
}

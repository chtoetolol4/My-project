using UnityEngine;

public class RandomNubers : MonoBehaviour
{
    float Number = 2;
    float M = 1;
    int Count = 1;
    int DeciderRandom = 1;
    void Start()
    {
        for (Count = 0; Count < 6; Count++)
        {
            M = Random.Range(0.3f, 3f);
            DeciderRandom = Random.Range(1, 2);
            if (DeciderRandom == 1)
            {
                Debug.Log(Number / M);
            }
            else
            {
                Debug.Log(Number * M);
            }
            if (Count > 3)
            {
                Number = 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

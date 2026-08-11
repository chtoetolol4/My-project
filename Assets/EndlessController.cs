using UnityEngine;

public class EndlessController : MonoBehaviour
{
    private float[] IslandsPositionZ = new float[5];
    public GameObject Island;
    private float Multiplier = 1;
    private float DeltaY;
    private float MultiplierY = 1;
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Число: " + i);
            IslandsPositionZ[i] = Random.Range(0, 5f);
            if (IslandsPositionZ[i] >= 2f)
            {
                Multiplier = -1;
            }
            else
            {
                Multiplier = 1;
            }
            if (i > 3)
            {
                MultiplierY = -1f;
            }
            else
            {
                MultiplierY = 1;
            }
            Instantiate(Island, new Vector3(i + IslandsPositionZ[i] * Multiplier,MultiplierY * DeltaY,i + IslandsPositionZ[i]), Quaternion.identity);
        } 
    }

    
    void Update()
    {

    }
}

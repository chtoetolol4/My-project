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
            IslandsPositionZ[i] = Random.Range(0, 5f);
            if (IslandsPositionZ[i] >= 2f)
            {
                Multiplier = -1;
            }
            else
            {
                Multiplier = 1;
            }
            DeltaY = Random.Range(0.5f, 2f);
            if (i > 3f)
            {
                MultiplierY = -1;
            }
            else
            {
                MultiplierY = 1;
            }
            Instantiate(Island, new Vector3(i + IslandsPositionZ[i] * Multiplier,(i + IslandsPositionZ[i] * Multiplier) * 0.15f, i + IslandsPositionZ[i]), Quaternion.identity);
        } 
    }

    
    void Update()
    {

    }
}

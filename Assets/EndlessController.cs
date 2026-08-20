using UnityEngine;

public class EndlessController : MonoBehaviour
{
    private float[] IslandsPositionZ = new float[5];
    public GameObject Island;
    private float Multiplier = 1;
    private float DeltaY;
    public Material VirusMaterial;
    public Material HealthyMaterial;
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
            Instantiate(Island, new Vector3(i * 10 + IslandsPositionZ[i] * Multiplier,(i + IslandsPositionZ[i] * Multiplier) * 0.15f, i * 10 + IslandsPositionZ[i]), Quaternion.identity);
            if (i == 4)
            {
                Transform childTransform = Island.transform.Find("floe.011");
                    if (childTransform != null)
                    {
                        GameObject childObject = childTransform.gameObject;
                        childObject.GetComponent<MeshRenderer>().material = VirusMaterial;
                    }
            }
        } 
    }

    
    void Update()
    {

    }
}

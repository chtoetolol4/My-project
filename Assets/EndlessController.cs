using UnityEngine;

public class EndlessController : MonoBehaviour
{
    private float []IslandsPositionZ;
    public GameObject Island;
    private Vector3 IslandRotation;
    void Start()
    {
        // IslandRotation = Island.transform.rotation;
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Число: " + i);
            IslandsPositionZ[i] = Random.Range(0, 5);
            Instantiate(Island, new Vector3(0,0,i), Quaternion.identity);
        } 
    }

    // Update is called once per frame
    void Update()
    {

    }
}

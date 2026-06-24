using UnityEngine;

public class virus : MonoBehaviour
{
    private int IntVirus;
    void Start()
    {
        IntVirus = Random.Range(0, 6);
        Debug.Log(IntVirus);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            IntVirus -= 1;
            Debug.Log(IntVirus);
            
        }
    } 
}

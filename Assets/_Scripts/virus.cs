using UnityEngine;

public class virus : MonoBehaviour
{
    public int IntVirus;
    public Material VirusPlatform;
    public Material HealthyPlatform;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            if(IntVirus > 0)
            {
                IntVirus -= 1;
            }
            else
            {
                GetComponent<MeshRenderer>().material = HealthyPlatform;
            }
            
        }
    } 
}

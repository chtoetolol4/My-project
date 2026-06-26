using UnityEngine;

public class virus : MonoBehaviour
{
    private int IntVirus;
    public Material VirusPlatform;
    public Material HealthyPlatform;
    public GameObject VirusCounter;
    private VirusCounter virusCounter;
    void Start()
    {
        virusCounter = VirusCounter.GetComponent<VirusCounter>();
        IntVirus = Random.Range(0, 6);
        Debug.Log(IntVirus);
        if(IntVirus > 0)
        if(virusCounter.viruscounter < 2)
        {
            virusCounter.viruscounter += 1;
            GetComponent<MeshRenderer>().material = VirusPlatform;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            if(IntVirus > 0)
            {
                IntVirus -= 1;
            }
            else
            {
                Debug.Log("Остров уже здоров");
                GetComponent<MeshRenderer>().material = HealthyPlatform;
            }
            Debug.Log(IntVirus);
            
        }
    } 
}

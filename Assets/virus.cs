using UnityEngine;

public class virus : MonoBehaviour
{
    public int IntVirus;
    public Material VirusPlatform;
    public Material HealthyPlatform;
    public GameObject VirusCounterObject;
    private VirusCounter virusCounter;
    void Start()
    {
        virusCounter = VirusCounterObject.GetComponent<VirusCounter>();
        IntVirus = Random.Range(0, 6);
        Debug.Log(IntVirus);
        if(virusCounter.counter < 2 && IntVirus > 0)
        {
            virusCounter.counter += 1;
            GetComponent<MeshRenderer>().material = VirusPlatform;
        }
        else
        {
            IntVirus = 0;
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

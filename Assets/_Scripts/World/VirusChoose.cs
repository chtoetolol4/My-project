using UnityEngine;

public class VirusChoose : virus
{
    private VirusCounter virusCounter;
    public GameObject VirusCounterObject;
    void Start()
    {
        virusCounter = VirusCounterObject.GetComponent<VirusCounter>();
        IntVirus = Random.Range(0, 6);
        if(virusCounter.counter < 2 && IntVirus > 0)
        {
            virusCounter.counter += 1;
            GetComponent<MeshRenderer>().material = VirusPlatform;
        }
        else
        {
            IntVirus = 0;
        }
        Debug.Log(IntVirus + "--" + virusCounter.counter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

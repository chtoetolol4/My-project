using UnityEngine;

public class animation : MonoBehaviour
{
   public Animator handanimator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            handanimator.SetBool("hand",true);
        }
    }
}

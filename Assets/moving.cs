using UnityEngine;

public class moving : MonoBehaviour
{
    public float speed = 20.3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }
        if( Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speed);
        }
        if( Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed);
        }
        if( Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
        }
    }
}


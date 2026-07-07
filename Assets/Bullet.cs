using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float BulletSpeed = 10f;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * BulletSpeed * Time.deltaTime);
    }

}

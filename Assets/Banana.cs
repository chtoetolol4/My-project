using UnityEngine;

public class Banana : MonoBehaviour
{
    public GameObject bullet;
    public Transform barrel;
    private Quaternion bulletRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletRotation = Quaternion.Euler(barrel.rotation.eulerAngles.x, barrel.rotation.eulerAngles.y, barrel.rotation.eulerAngles.z);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, barrel.position, bulletRotation);
        }

    }
}

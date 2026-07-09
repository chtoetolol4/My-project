using UnityEngine;

public class Banana : MonoBehaviour
{
    public GameObject bullet;
    public Transform barrel;
    private Quaternion bulletRotation;
    public GameObject effect;
    public GameObject StartMenu;
    public ParticleSystem bananeffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletRotation = Quaternion.Euler(barrel.rotation.eulerAngles.x, barrel.rotation.eulerAngles.y, barrel.rotation.eulerAngles.z);
        if (Input.GetMouseButtonDown(0) && StartMenu.activeInHierarchy == false)
        {
            Instantiate(bullet, barrel.position, bulletRotation);
            effect.SetActive(true);
            bananeffect.Play(true);
        }

    }
}

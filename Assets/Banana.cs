using TMPro;
using UnityEngine;

public class Banana : MonoBehaviour
{
    public GameObject bullet;
    public Transform barrel;
    private Quaternion bulletRotation;
    public GameObject effect;
    public GameObject StartMenu;
    public ParticleSystem bananeffect;
    public int CurrentAmmo;
    public TextMeshProUGUI AmmoText;
    void Start()
    {
        CurrentAmmo = 18;
    }

    // Update is called once per frame
    void Update()
    {
        bulletRotation = Quaternion.Euler(barrel.rotation.eulerAngles.x, barrel.rotation.eulerAngles.y, barrel.rotation.eulerAngles.z);
        if (Input.GetMouseButtonDown(0) && StartMenu.activeInHierarchy == false && CurrentAmmo > 0)
        {
            Instantiate(bullet, barrel.position, bulletRotation);
            effect.SetActive(true);
            bananeffect.Play(true);
            CurrentAmmo -= 1;
        }
        AmmoText.text = CurrentAmmo + "/18";
    }
}

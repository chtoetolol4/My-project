using UnityEngine;
using UnityEngine.Tilemaps;
using TMPro;

public class Movement : MonoBehaviour
{   



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Cursor.lockState = CursorLockMode.Locked;
        // Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //  horizontal = Input.GetAxis("Horizontal");
        //  vertical = Input.GetAxis("Vertical");

        //  transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);

        //  if (Input.GetKeyDown(KeyCode.Space) && onIsland == true)
        //  {
        //      rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        //      onIsland = false;
        // }
    }
    private void OnCollisionEnter(Collision collision)
    {

        
    }
}

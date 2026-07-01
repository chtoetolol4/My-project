using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;
using System.Threading;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    private float speed = 7f;
    private float gravity = -9.81f;
    private float jumpHeight = 7f;
    private Vector3 velocity;
    private float speedHor = 9;
    private float speedVert = 9;
    private float minVert = -45;
    private float maxVert = 45;
    private float rotationX;
    private float rotationY;
    private bool onIsland;
    public TextMeshProUGUI scoreText;
    public GameObject GameOver;
    public GameObject CanvasScoreText;

    void Start()
    {

    }

    void Update()
    {
        bool isGrounded = controller.isGrounded;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            velocity.y = jumpHeight;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        rotationX -= Input.GetAxis("Mouse Y") * speedVert;
        rotationX = Mathf.Clamp(rotationX, minVert, maxVert);
        float delta = Input.GetAxis("Mouse X") * speedHor;
        rotationY = transform.localEulerAngles.y + delta;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Void"))
        {
            CanvasScoreText.SetActive(false);
            GameOver.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (hit.gameObject.CompareTag("Coin"))
        {
            
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Island"))
        {
            Debug.Log("Столкновение с островом");
            virus Islandvirus = collision.gameObject.GetComponent<virus>();
            if(Islandvirus != null && Islandvirus.IntVirus > 0)
            {
                Debug.Log("Остров заражен");
                Score score = GetComponent<Score>();
                if(score.count > 0)
                {
                    score.count -= 1;
                    Debug.Log("Минус монетка");
                    scoreText.text = "Coins: " + score.count;
                }
                else
                {
                    CanvasScoreText.SetActive(false);
                    GameOver.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }
            }
        }
    } 
}
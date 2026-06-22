using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;

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
}
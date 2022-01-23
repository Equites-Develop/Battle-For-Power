using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float x, y, z;
    public float speed = 0.0001f;
    public Vector2 turn;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // WASD controls
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Jump"); // todo: make it jump, not "accelerate to the sky" button
        z = Input.GetAxisRaw("Vertical");
        transform.Translate(x * speed, y * speed, z * speed);
        if (Input.GetKey(KeyCode.W))
            Debug.Log($"Current coordinates are {x} {y} {z}");

        // Mouse controls
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}

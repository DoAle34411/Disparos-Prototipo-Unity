using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of movement
    private float horizontalInput; // Input for horizontal movement

    void Update()
    {
        // Get horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the player left or right
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
    }
}
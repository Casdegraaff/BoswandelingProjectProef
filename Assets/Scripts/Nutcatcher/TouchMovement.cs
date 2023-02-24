using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    [SerializeField] private int speed; // Player movement speed

    void Update()
    {
        if (Input.touchCount > 0) // Check if there is a touch input
        {
            Touch touch = Input.GetTouch(0); // Get the first touch input

            if (touch.phase == TouchPhase.Moved) // Check if the touch has moved
            {
                Vector2 touchDeltaPosition = touch.deltaPosition; // Get the delta position of the touch
                float moveX = touchDeltaPosition.x * Time.deltaTime * speed; // Calculate the player's movement in the x-axis
                transform.Translate(moveX, 0, 0); // Move the player
            }
        }

        float currentXPos = transform.position.x;
        currentXPos = Mathf.Clamp(currentXPos, -2.5f, 2.5f); // Restrict the player's movement within a certain range
        transform.position = new Vector3(currentXPos, transform.position.y, transform.position.z); // Update the player's position
    }
}

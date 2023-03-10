using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    // spelers snelheid kan je
    [SerializeField] private int speed; 

    void Update()
    {
        if (Input.touchCount > 0) // Checks of er op het scherm wordt gedrukt
        {
            Touch touch = Input.GetTouch(0); // Pakt de eerste gedrukte punt

            if (touch.phase == TouchPhase.Moved) // Checks of de vinger heeft bewogen.
            {
                Vector2 touchDeltaPosition = touch.deltaPosition; // Pakt de delta positie van de vinger
                float moveX = touchDeltaPosition.x * Time.deltaTime * speed; // Berekend de beweging van vinger in de x-axis
                transform.Translate(moveX, 0, 0); // Beweegt de speler
            }
        }

        float currentXPos = transform.position.x;
        currentXPos = Mathf.Clamp(currentXPos, -2.5f, 2.5f); // Dit zorgt er voor dat er grenzen zijn waar de speler niet buiten kan komen
        transform.position = new Vector3(currentXPos, transform.position.y, transform.position.z); // Update de spelers positie
    }
}
